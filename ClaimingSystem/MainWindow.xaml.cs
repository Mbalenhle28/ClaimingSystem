using System.Windows;

namespace ClaimingSystem
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void OpenSubmissionForm_Click(object sender, RoutedEventArgs e)
		{
			SubmissionForm submissionForm = new SubmissionForm();
			submissionForm.Show();
		}

		private void OpenVerificationView_Click(object sender, RoutedEventArgs e)
		{
			VerificationView verificationView = new VerificationView();
			verificationView.Show();
		}
	}
}
