using System;
using System.Threading;
using System.Threading.Tasks;
class Program{
    static void PrintNumbersThread(string name) {
        for (int i = 1; i <= 5; i++){
            Console.WriteLine($"{name} prints {i}");
            Thread.Sleep(400);}
    }static void PrintNumbersTask(string name){
        for (int i = 1; i <= 5; i++){
            Console.WriteLine($"{name} prints {i}");
            Task.Delay(400).Wait();
        }
    }static void Main() {
        Console.WriteLine("=== Using Threads ===");
        Thread t1 = new Thread(() => PrintNumbersThread("Thread 1"));
        Thread t2 = new Thread(() => PrintNumbersThread("Thread 2"));
        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
        Console.WriteLine("\n=== Using Tasks (TPL) ===");
        Task task1 = Task.Run(() => PrintNumbersTask("Task 1"));
        Task task2 = Task.Run(() => PrintNumbersTask("Task 2"));
        Task.WaitAll(task1, task2);
        Console.WriteLine("\nAll threads and tasks completed!");
    }
}
