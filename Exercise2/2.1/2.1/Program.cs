using System;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("请输入数字：");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(num+"的质因数有：");
            p.FindPrimeFactors(num);
        }

        bool IsPrimeNumber(int num)
        {
            bool flag=true;
            if (num == 2||num==3)
                return true;
            for (int i = 2; i < Math.Sqrt(num) + 1; i++)
                if (num %i == 0)
                    flag=false;
            return flag;
        }
        void FindPrimeFactors(int num)
        {
            int i = 2;
            if (IsPrimeNumber(num))
                Console.WriteLine(num);
            while(!IsPrimeNumber(num))
            {
                if (num % i == 0&&IsPrimeNumber(i))
                {
                    Console.Write(i + " ");
                    num = num / i;
                }
                else
                    i++;
            }
            Console.Write(num);
        }
    }
}
