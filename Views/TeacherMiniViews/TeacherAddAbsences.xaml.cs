using System.Windows;

namespace school_management_wpf_project.Views.TeacherMiniViews {
	/// <summary>
	/// Interaction logic for TeacherAddAbsences.xaml
	/// </summary>
	public partial class TeacherAddAbsences : Window {
		public TeacherAddAbsences() {
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e) {
			Close();
		}
	}
}
