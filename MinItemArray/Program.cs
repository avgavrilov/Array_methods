using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinItemArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            ///123/123
            Random rand = new Random();
            Console.Write("Введите кол-во элементов - ");
            int num = int.Parse(Console.ReadLine());//кол-во элементов массива
            int[] a = new int[num];
            int min = int.MaxValue, max = int.MinValue;


            for (int i = 0; i <= a.Length - 1; i++)
            {
                a[i] = rand.Next(1, 100);
                if (a[i] < min)
                    min = a[i];
                if (a[i] > max)
                    max = a[i];
                Console.WriteLine("a[{0}] = {1}", i, a[i]);
            }


            Console.WriteLine("max = {0}", max);
            Console.WriteLine("min = {0}", min);

            a = del_Item(a);//удаление элемента
            ShowArray(a);// вывести массив b
            Console.ReadKey();

        }
        static void ShowArray(int[] a) // функция вывода массива
        {
            for (int i = 0; i <= a.Length - 1; i++)
                Console.WriteLine("a[{0}] = {1}", i, a[i]);
            return;
        }

        static int[] del_Item(int[] a) // функция удаления элемента
        {
            int[] b = new int[a.Length - 1];
            Console.Write("Введите # элемента для удаления - ");
            int j = 0, del = int.Parse(Console.ReadLine());//# удаляемого элемента

            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (i < del)
                {
                    b[j] = a[i];
                    j++;
                }
                if (i >= del)
                {
                    b[j - 1] = a[i];
                    j++;
                }
            }
            return b;
        }



    }
}

