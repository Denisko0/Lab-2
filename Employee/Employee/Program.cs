using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public enum Working_Position
    {
        
        Newbie = 1,
        Skilled_Padawan,
        Google_Guru,
        TeamLeadear,
        SME,
        Dep_Manager,
    }

    public class Employee
    {
        private string name;
        private string surname;
        private Working_Position working_Position;
        private double period_of_work;
        private const int baseSalary = 10000;

        public Employee(string name, string surname, double period_of_work, Working_Position working_Position)
        {
            Name = name;
            Surname = surname;
            this.period_of_work = period_of_work;
            this.working_Position = working_Position;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

        public double Salary => baseSalary * (int)working_Position * (period_of_work / 1.5 + 1);
        public double Tax_collection => baseSalary * (int)working_Position * 0.4;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Ilon", "Mask", 20, Working_Position.Google_Guru);
            Console.WriteLine($"Salary in one day : ${employee.Salary,0:0.00}");
            Console.WriteLine($"Tax_collection: {employee.Tax_collection}");
        }
    }
}