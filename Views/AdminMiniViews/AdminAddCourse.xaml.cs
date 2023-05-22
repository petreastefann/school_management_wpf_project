using System.Windows;

namespace school_management_wpf_project.Views.AdminMiniViews {
	/// <summary>
	/// Interaction logic for AdminAddCourse.xaml
	/// </summary>
	public partial class AdminAddCourse : Window {
		public AdminAddCourse() {
			InitializeComponent();
		}

		private void Close(object sender, RoutedEventArgs e) {
			Close();
		}
	}
}
