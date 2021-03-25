using System;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }
            int max = intlist.Head.Data, min = intlist.Head.Data, sum = 0;
            Action<int> GetMax = m => { if (max < m) max = m; };
            Action<int> GetMin = m => { if (min > m) min = m; };
            Action<int> GetSum = m => sum += m;
            Console.WriteLine("对链表遍历结果为：");
            intlist.ForEach(s=>Console.Write(s+" "));
            intlist.ForEach(GetMax);
            Console.WriteLine("链表中最大值为：" +max );
            intlist.ForEach(GetMin);
            Console.WriteLine("链表中最小值为：" + min);
            intlist.ForEach(GetSum);
            Console.WriteLine("链表元素之和为：" + sum);
        }
    }
}
