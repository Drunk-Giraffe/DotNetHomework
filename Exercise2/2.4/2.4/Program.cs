using System;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("请输入矩阵的行数：");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入矩阵的列数：");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入二维数组：");
            int[,] matrix=new int[m,n];
            for (int i = 0; i < m; i++)
            {
                string str = Console.ReadLine();
                string[] tmp = str.Split(" ".ToCharArray());
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(tmp[j]);
                }
            }
            Console.WriteLine("判断结果："+p.IsToeplitz(matrix,m,n));
        }
        bool IsToeplitz(int [,]matrix,int m,int n)
        {
            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (matrix[i,j] != matrix[i - 1,j - 1])
                        return false;
                }
            }
            return true;
        }
    }
}
