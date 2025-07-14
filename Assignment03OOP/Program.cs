using static Assignment03OOP.@enum;

namespace Assignment03OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];

            employees[0] = new Employee(1, "Mohamed", "M", 10000, new HiringDate(10, 1, 2020), SecurityLevel.DBA);
            employees[1] = new Employee(2, "Mariam", "F", 5000, new HiringDate(5, 6, 2022), SecurityLevel.Guest);
            employees[2] = new Employee(3, "Mohanned", "M", 8000, new HiringDate(1, 9, 2023), SecurityLevel.Developer);

            
            Array.Sort(employees, (e1, e2) => e1.HireDate.CompareTo(e2.HireDate));

            Console.WriteLine(" Sorted Employees by Hire Date:\n");
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }

            
            Console.WriteLine("\nBoxing & Unboxing:");
            object obj = employees[0].HireDate; 
            HiringDate unboxedDate = (HiringDate)obj; 
            Console.WriteLine($"Unboxed Hire Date: {unboxedDate}");

            
            Console.WriteLine("Library System:\n");
            Book[] books = new Book[]
            {
            new EBook("Learn C#", "Ahmed", "978-111", 4.5),
            new PrintedBook("python Basics", "Laila", "978-222", 320)
            };

            foreach (var book in books)
            {
                book.Display();
            }
        }
    }
}
