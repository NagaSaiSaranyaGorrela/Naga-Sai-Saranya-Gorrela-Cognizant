using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_project
{
    class Program
    {
        static void Add(int x,int y)
        {
            Console.WriteLine("Result of sum is " + (x + y));
        }
        static void Sub(int x, int y)
        {
            Console.WriteLine("Result of subtraction is " + (x - y));
        }
        static void product(int x, int y)
        {
            Console.WriteLine("Result of product is " + (x * y));
        }
        static void div(int x, int y)
        {
            Console.WriteLine("Result of division is " + (x / y));
        }



        static void Main()
        {
            Console.WriteLine("enter two numbers and your choice");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int choice = Convert.ToInt32(Console.ReadLine());
            //Using if else
            if (choice == 1)
            {
                Add(x, y);
            }
            else if (choice == 2)
            {
                Sub(x, y);
            }
            else if (choice == 3)
            {
                product(x, y);
            }
            else if (choice == 4)
            {
                div(x, y);
            }
            else
                Console.WriteLine("Invalid choice");
            //using switch
            switch(choice)
            {
                case 1: Add(x, y);
                    break;
                case 2: Sub(x, y);
                    break;
                case 3: product(x, y);
                    break;
                case 4: div(x, y);
                    break;
                default: Console.WriteLine("Invalid choice");
                    break;
            }
            
        }
    }
}
