using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            int nMax;
            int nMin;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 51);
            }
            Console.Write("Одномерный массив из 15 случайных чисел в диапазоне [0,50]:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0,3}", array[i]);
            }
            nMax = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > nMax)
                    nMax = array[i];
            }
            nMin = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < nMin)
                    nMin = array[i];
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Максимальный элемент массива - {0}", nMax);
            Console.WriteLine("Минимальный элемент массива - {0}", nMin);
            Console.WriteLine("Сумма максимального и минимального элементов - {0}", nMax+nMin);
            Console.ReadKey();
        }
    }
}
