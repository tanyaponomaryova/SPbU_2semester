namespace Game;

public class EventLoop
{
    // public delegate void EventHandler<TEventArgs>(object? sender, TEventArgs e): MulticastDelegate
    public event EventHandler<EventArgs> LeftArrowHandler = (sender, args) => { }; 
    public event EventHandler<EventArgs> RightArrowHandler = (sender, args) => { };
    public event EventHandler<EventArgs> UpArrowHandler = (sender, args) => { };
    public event EventHandler<EventArgs> DownArrowHandler = (sender, args) => { };

    public void Run()
    {
        var shouldComplete = false;
        while (!shouldComplete)
        {
            var key = Console.ReadKey(true); // нажатая клавиша не будет отображаться на консоли
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    LeftArrowHandler(this, EventArgs.Empty);
                    break;
                case ConsoleKey.RightArrow:
                    RightArrowHandler(this, EventArgs.Empty);
                    break;
                case ConsoleKey.UpArrow:
                    UpArrowHandler(this, EventArgs.Empty);
                    break;
                case ConsoleKey.DownArrow:
                    DownArrowHandler(this, EventArgs.Empty);
                    break;
                default:
                    shouldComplete = true;
                    break;
            }
        }
    }
}