using System;
using System.Globalization;
using static Assignment03OOP.@enum;

namespace Assignment03OOP
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        private string gender;
        public string Gender
        {
            get => gender;
            set
            {
                if (value == "M" || value == "F")
                    gender = value;
                else
                    throw new ArgumentException("Gender must be 'M' or 'F'");
            }
        }

        public double Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public SecurityLevel SecurityLevel { get; set; }

        public Employee(int id, string name, string gender, double salary, HiringDate hireDate, SecurityLevel level)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
            HireDate = hireDate;
            SecurityLevel = level;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Gender: {Gender}, Salary: {string.Format(new CultureInfo("en-US"), "{0:C}", Salary)}, HireDate: {HireDate}, Security: {SecurityLevel}";
        }
    }
}
