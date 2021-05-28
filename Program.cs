using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a;            
            Console.WriteLine("введите число: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("четное число");

            }
            else
            {
                Console.WriteLine("нечетное");
            }

            if (step(a)) Console.WriteLine("yes");
            else Console.WriteLine("No");          

            Console.ReadKey();
        }

        public static bool step(int a)
        {
            if (a == 2) return true;
            else if (a % 2 == 0) return step(a / 2);
            else return false;
        }
    }
}
