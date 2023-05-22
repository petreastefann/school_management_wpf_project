using System.Windows;

namespace school_management_wpf_project.Views.AdminMiniViews {
	/// <summary>
	/// Interaction logic for AdminAddUsers.xaml
	/// </summary>
	public partial class AdminAddUsers : Window {
		public AdminAddUsers() {
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			Close();
		}
	}
}
