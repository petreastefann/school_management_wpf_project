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

		private void AbsencesClick(object sender, RoutedEventArgs e) {
			TeacherAddAbsences teacherAddAbsences = new() {
				DataContext = this.DataContext
			};

			teacherAddAbsences.Show();
		}

		private void GradesClick(object sender, RoutedEventArgs e) {
			TeacherAddGrades teacherAddGrades = new() {
				DataContext = this.DataContext
			};

			teacherAddGrades.Show();
		}

		private void AveragesClick(object sender, RoutedEventArgs e) {
			TeacherAddAverages teacherAddAverages = new() {
				DataContext = this.DataContext
			};

			teacherAddAverages.Show();
		}

		private void MaterialClick(object sender, RoutedEventArgs e) {
			TeacherAddMaterial teacherAddMaterial = new() {
				DataContext = this.DataContext
			};

			teacherAddMaterial.Show();
		}
	}
}
