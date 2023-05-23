using System.Windows;

namespace school_management_wpf_project.Views.StudentMiniViews {
	/// <summary>
	/// Interaction logic for StudentViewAllGrades.xaml
	/// </summary>
	public partial class StudentViewAllGrades : Window {
		public StudentViewAllGrades() {
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			Close();
		}
	}
}
