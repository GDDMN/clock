namespace Clock
{
  public class FormsView : View
  {
    private Form1 _form = new Form1();
    
    public override void ShowTime(int hours, int minutes)
    {
      string message = hours + ":" + minutes;

      _form.SetTimeText(message);
      _form.ShowDialog();
    }
  }
}
