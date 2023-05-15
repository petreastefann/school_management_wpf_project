using CommunityToolkit.Mvvm.Input;
using school_management_wpf_project.Data;
using school_management_wpf_project.Services;
using school_management_wpf_project.Views;
using System.ComponentModel;
using System.Windows;

namespace school_management_wpf_project.ViewModels {
	class LoginViewModel : INotifyPropertyChanged {
		private string _username;
		private string _password;

		public LoginViewModel() {
			_username = "";
			_password = "";
			LoginCommand = new RelayCommand(Login, CanLogin);
		}

		public string Username {
			get => _username;
			set {
				_username = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Username)));
				LoginCommand.NotifyCanExecuteChanged();
			}
		}

		public string Password {
			get => _password;
			set {
				_password = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Password)));
				LoginCommand.NotifyCanExecuteChanged();
			}
		}

		public event PropertyChangedEventHandler? PropertyChanged;

		public IRelayCommand LoginCommand {
			get;
		}

		public bool CanLogin() {
			return _username != "" && _password != "";
		}

		public void Login() {
			var userService = new UserService(new SchoolDbContext());

			bool isValidUser = userService.CheckIfUserExists(_username, _password);
			if(isValidUser) {
				MessageBox.Show("login successful");
				var mainViewModel = (MainViewModel)Application.Current.MainWindow.DataContext;

				mainViewModel.User = userService.GetUserByUsername(_username);

				MainMenuViewModel mainMenuViewModel = new MainMenuViewModel(mainViewModel.User);
				mainViewModel.CurrentView = new MainMenuView { DataContext = mainMenuViewModel };
			}
			else {
				MessageBox.Show("the user doesnt exist");
			}
		}
	}
}
