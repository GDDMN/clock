using System;

namespace Clock
{
  public class ConsoleView : View
  {
    private string _outMessage = "hours: {0}\nminutes {1}";
    public override void ShowTime(int hours, int minutes)
    {
      Console.WriteLine(_outMessage,
                        hours,
                        minutes);

      Console.ReadKey();
    }
  }

}
