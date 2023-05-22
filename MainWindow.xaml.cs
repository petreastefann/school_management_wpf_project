using school_management_wpf_project.Views;
using System.Windows;

namespace school_management_wpf_project {
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		private void LoginClick(object sender, RoutedEventArgs e) {
			LoginView loginView = new LoginView();

			loginView.Show();
			Close();
		}

		/*private void RegisterClick(object sender, RoutedEventArgs e) {
			RegisterView registerView = new RegisterView();
			registerView.Show();
		}*/
	}

}
