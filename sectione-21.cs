using System;
using System.Collections.Generic;
using System.Linq;
class Employee{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int Salary { get; set; }
}
class Program{
    static void Main(){
        List<Employee> employees = new List<Employee>{
            new Employee { Id = 1, Name = "Kavin", Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Varsha", Department = "HR", Salary = 40000 },
            new Employee { Id = 3, Name = "John", Department = "IT", Salary = 60000 },
            new Employee { Id = 4, Name = "Priya", Department = "Finance", Salary = 45000 },
            new Employee { Id = 5, Name = "Asha", Department = "HR", Salary = 55000 }
        };
var highSalary = from e in employees where e.Salary > 45000 select e;
Console.WriteLine("Employees with Salary > 45000:");
   foreach (var e in highSalary)
            Console.WriteLine($"{e.Name} - {e.Salary}");
var groupByDept = from e in employees group e by e.Department;
 Console.WriteLine("\nEmployees Grouped by Department:");
    foreach (var dept in groupByDept) {
            Console.WriteLine($"\nDepartment: {dept.Key}");
            foreach (var e in dept)
                Console.WriteLine(e.Name);
        }
var orderBySalary = from e in employees orderby e.Salary descending select e;
 Console.WriteLine("\nEmployees Ordered by Salary (Descending):");
        foreach (var e in orderBySalary)
            Console.WriteLine($"{e.Name} - {e.Salary}");
var nameAndDept = from e in employees select new { e.Name, e.Department };
Console.WriteLine("\nEmployee Names and Departments:");
        foreach (var e in nameAndDept)
            Console.WriteLine($"{e.Name} - {e.Department}");
    }
}
