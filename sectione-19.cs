using System;
using System.Collections.Generic;
class Repository<T>{
    private List<T> items = new List<T>();
    public void Add(T item){
        items.Add(item);
        Console.WriteLine("Item added.");
    }
    public void Update(int index, T newItem){
        if (index >= 0 && index < items.Count){
            items[index] = newItem;
            Console.WriteLine("Item updated.");
        }
        else{
            Console.WriteLine("Invalid index!");
        }
    }
    public void Delete(T item)
    {
        if (items.Remove(item))
            Console.WriteLine("Item deleted.");
        else
            Console.WriteLine("Item not found!");
    }
    public void GetAll(){
        Console.WriteLine("All items:");
        foreach (T item in items){
            Console.WriteLine(item);
        }
    }
}
class Student{
    public string Name { get; set; }
    public override string ToString() => Name;
}
class Program{
    static void Main() {
        Repository<Student> studentRepo = new Repository<Student>();
        Student s1 = new Student { Name = "Kavin" };
        Student s2 = new Student { Name = "Varsha" };
        studentRepo.Add(s1);
        studentRepo.Add(s2);
        studentRepo.GetAll();
        studentRepo.Update(1, new Student { Name = "KavinVarsha" });
        studentRepo.GetAll();
        studentRepo.Delete(s1);
        studentRepo.GetAll();
    }
}
