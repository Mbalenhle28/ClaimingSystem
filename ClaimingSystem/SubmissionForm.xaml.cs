using System;
using System.Windows;
using Microsoft.Win32;

namespace ClaimingSystem
{
	public partial class SubmissionForm : Window
	{
		private string uploadedFilePath;

		public SubmissionForm()
		{
			InitializeComponent();
		}

		private void UploadDocument_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{
				Filter = "Documents (*.pdf;*.docx)|*.pdf;*.docx",
				Title = "Select Supporting Document"
			};

			if (openFileDialog.ShowDialog() == true)
			{
				uploadedFilePath = openFileDialog.FileName;
				UploadedFileName.Text = System.IO.Path.GetFileName(uploadedFilePath);
			}
		}

		private void SubmitClaim_Click(object sender, RoutedEventArgs e)
		{
			// Example submission logic (you would need to implement actual storage logic)
			string hoursWorked = HoursWorkedTextBox.Text;
			string hoursRaised = HoursRaisedTextBox.Text;
			string additionalNotes = AdditionalNotesTextBox.Text;

			MessageBox.Show("Claim Submitted:\n" +
							$"Hours Worked: {hoursWorked}\n" +
							$"Hours Raised: {hoursRaised}\n" +
							$"Notes: {additionalNotes}\n" +
							$"Document: {UploadedFileName.Text}");
			// Logic to save claim to a database or file goes here
		}
	}
}
