using System;
class TV { public void On() { Console.WriteLine("TV turned on"); }
    public void Off() { Console.WriteLine("TV turned off"); } }
class SoundSystem { public void On() { Console.WriteLine("Sound system turned on"); } 
    public void Off() { Console.WriteLine("Sound system turned off"); } }
class HomeTheaterFacade{
    private TV tv = new TV();
    private SoundSystem sound = new SoundSystem();
public void WatchMovie(){
        tv.On();
        sound.On();
        Console.WriteLine("Enjoy your movie!"); }
 public void EndMovie() {
        tv.Off();
        sound.Off();
        Console.WriteLine("Movie ended.");
    }}
class FacadeProgram{
    static void Main(){
        HomeTheaterFacade theater = new HomeTheaterFacade();
        theater.WatchMovie();
        theater.EndMovie();
    }
}
