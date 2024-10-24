using System;
using System.Windows;

namespace ClaimingSystem
{
	public partial class App : Application
	{
		[STAThread]
		public static void Main()
		{
			App app = new App();
			MainWindow mainWindow = new MainWindow(); // Change Form1 to MainWindow
			app.Run(mainWindow); // Start the application with MainWindow
		}
	}
}

