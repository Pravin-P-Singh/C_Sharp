using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double SalaryPerHour { get; set; }
        public int NumberOfWorkingHours { get; set; }
        public double NetSalary { get; set; }

        public static string OrganizationName = "Harsha Inc";

        public const string TypeOfEmployee ="Contract Based";
        private readonly string DepartmentName;

        public Employee() { }
        public Employee(int empId, string empName, double salaryPerHour, int numberOfWorkingHours )
        {
            this.DepartmentName = "Finance Department";
            this.EmpId=empId;
            this.EmpName = empName;
            this.SalaryPerHour = salaryPerHour;
            this.NumberOfWorkingHours = numberOfWorkingHours;
        }

        public static void display(Employee e)
        {
            Console.WriteLine($"Employee Id: {e.EmpId} | Employee Name: {e.EmpName} | Employee Department: {e.DepartmentName} | Employee Salary Per Hour: {e.SalaryPerHour} | Employee Number Of Working Hours: {e.NumberOfWorkingHours} | Employee Type : {TypeOfEmployee} ");
        }

    }
}
