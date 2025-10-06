using System;
delegate void SpeakDelegate();   
class Animal{
    public SpeakDelegate Speak;
    public Animal(){
        Speak = DefaultSpeak;
    }
    public void DefaultSpeak(){
        Console.WriteLine("Animal makes a sound");
    }
}
class Program{
    static void Main(){
        Animal animal = new Animal();
        animal.Speak();  
        animal.Speak = DogSpeak;
        animal.Speak();  
    }
    static void DogSpeak(){
        Console.WriteLine("Dog barks");
    }
}
