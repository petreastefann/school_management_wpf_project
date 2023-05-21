using school_management_wpf_project.Views.AdminMiniViews;
using System.Windows;

namespace school_management_wpf_project.Views {
	public partial class AdminView : Window {
		public AdminView() {
			InitializeComponent();
		}

		private void OpenClass(object sender, RoutedEventArgs e) {
			AdminAddClass adminAddClass = new AdminAddClass();
			adminAddClass.DataContext = this.DataContext;

			adminAddClass.Show();
		}

		private void OpenUser(object sender, RoutedEventArgs e) {
			AdminAddUsers adminAddUsers = new AdminAddUsers();
			adminAddUsers.DataContext = this.DataContext;

			adminAddUsers.Show();
		}

		private void OpenStudyYear(object sender, RoutedEventArgs e) {
			AdminAddStudyYear adminAddStudyYear = new AdminAddStudyYear();
			adminAddStudyYear.DataContext = this.DataContext;

			adminAddStudyYear.Show();
		}

		private void OpenCourse(object sender, RoutedEventArgs e) {
			AdminAddCourse adminAddCourse = new AdminAddCourse();
			adminAddCourse.DataContext = this.DataContext;

			adminAddCourse.Show();
		}

		private void OpenSpecialization(object sender, RoutedEventArgs e) {
			AdminAddSpecialization adminAddSpecialization = new AdminAddSpecialization();
			adminAddSpecialization.DataContext = this.DataContext;

			adminAddSpecialization.Show();
		}

		private void OpenStudyYearToSpecialization(object sender, RoutedEventArgs e) {
			AdminLinkStudyYearToSpecialization adminLinkStudyYearToSpecialization = new AdminLinkStudyYearToSpecialization();
			adminLinkStudyYearToSpecialization.DataContext = this.DataContext;

			adminLinkStudyYearToSpecialization.Show();
		}

		private void OpenClassToStudyYear(object sender, RoutedEventArgs e) {
			AdminLinkClassToStudyYear adminLinkClassToStudyYear = new AdminLinkClassToStudyYear();
			adminLinkClassToStudyYear.DataContext = this.DataContext;

			adminLinkClassToStudyYear.Show();
		}

		private void OpenLinkStudentToClass(object sender, RoutedEventArgs e) {
			AdminLinkStudentToClassroom adminLinkStudentToClassroom = new AdminLinkStudentToClassroom();
			adminLinkStudentToClassroom.DataContext = this.DataContext;

			adminLinkStudentToClassroom.Show();
		}

	}
}
