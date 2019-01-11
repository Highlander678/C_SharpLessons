using System.ServiceProcess;

namespace WindowsServices
{
	static class Program
	{
		/// <summary>
		/// Точка входа в приложение.
		/// </summary>
		static void Main()
		{
			ServiceBase[] ServicesToRun;
			ServicesToRun = new ServiceBase[] 
			{ 
				new MyService() 
			};
			ServiceBase.Run(ServicesToRun);
		}
	}
}
