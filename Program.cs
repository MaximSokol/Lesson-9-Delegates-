using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9__Delegates_
{
    //delegate int DelAverage(int a, int b, int c);

    //delegate int DelAdd(int a, int b);
    //delegate int DelSub(int a, int b);
    //delegate int DelMul(int a, int b);
    //delegate int DelDiv(int a, int b);

    delegate int MyDelegate();
    delegate double MyDel(MyDelegate[] arr);

    class Program
    {
        static int GetRandom()
        {
            return new Random().Next(0, 10);
        }

        //public static int GetAverage(int a, int b, int c)
        //{
        //    int toSumUp = 0;
        //    return toSumUp = a + b + c / 3;
        //}

        //public static int GetAddOperation(int a, int b)
        //{
        //    return a + b;
        //}

        //public static int GetSubOperation(int a, int b)
        //{
        //    return a - b;
        //}

        //public static int GetMultOperation(int a, int b)
        //{
        //    return a * b;
        //}

        //public static int GetDivOperation(int a, int b)
        //{
        //    if(b == 0)
        //    {
        //        return a / b;
        //    }
        //    return -1;
        //}

        //public static void ChoosingTheValue()
        //{
        //    DelAdd add;
        //    DelSub sub;
        //    DelMul mul;
        //    DelDiv div;

        //    Console.WriteLine("Enter your choice ->\t");
        //    string choice = Console.ReadLine();
        //    int sumUp = 0;

        //    switch (choice)
        //    {
        //        case "1":
        //            add = (par1, par2) => { return sumUp = par1 + par2; };
        //            int sum = add.Invoke(10, 20);
        //            Console.WriteLine($"The sum is =\t{sum}");
        //            break;
        //        case "2":
        //            sub = (par1, par2) => { return sumUp = par1 - par2; };
        //            int secondSum = sub.Invoke(10, 20);
        //            Console.WriteLine($"The sum is =\t{secondSum}");
        //            break;
        //        case "3":
        //            mul = (par1, par2) => { return sumUp = par1 * par2; };
        //            int thirdSum = mul.Invoke(10, 20);
        //            Console.WriteLine($"The sum is =\t{thirdSum}");
        //            break;
        //        case "4":
        //            div = (par1, par2) => { return sumUp = par1 / par2; };
        //            int fourthSum = div.Invoke(10, 20);
        //            Console.WriteLine($"The sum is =\t{fourthSum}");
        //            break;
        // }
        // }

        static void Main(string[] args)
        {
            // Additional Task


            //DelAverage del = new DelAverage(GetAverage);

            //int sumUp = 0;
            //int a, b, c;
            //a = 1;
            //b = 2;
            //c = 3;

            //del = (x, h, j) => { return sumUp = a + b + c / 3; };

            //int res = del.Invoke(10, 20, 30);
            //Console.WriteLine(res);

            // int k = 1;
            // int l = 2;
            // int f = 3;

            //int average = del(k, l, f);
            // Console.WriteLine($"Average\t{average}");


            // Task 2

            // ChoosingTheValue();

            // Task 3

            Console.WriteLine("Введите число элементов массива:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 10));

            var array = new MyDelegate[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => new MyDelegate(GetRandom).Invoke();
            }

            MyDel del = delegate (MyDelegate[] arr)
            {
                double sr = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sr += arr[i].Invoke();
                }
                return sr / array.Length;
            };

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i].Invoke()}");
            }

            Console.WriteLine("Aaverage\t" + del(array));
        }
    }
}
