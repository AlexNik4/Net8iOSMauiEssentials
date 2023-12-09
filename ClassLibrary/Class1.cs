namespace ClassLibrary
{
	public class SharedClass
	{
		public bool IsMain()
		{
			return Microsoft.Maui.ApplicationModel.MainThread.IsMainThread;
		}
	}
}
