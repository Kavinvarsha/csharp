using System;
class Animal
{
	public virtual void Speak()  {
		Console.WriteLine("Animal speaks");
	}
}
class Dog : Animal
{
	public override void Speak() 
	{
		Console.WriteLine("Dog barks");
	}
}
class Cat : Animal
{
	public override void Speak()
	{
		Console.WriteLine("Cat meows");
	}
}
class Program
{
	static void Main()
	{
		Animal a1 = new Dog();  
		Animal a2 = new Cat();  
        a1.Speak(); 
		a2.Speak();  
	}
}
