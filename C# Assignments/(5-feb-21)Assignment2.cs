using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
    class secondclass
    {
        static void Main()
        {
            //2.WAP to add three numbers
            int n1;
            Console.WriteLine("Enter number n1");
            n1 = Convert.ToInt32(Console.ReadLine());
            int n2;
            Console.WriteLine("Enter number n2");
            n2 = Convert.ToInt32(Console.ReadLine());
            int n3;
            Console.WriteLine("Enter number n3");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum of {0}, {1}, and {2} is {3}", n1, n2, n3, (n1 + n2 + n3));
            //3. WAP to print sum and average of 1st 20 natural numbers

            int i;
            int sum = 0;
            int avg=0;
            for (i = 1; i <= 20; i++)
            {
                sum = i + sum;
                avg = (sum / 20);
            }
                Console.WriteLine("Sum of first 20 natural numbers is " + sum);
                Console.WriteLine("average of first 20 natural numbers is " + avg);
            //4.WAP to print first 50 even numbers
            Console.WriteLine("50 even numbers are");
            for (i = 2; i <= 100; i += 2)
                Console.WriteLine(i);
            //5. WAP to check whether a number is prime or not
            int m=0;
            int flag = 0;
            m = n1 / 2;
            for (i = 2; i <= m; i++)
            {
                if (n1 % i == 0)
                {
                    Console.WriteLine("{0} is not a prime number",n1);
                    flag = 1;
                    break;
                }
            }

                if(flag==0)
                    Console.WriteLine("{0} is a prime number",n1);
            //6.WAP to print table of entered number in following format 5 * 1 = 5
            int num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 20; i++)
                Console.WriteLine("{0} * {1} = {2}", num, i, (num * i));
            //7.WAP to take some numbers from user.. Note the difference between ToIn16, ToInt32 , ToByte and other methods available 
            int x;
            Console.WriteLine("enter number x");
            x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Entered number is {0}", x);
            int y;
            Console.WriteLine("enter number y");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered number is {0}", y);

            int z;
            Console.WriteLine("enter number z");
            z = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Entered number is {0}",z);


            /*7.difference between ToIn16, ToInt32 , ToByte and other methods available
            The Convert.ToInt16() method returns the 16-bit integer e.g. short, the Convert.ToInt32() returns 32-bit integers e.g. int and the Convert.ToInt64() returns the 64-bit integer e.g. long. */

            /*8. What is System in the program. What are Console and Convert? What are Write, WriteLine , ReadLine and ToByte
            system  : system is a namespace, namespace is logical collection of related classes
            Console : Console is a class which is present in the namespace
            Write, WriteLine :The most common method to output something in C# is WriteLine() and Write().
                        The difference is that WriteLine() prints the output on a new line each time, while Write() prints on the same line
            Convert : this is used to convert one data type to other data type
            ReadLine : it is a input statement to take values
            ToByte : it is used to conver data into bytes */


            /*9. Is it mandatory to have a class in the project
              Yes, C# application must have at least one class with Main method, so that execution can begin from it.*/


            /*10. Why is static added to Main() method?
              A main method is static since it is available to run when the C# program starts. It is the entry point of the program and runs without even creating an instance of the class.*/









        }
    }
}
