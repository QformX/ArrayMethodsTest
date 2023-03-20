using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            //CopyMet();
            //ReverseMet();
            //SortMet();
            //RankMet();
            //ClearMet();
            //BinarySearchMet();
            //IndexOfMet();
            //EqualsMet(); - not working
            //TrueForAllMet(); - not working
            //FindMet(); - not working


        }

        static Array CreateArray(int n)
        {
            var arr = Array.CreateInstance(typeof(string), n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Элемент {0}",i);
                arr.SetValue(Console.ReadLine(), i);
            }
            return arr;
        }

        static void ReverseMet()
        {
            PrintL("Кол-во элементов массива");
            int n = Int32.Parse(Console.ReadLine());
            var arr = CreateArray(n);
            Print("Исходный:");

            PrintArray(arr);

            Print("Перевёрнутый:");

            Array.Reverse(arr);
            PrintArray(arr);

            Console.ReadKey();
        }

        static void FindMet()
        {
            PrintL("Кол-во элементов массива");
            int n = Int32.Parse(Console.ReadLine());
            var arr = CreateArray(n);
            Print("Исходный:");

            PrintArray(arr);

            Array.Find(arr, e => e == "Привет");
        }

        static void TrueForAllMet()
        {
            PrintL("Кол-во элементов массива");
            int n = Int32.Parse(Console.ReadLine());
            var arr = Array.CreateInstance(typeof(int), n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Элемент {0}", i);
                arr.SetValue(Console.ReadLine(), i);
            }
            Print("Исходный:");

            PrintArray(arr);

            PrintL("Все элементы содержат букву О");

            

            Console.ReadKey();
        }

        static void EqualsMet()
        {
            PrintL("Кол-во элементов массива");
            int n = Int32.Parse(Console.ReadLine());
            var arr = CreateArray(n);
            var arr_c = CreateArray(n);
            Print("Первый:");

            PrintArray(arr);
            Print("Второй:");

            PrintArray(arr_c);

            if (Array.Equals(arr,arr_c))
            {
                Print("Равны");
            }
            else
            {
                Print("Не равны");
            }

            Console.ReadKey();
        }



        static void BinarySearchMet()
        {
            PrintL("Кол-во элементов массива");
            int n = Int32.Parse(Console.ReadLine());
            var arr = CreateArray(n);
            Print("Исходный:");

            PrintArray(arr);

            Array.Sort(arr);
            Print("Элемент поиска:");
            string ind = Array.BinarySearch(arr, Console.ReadLine()).ToString();
            PrintL(ind);

            Console.ReadKey();
        }

        static void IndexOfMet()
        {
            PrintL("Кол-во элементов массива");
            int n = Int32.Parse(Console.ReadLine());
            var arr = CreateArray(n);
            Print("Исходный:");

            PrintArray(arr);


            Print("Элемент поиска:");
            PrintL(Array.IndexOf(arr, Console.ReadLine()).ToString());

            Console.ReadKey();
        }

        static void ClearMet()
        {
            PrintL("Кол-во элементов массива");
            int n = Int32.Parse(Console.ReadLine());
            var arr = CreateArray(n);
            Print("Исходный:");

            PrintArray(arr);

            Print("Очищенный:");

            Array.Clear(arr, 0, arr.Length);
            PrintArray(arr);

            Console.ReadKey();
        }

        static void SortMet()
        {
            PrintL("Кол-во элементов массива");
            int n = Int32.Parse(Console.ReadLine());
            var arr = CreateArray(n);
            Print("Исходный:");
            PrintArray(arr);
            Print("Отсортированный:");
            Array.Sort(arr);
            PrintArray(arr);
            Console.ReadKey();
        }

        static void RankMet()
        {
            PrintL("Кол-во элементов массива");
            int n = Int32.Parse(Console.ReadLine());
            var arr = CreateArray(n);
            Print("Исходный:");
            PrintArray(arr);
            Print("Ранг:");
            PrintL(arr.Rank.ToString());
            Console.ReadKey();
        }

        static void CopyMet()
        {
            PrintL("Кол-во элементов массива");
            int n = Int32.Parse(Console.ReadLine());
            var arr = CreateArray(n);
            var arr_c = CreateArray(n);
            Array.Copy(arr, arr_c, 0);
            Print("Исходный:");

            PrintArray(arr);
            Print("Копированный:");

            PrintArray(arr_c);
            Console.ReadKey();

        }

        static void PrintL(string txt)
        {
            Console.WriteLine(txt);
        }

        static void Print(string txt)
        {
            Console.Write(txt + "\t");
        }

        static void PrintArray(Array arr)
        {
            foreach (var item in arr)
            {
                if (item != null)
                {
                    Print(item.ToString());
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine();
        }
    }
}
