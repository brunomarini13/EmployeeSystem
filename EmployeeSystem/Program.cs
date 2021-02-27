using System;
using System.Globalization;
using System.Collections.Generic;

namespace EmployeeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("How many employees will be registered? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("ID: ");
                int idNumber = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee { Id = idNumber, Name = name, Salary = salary });
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int answer = int.Parse(Console.ReadLine());


            int raiseId = list.FindIndex(x => x.Id == answer);

            if (raiseId == -1)
            {
                Console.WriteLine("This id does not exist!");
            }
            else
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list[raiseId].Raise(percentage); 
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");

            foreach (Employee obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
