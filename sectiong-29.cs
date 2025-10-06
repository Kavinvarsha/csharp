using System;
using System.Collections.Generic;
interface ISubscriber{
    void Update(string message);
}
class Person : ISubscriber{
    public void Update(string message) {
        Console.WriteLine("Person received: " + message);
    }
}
class Dog : ISubscriber{
    public void Update(string message){
        Console.WriteLine("Dog received: " + message);
    }
}
class AlarmClock{
    private List<ISubscriber> subscribers = new List<ISubscriber>();
    public void Subscribe(ISubscriber subscriber){
        subscribers.Add(subscriber);
    }
public void Unsubscribe(ISubscriber subscriber){
        subscribers.Remove(subscriber);
    }
public void Ring()    {
        Console.WriteLine("AlarmClock: Ring Ring!");
        foreach (var subscriber in subscribers){
            subscriber.Update("Alarm is ringing!");
        }
    }
}
class Program{
    static void Main(){
        AlarmClock alarm = new AlarmClock();
Person person = new Person();
        Dog dog = new Dog();
 alarm.Subscribe(person);
        alarm.Subscribe(dog);
        alarm.Ring();
alarm.Unsubscribe(dog);
        Console.WriteLine("\nAfter unsubscribing Dog:");
        alarm.Ring();
    }
}
