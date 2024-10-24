using System.Windows;

namespace ClaimingSystem
{
	public partial class ErrorHandlingPage : Window
	{
		public ErrorHandlingPage(string errorMessage)
		{
			InitializeComponent();
			ErrorMessageTextBlock.Text = errorMessage; // Set the error message
		}

		private void CloseButton_Click(object sender, RoutedEventArgs e)
		{
			this.Close(); // Close the error handling page
		}
	}
}

