namespace Clock
{
  public class Presenter
  {
    private ModelTime _model = new ModelTime();
    private View _viewer;

    private int _hours;
    private int _minutes;

    public Presenter()
    {
      GetTimeFromModel();
      CreateViewer();
    }

    private void CreateViewer()
    {
      _viewer = ViewerCreator<FormsView>.GetViewer();
    }

    private void GetTimeFromModel()
    {
      _hours = _model.GetTime().Hour;
      _minutes = _model.GetTime().Minute;
    }

    public void ShowTime()
    {
      _viewer.ShowTime(_hours, _minutes);
    }
  }
}
