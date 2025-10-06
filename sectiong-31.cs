using System;
using System.Collections.Generic;
using System.Linq;
class Employee{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
}
class Repository<T> where T : class{
    private List<T> entities = new List<T>();
    public void Add(T entity) { entities.Add(entity); }
    public void Update(T oldEntity, T newEntity){
        int index = entities.IndexOf(oldEntity);
        if (index >= 0) entities[index] = newEntity;}
    public void Delete(T entity) { entities.Remove(entity); }
    public List<T> GetAll() { return entities.ToList(); }}
class UnitOfWork{
    public Repository<Employee> Employees { get; } = new Repository<Employee>();
    public void Commit() { Console.WriteLine("Changes committed to the database."); }}
class Program{
    static void Main(){
        UnitOfWork unit = new UnitOfWork();
        Employee e1 = new Employee { Id = 1, Name = "Kavin", Department = "IT" };
        Employee e2 = new Employee { Id = 2, Name = "Varsha", Department = "HR" };
        unit.Employees.Add(e1);
        unit.Employees.Add(e2);
        unit.Commit();
        Console.WriteLine("Employees:");
        foreach (var e in unit.Employees.GetAll()) Console.WriteLine($"{e.Id} - {e.Name} - {e.Department}");
        Employee updated = new Employee { Id = 2, Name = "Varsha K.", Department = "HR" };
        unit.Employees.Update(e2, updated);
        unit.Commit();
        Console.WriteLine("After Update:");
        foreach (var e in unit.Employees.GetAll()) Console.WriteLine($"{e.Id} - {e.Name} - {e.Department}");
        unit.Employees.Delete(e1);
        unit.Commit();
        Console.WriteLine("After Delete:");
        foreach (var e in unit.Employees.GetAll()) Console.WriteLine($"{e.Id} - {e.Name} - {e.Department}");
    }
}
