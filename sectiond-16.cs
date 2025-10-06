using System;
delegate int MathOperation(int a, int b);
class Calculator
{
	public static int Add(int a, int b)
	{
		return a + b;
	}
	public static int Subtract(int a, int b)
	{
		return a - b;
	}
	public static int Multiply(int a, int b)
	{
		return (a * b);
	}
	public static int Divide(int a, int b)
	{
		return (a / b);
	}
	public static int Modulo(int a,int b)
	{
		return (a % b);
	}
}
class Program{
	static void Main(){
		MathOperation op;
        op = Calculator.Add;
		Console.WriteLine("Addition: " + op(10, 5)); 
        op = Calculator.Subtract;
		Console.WriteLine("Subtraction: " + op(10, 5));  
        op = Calculator.Multiply;
		Console.WriteLine("Multiplication: " + op(10, 5));  
        op = Calculator.Divide;
		Console.WriteLine("Division: " + op(10, 5));
		op = Calculator.Modulo;
		Console.WriteLine("modulo: " + op(10, 5));
	}
}
