using System;
public delegate void AlarmHandler();
class AlarmClock{
    public event AlarmHandler Ring;  
    public void StartAlarm(){
        Console.WriteLine("Alarm is ringing...");
        Ring?.Invoke(); }
}
class Person{
    public void WakeUp(){
        Console.WriteLine("Person: Woke up!");
    }
}
class Dog{
    public void Bark(){
        Console.WriteLine("Dog: Started barking!");
    }
}
class Program{
    static void Main(){
        AlarmClock alarm = new AlarmClock(); 
        Person p = new Person();             
        Dog d = new Dog();                   
        alarm.Ring += p.WakeUp;
        alarm.Ring += d.Bark;
        alarm.StartAlarm();
    }
}
