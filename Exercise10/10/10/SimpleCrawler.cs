using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10
{
    class SimpleCrawler
    {
        public event Action<SimpleCrawler> CrawlerStopped;
        public event Action<SimpleCrawler, string, string> PageDownloaded;
        //待下载队列
        ConcurrentQueue<string> pending = new ConcurrentQueue<string>();
        //已下载网页
        public ConcurrentDictionary<string, bool> DownloadedPages { get; } = new ConcurrentDictionary<string, bool>();
        //URL检测表达式，用于在HTML文本中查找URL
        public static readonly string UrlDetectRegex = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";
        //URL解析表达式
        public static readonly string urlParseRegex = @"^(?<site>(?<protocal>https?)://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
        //主机过滤规则
        public string HostFilter { get; set; }
        //文件过滤规则
        public string FileFilter { get; set; }
        //最大下载数量
        public int MaxPage { get; set; }
        //起始网址
        public string StartURL { get; set; }
        //网页编码
        public Encoding HtmlEncoding { get; set; }
        public int MaxParallel = 100;
        public SimpleCrawler()
        {
            MaxPage = 100;
            HtmlEncoding = Encoding.UTF8;
        }

        public async Task Start()
        {
            DownloadedPages.Clear();
            while (pending.TryDequeue(out string result)){}
            pending.Enqueue(StartURL);

            while (DownloadedPages.Count < MaxPage && pending.Count > 0)
            {
                if(MaxParallel>0&&DownloadedPages.Count>MaxParallel)
                {
                    await Task.Delay(100);
                    continue;
                }
                string url;
                pending.TryDequeue(out url);
                try
                {
                    string html = await DownLoad(url); // 下载
                    DownloadedPages[url] = true;
                    PageDownloaded(this, url, "success");
                    Parse(html, url);//解析,并加入新的链接
                }
                catch (Exception ex)
                {
                    PageDownloaded(this, url, "  Error:" + ex.Message);
                }
            }
            CrawlerStopped(this);
        }

        private async Task<string> DownLoad(string url)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string html = await webClient.DownloadStringTaskAsync(url);
            string fileName = DownloadedPages.Count.ToString();
            await Task.Factory.StartNew(()=>File.WriteAllText(fileName, html, Encoding.UTF8));
            return html;
        }

        private void Parse(string html, string pageUrl)
        {
            var matches = new Regex(UrlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "" || linkUrl.StartsWith("javascript:")) continue;

                linkUrl = FixUrl(linkUrl, pageUrl);//转绝对路径
                                                   //解析出host和file两个部分，进行过滤
                Match linkUrlMatch = Regex.Match(linkUrl, urlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter)
                  && !DownloadedPages.ContainsKey(linkUrl))
                {
                    pending.Enqueue(linkUrl);
                }
            }
        }

        //将非完整路径转为完整路径
        static private string FixUrl(string url, string pageUrl)
        {
            if (url.Contains("://"))
            { //完整路径
                return url;
            }
            if (url.StartsWith("//"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                string protocal = urlMatch.Groups["protocal"].Value;
                return protocal + ":" + url;
            }
            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = pageUrl.LastIndexOf('/');
                return FixUrl(url, pageUrl.Substring(0, idx));
            }

            if (url.StartsWith("./"))
            {
                return FixUrl(url.Substring(2), pageUrl);
            }
            //非上述开头的相对路径
            int end = pageUrl.LastIndexOf("/");
            return pageUrl.Substring(0, end) + "/" + url;
        }
    }
}
