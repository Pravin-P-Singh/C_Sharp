using ClassLibrary;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employees for entering their details:: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            
            for(int i = 1; i <= numberOfEmployees; i++)
            {
                Console.WriteLine("****************************************");
                Console.WriteLine($"Provide details for employee {i}");
                Console.WriteLine("Enter the employee id:");
                int empId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the employee name:");
                string empName = Console.ReadLine();
                Console.WriteLine("Enter the salary per hour:");
                double salaryPerHour = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of workingHours:");
                int numberOfWorkingHours = int.Parse(Console.ReadLine());

                Employee e = new Employee(empId, empName, salaryPerHour, numberOfWorkingHours);
                employees.Add(e);
            }

            Console.WriteLine("Do you want me to display the employee details ? Yes(y) No(n)");
            string userInput = Console.ReadLine();

            if (userInput.Equals("y"))
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Details of employee {i+1}");
                    Employee.display(employees[i]);
                    Console.WriteLine("Do you want to display the next employee details? Yes(y) No(n)");
                    string choice = Console.ReadLine();
                    if (choice.Equals('n'))
                    {
                        break;
                    }
                }
            }
        }

        public double NetSalary(double salaryPerHour, double numberOfWorkingHours)
        {
            return salaryPerHour * numberOfWorkingHours;
        }
    }
}
