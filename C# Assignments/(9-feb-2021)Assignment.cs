using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        int emid;
        string name;
        string dep;
        string manager;
        int basic_salary;
        int exp;
        double DA = 0;
        double HRA = 0;
        double PF;
        double NetSalary;
        public void GetEmployeeDetails()
        {
            Console.WriteLine("Enter Employee iD");
            emid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter department name");
            dep = Console.ReadLine();
            Console.WriteLine("Enter Manager name");
            manager = Console.ReadLine();
            Console.WriteLine("Enter basic salary");
            basic_salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employe experience");
            exp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Employee details are");
            Console.WriteLine("Employe iD :"+emid);
            Console.WriteLine("Employe Name :"+name);
            Console.WriteLine("Department :"+dep);
            Console.WriteLine("Manager Name :"+manager);
            Console.WriteLine("Experience :"+exp);
        }
        public void CalculateNetSalary()
        {
            if (exp > 10)
            {
                DA = (basic_salary * 10) / 100;
                HRA = (basic_salary * 8.5) / 100;
                PF = 6200;
            }
            else if (exp > 7 && exp <= 10)
            {
                DA = (basic_salary * 7) / 100;
                HRA = (basic_salary * 6.5) / 100;
                PF = 4100;

            }
            else if (exp > 5 && exp <= 7)
            {
                DA = (basic_salary * 4.1) / 100;
                HRA = (basic_salary * 3.8) / 100;
                PF = 1800;

            }
            else if (exp < 5)
            {
                DA = (basic_salary * 1.9) / 100;
                HRA = (basic_salary * 2.0) / 100;
                PF = 1200;

            }

            NetSalary = (basic_salary + DA + HRA) - PF;

        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Basic salary :" + basic_salary);
            Console.WriteLine("DA :" + DA);
            Console.WriteLine("HRA :" + HRA);
            Console.WriteLine("PF :" + PF);
            Console.WriteLine("Net salary :" + NetSalary);

        }

    }
    class assclasses
    {
        static void Main()
        {
            Employee[] employee = new Employee[10];
            for (int i = 0; i < 5; i++)
            {
                employee[i] = new Employee();
                employee[i].GetEmployeeDetails();
                employee[i].CalculateNetSalary();
                employee[i].DisplayEmployeeDetails();
            }


        }
    }

}