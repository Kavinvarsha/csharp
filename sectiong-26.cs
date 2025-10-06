using System;
class Singleton{
    private static Singleton instance; 
    private Singleton() {
        Console.WriteLine("Singleton instance created!");
    }
    public static Singleton GetInstance() {
        if (instance == null){
            instance = new Singleton();
        }
        return instance;
    }
    public void ShowMessage(){
        Console.WriteLine("Hello from Singleton!");
    }
}
class Program{
    static void Main(){
        Singleton s1 = Singleton.GetInstance();
        s1.ShowMessage();
        Singleton s2 = Singleton.GetInstance();
        s2.ShowMessage();
        if (s1 == s2)
            Console.WriteLine("Both references point to the same instance.");
    }
}
