using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для вычисления факториала");
            int n = Convert.ToInt32(Console.ReadLine());
            FactAsync(n);
            Fact2(n);

            Console.ReadKey();
        }

        static void Fact(int n)
        {           
            int factorial = 1;  

            for (int i = 2; i <= n; i++) 
            {
                factorial = factorial * i;
                Thread.Sleep(100);
            }
            Console.WriteLine("Асинхронный {0}!={1}",n,factorial);
        }
        static void Fact2(int n)
        {
            int factorial = 1;

            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
                Thread.Sleep(100);
            }
            Console.WriteLine("Cинхронный {0}!={1}", n, factorial);
        }

        static async void FactAsync(int n)
        {
            await Task.Run(()=> Fact(n));
        }


    }
}
