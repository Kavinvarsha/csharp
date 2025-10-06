using System;
using System.Collections;
using System.Collections.Generic;
class Student{
    public string Name { get; set; }
    public int Age { get; set; }
    public override string ToString(){
        return $"{Name} ({Age} years old)";}
}
class StudentList : IEnumerable<Student>{
    private List<Student> students = new List<Student>();
    public void AddStudent(Student s){
        students.Add(s);
    }
    public IEnumerator<Student> GetEnumerator(){
        foreach (var s in students){
            yield return s;
        }
    }
    IEnumerator IEnumerable.GetEnumerator(){
        return GetEnumerator();
    }
}
class Program{
    static void Main(){
        StudentList list = new StudentList();
        list.AddStudent(new Student { Name = "Kavin", Age = 21 });
        list.AddStudent(new Student { Name = "Varsha", Age = 20 });
        Console.WriteLine("Student List:");
        foreach (var s in list){
            Console.WriteLine(s);
        }
    }
}
