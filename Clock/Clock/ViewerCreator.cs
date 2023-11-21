namespace Clock
{
  public static class ViewerCreator<T> where T : View, new()
  {
    public static T GetViewer()
    {
      T viewer = new T();
      return viewer;
    }
  }
}
