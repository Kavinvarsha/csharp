using System;
interface IFlyable { //interface
	void Fly();
}
abstract class Animal{ //abstract class
	public void Eat() { Console.WriteLine("Eating..."); }
	public abstract void MakeSound();}
class Bird : Animal, IFlyable{
	public void Fly() { Console.WriteLine("Bird is flying"); }
	public override void MakeSound() { Console.WriteLine("Chirp"); }}
class MathUtil{
	public int MultiplyByTwo(int x) { return x * 2; } // Instance method
	public static int Add(int a, int b) { return a + b; } // Static method
}
class Program{
	static void Main(){
		// Interface & Abstract Class demo
		Bird b = new Bird();
		b.Eat();
		b.MakeSound();
		b.Fly();
// Instance & Static Method demo
		MathUtil util = new MathUtil();
		Console.WriteLine("MultiplyByTwo(5): " + util.MultiplyByTwo(5));
		Console.WriteLine("Add(5,3): " + MathUtil.Add(5, 3));
	}
}
