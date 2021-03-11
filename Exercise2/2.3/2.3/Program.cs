using System;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2-100以内的素数有：");
            int[] array = new int[99];
            int arrayLength = array.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = i + 2;
            }
            for (int j = 2; j < (Math.Sqrt(100) + 1); j++)
            {
                for (int i = 0; i < arrayLength; i++)
                    if (array[i] % j == 0&&(array[i]/j)>1)
                    {
                        array[i] = 0;
                    }
            }
            for(int k=0;k<arrayLength;k++)
            {
                if(array[k]!=0)
                    Console.Write(array[k] + " ");
            }
        }
    }
}
