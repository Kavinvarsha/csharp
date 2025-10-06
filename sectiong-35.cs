using System;
using System.Collections.Generic;
class Student : IComparable<Student>{
    public string Name { get; set; }
    public int Marks { get; set; }
public int CompareTo(Student other){
        return this.Marks.CompareTo(other.Marks);}
}
class Program{
    static void Main(){
        List<Student> students = new List<Student> {
            new Student { Name = "Kavin", Marks = 85 },
            new Student { Name = "Varsha", Marks = 92 },
            new Student { Name = "Arun", Marks = 78 }
        };
students.Sort(); 
Console.WriteLine("Students sorted by marks:");
        foreach (var student in students){
            Console.WriteLine($"{student.Name} - {student.Marks}");
        }
    }
}
