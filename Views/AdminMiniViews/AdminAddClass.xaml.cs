using System.Windows;

namespace school_management_wpf_project.Views.AdminMiniViews {
	/// <summary>
	/// Interaction logic for AdminAddClass.xaml
	/// </summary>
	public partial class AdminAddClass : Window {
		public AdminAddClass() {
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			Close();
		}
	}
}
