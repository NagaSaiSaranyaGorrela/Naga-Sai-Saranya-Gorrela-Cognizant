using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int z = 30;
            //2. WAP to add three numbers
            Console.WriteLine("sum of {0} and {1} and {2} is {3}", x, y, z, (x + y + z));
            //3. WAP to multiple 3 numbers
            Console.WriteLine("product of " + x + " , " + y + " and " + z + " is " + (x * y * z));
            //4. What is System in the program. What is Console? What are Write, WriteLine 
            //System: System is a namespace. Namespace is a logical colection of related classes.
            //Console: Console is a class and which is present in system namespace.
            //Write: Write is a method ehich is present in class and is used to display output.
            //WriteLine: WriteLine is a method which is present in class and is used to diplay output line by line.

            //5. Is it mandatory to have a class in the project
            //Yes,It is mandatory to have atleast one class in the project.

            //6. WAP to declare string and integer variables to hold id, name , address , salary 
            int id = 101;
            string name = "Ajay";
            string address = "ABC, Delhi";
            int salary = 25000;

            Console.WriteLine("Welcome " + name + ", Your details are as follows:");
            Console.WriteLine("Your ID: " + id);
            Console.WriteLine("Your Address is :" + address);
            Console.WriteLine("Your salary is: " + salary);



        }
    }
}

  
