using System;
using System.Threading;
using System.Threading.Tasks;
class Logger{
    private static Logger instance;
    private static readonly object lockObj = new object();
  private Logger()  {
        Console.WriteLine("Logger instance created!");
    }
    public static Logger GetInstance(){
        if (instance == null){
            lock (lockObj) {
                if (instance == null) {
                    instance = new Logger();
                }
            }
        }
        return instance;
    }
    public void Log(string message){
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] {message} - Instance Hash: {this.GetHashCode()}");
    }
}
class Program{
    static void Main(){
        Console.WriteLine("=== Demonstrating with Threads ===");
        Thread[] threads = new Thread[5];
        for (int i = 0; i < 5; i++) {
            threads[i] = new Thread(() =>{
                Logger logger = Logger.GetInstance();
                logger.Log($"Thread {Thread.CurrentThread.ManagedThreadId} logging");
            });
            threads[i].Start();
        }
foreach (var t in threads)
            t.Join();
Console.WriteLine("\n=== Demonstrating with Tasks ===");
        Task[] tasks = new Task[5];
        for (int i = 0; i < 5; i++){
            tasks[i] = Task.Run(() =>{
                Logger logger = Logger.GetInstance();
                logger.Log($"Task {Task.CurrentId} logging");
            });
        }Task.WaitAll(tasks);
    }
}
