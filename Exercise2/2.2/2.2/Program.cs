using System;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("请输入数组元素个数：");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("请输入数组：");
            int[] array=new int[num];
            for (int i = 0; i < num; i++)
                array[i] = Int32.Parse(Console.ReadLine());
            Console.WriteLine("数组最大值为："+p.GetMax(array));
            Console.WriteLine("数组最小值为：" + p.GetMin(array));
            Console.WriteLine("数组平均值为：" + p.GetAve(array));
            Console.WriteLine("数组元素和为：" + p.GetSum(array));
        }
        int GetMax(int []array)
        {
            int Max = array[0];
            for (int i = 0; i < array.Length; i++)
                if (Max < array[i])
                    Max = array[i];
            return Max;
        }
        int GetMin(int[] array)
        {
            int Min = array[0];
            for (int i = 0; i < array.Length; i++)
                if (Min > array[i])
                    Min = array[i];
            return Min;
        }
        double GetAve(int []array)
        {
            double Ave;
            int Sum=0;
            for (int i = 0; i < array.Length; i++)
                Sum += array[i];
            return Ave = (double)(Sum / array.Length);
        }
        int GetSum(int []array)
        {
            int Sum = 0;
            for (int i = 0; i < array.Length; i++)
                Sum += array[i];
            return Sum;
        }
    }
}
