using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int EvenEnd(int number)
        {
            return number == 0 ? number : number + 1;
        }
        static void Main(string[] args)
        {
            int i = 1;
            while (i != 0)
            {
                int num1 = 3, num2 = 5 , num3= 1, num4= 1;
                Console.WriteLine("Введите 3 числа");
                try { num1 = int.Parse(Console.ReadLine()); } catch { }
                try { num2 = int.Parse(Console.ReadLine()); } catch { }
                try { num3 = int.Parse(Console.ReadLine()); } catch { }
                try { num4 = int.Parse(Console.ReadLine()); } catch { }
                Console.WriteLine(((num1 > num2 ? num1 : num2) > num3 ? num2 : num3));
                Console.WriteLine(num1 > num2 ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3));
                Console.WriteLine(num1 > num2 ? ((num1 > num3 ? num1 : num3) > num4 ? num1 : num4) : ((num2 > num3 ? num2 : num3) > num4 ? num2 : num4));
                Console.WriteLine("Выход - 0");
                try { i = int.Parse(Console.ReadLine()); } catch { }
                EvenEnd(i);
            }   
            
        }
    }
}
