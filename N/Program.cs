using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace N //Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Fctrl(n);
            Console.ReadKey();
        }
        static void Fctrl(int n)
        {
            int f = 1;

            if (n == 0)
            {
                f = 1;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    f *= i;
                    Thread.Sleep(100);
                }
            }
            
            Console.WriteLine(f);
        }

        static async void FctrlAsync(int n)   
        {
            await Task.Run(()=>Fctrl(n));   //await - чтобы не блокировать работу программы
        }
       
        
    }
    
}
