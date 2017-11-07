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
            int[] a = new int[0];
            bool exit = false;
            /*Console.Write("Сгенерировать массив? y/n ");

            if (Console.ReadLine() == "y")
            {
                a = new_Mas();
                ShowArray(a);
            }*/

            do
            {
                Console.WriteLine("Сгенерировать массив (введите 1)");
                Console.WriteLine("Удаление элемента (введите 2)");
                Console.WriteLine("Для выхода (введите 9)");
                switch (Int32.Parse(Console.ReadLine()))
                {

                    case 1:
                        a = new_Mas();
                        ShowArray(a);
                        Console.WriteLine();
                        break;

                    case 2:
                        a = del_Item(a);//удаление элемента
                        ShowArray(a);// вывести
                        Console.WriteLine();
                        break;
                    
                    case 9:
                        exit = true;
                        break;
                }
            }
            while (exit == false);
            //Console.ReadKey();

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
        static int[] new_Mas() // создание массива
        {
            Random rand = new Random();
            Console.Write("Введите кол-во элементов - ");
            int num = int.Parse(Console.ReadLine());//кол-во элементов массива
            int[] a = new int[num];

            for (int i = 0; i <= a.Length - 1; i++)
            {
                a[i] = rand.Next(1, 100);
            }
            return a;
        }
    }
}

