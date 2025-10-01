using System;
class Animal
{
    public void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Dog : Animal
{
    public new void Speak()  
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main()
    {
        Animal a = new Animal();
        a.Speak();  
        Dog d = new Dog();
        d.Speak(); 
        Animal a2 = new Dog();
        a2.Speak(); 
    }
}
