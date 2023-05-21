using school_management_wpf_project.Views.TeacherMiniViews;
using System.Windows;
using System.Windows.Controls;

namespace school_management_wpf_project.Views {
	public partial class TeacherView : UserControl {
		public TeacherView() {
			InitializeComponent();
		}

		private void OpenAbsence(object sender, RoutedEventArgs e) {
			TeacherAddAbsences teacherAddAbsences = new TeacherAddAbsences();
			teacherAddAbsences.DataContext = this.DataContext;
			teacherAddAbsences.Show();
		}

		private void OpenGrade(object sender, RoutedEventArgs e) {
			TeacherAddGrades teacherAddGrades = new TeacherAddGrades();
			teacherAddGrades.DataContext = this.DataContext;
			teacherAddGrades.Show();
		}

		private void OpenMaterial(object sender, RoutedEventArgs e) {
			TeacherAddMaterial teacherAddMaterial = new TeacherAddMaterial();
			teacherAddMaterial.DataContext = this.DataContext;
			teacherAddMaterial.Show();
		}

		private void OpenAverage(object sender, RoutedEventArgs e) {
			TeacherAddAverages teacherAddAverages = new TeacherAddAverages();
			teacherAddAverages.DataContext = this.DataContext;
			teacherAddAverages.Show();
		}
	}
}
