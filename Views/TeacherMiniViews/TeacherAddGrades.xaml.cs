using System.Windows;

namespace school_management_wpf_project.Views.TeacherMiniViews {
	/// <summary>
	/// Interaction logic for TeacherAddGrades.xaml
	/// </summary>
	public partial class TeacherAddGrades : Window {
		public TeacherAddGrades() {
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			Close();
		}
	}
}
