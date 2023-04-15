namespace Game;

internal class Program
{
    public static void Main()
    {
        Game game = new Game(@"..\..\..\map.txt");
        var eventLoop = new EventLoop();
        eventLoop.LeftArrowHandler += game.GoLeft;
        eventLoop.RightArrowHandler += game.GoRight;
        eventLoop.UpArrowHandler += game.GoUp;
        eventLoop.DownArrowHandler += game.GoDown;
        
        eventLoop.Run();
    }
}