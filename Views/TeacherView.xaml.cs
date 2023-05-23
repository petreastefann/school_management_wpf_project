using school_management_wpf_project.Views.TeacherMiniViews;
using System.Windows;

namespace school_management_wpf_project.Views {
	/// <summary>
	/// Interaction logic for TeacherView.xaml
	/// </summary>
	public partial class TeacherView : Window {
		public TeacherView() {
			InitializeComponent();
		}

		private void OpenAbsence(object sender, RoutedEventArgs e) {
			TeacherAddAbsences teacherAddAbsences = new() {
				DataContext = this.DataContext
			};

			teacherAddAbsences.Show();
		}

		private void OpenGrade(object sender, RoutedEventArgs e) {
			TeacherAddGrades teacherAddGrades = new() {
				DataContext = this.DataContext
			};

			teacherAddGrades.Show();
		}

		private void OpenAverage(object sender, RoutedEventArgs e) {
			TeacherAddAverages teacherAddAverages = new() {
				DataContext = this.DataContext
			};

			teacherAddAverages.Show();
		}

		private void OpenMaterial(object sender, RoutedEventArgs e) {
			TeacherAddMaterial teacherAddMaterial = new() {
				DataContext = this.DataContext
			};

			teacherAddMaterial.Show();
		}
	}
}
