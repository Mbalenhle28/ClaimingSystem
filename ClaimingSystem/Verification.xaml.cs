using System.Windows;
using System.Windows.Controls;

namespace ClaimingSystem
{
	public partial class VerificationView : Window
	{
		public VerificationView()
		{
			InitializeComponent();
			LoadClaims();
		}

		private void LoadClaims()
		{
			// Sample data for claims. Replace with actual data fetching logic.
			ClaimsListView.Items.Add(new Claim { ClaimID = 1, LecturerName = "John Doe", HoursWorked = 10, Status = "Pending" });
			ClaimsListView.Items.Add(new Claim { ClaimID = 2, LecturerName = "Jane Smith", HoursWorked = 5, Status = "Pending" });
		}

		private void Approve_Click(object sender, RoutedEventArgs e)
		{
			var button = sender as Button;
			var claim = button.DataContext as Claim;
			claim.Status = "Approved";
			ClaimsListView.Items.Refresh();
		}

		private void Reject_Click(object sender, RoutedEventArgs e)
		{
			var button = sender as Button;
			var claim = button.DataContext as Claim;
			claim.Status = "Rejected";
			ClaimsListView.Items.Refresh();
		}
	}

	public class Claim
	{
		public int ClaimID { get; set; }
		public string LecturerName { get; set; }
		public int HoursWorked { get; set; }
		public string Status { get; set; }
	}
}
