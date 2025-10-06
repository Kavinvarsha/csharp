using System;
class InvalidAgeException : Exception{
    public InvalidAgeException(string message) : base(message) { }
}
class Program{
    static void CheckAge(int age){
        if (age < 18)
            throw new InvalidAgeException("Age must be 18 or above to vote.");
        else
            Console.WriteLine("You are eligible to vote.");
    }
    static void Main(){
        try{
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            CheckAge(age);
        }
        catch (InvalidAgeException ex){
            Console.WriteLine("Custom Exception: " + ex.Message);
        }
        catch (Exception ex){
            Console.WriteLine("General Exception: " + ex.Message);
        }
        finally{
            Console.WriteLine("Execution completed. Thank you!");
        }
    }
}
