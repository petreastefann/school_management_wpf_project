using school_management_wpf_project.ViewModels;
using System.Windows;

namespace school_management_wpf_project.Views {
	public partial class LoginView : Window {
		public LoginView() {
			InitializeComponent();
		}

		private void LoginClick(object sender, RoutedEventArgs e) {
			var loginViewModel = DataContext as LoginViewModel;

			string loggedInUserRole;

			if(loginViewModel != null) {
				loginViewModel.LoginCommand.Execute(null);

				if(loginViewModel.IsLoggedIn()) {
					loggedInUserRole = loginViewModel.GetLoggedInUserRole();

					if(loggedInUserRole == "admin") {
						AdminView adminView = new AdminView();
						adminView.Show();
					}
					else if(loggedInUserRole == "teacher") {
						TeacherView teacherView = new TeacherView();
						teacherView.Show();
					}
					else if(loggedInUserRole == "student") {
						StudentView studentView = new StudentView();
						studentView.Show();
					}

					Close();
				}
			}
		}
	}
}
