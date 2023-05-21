using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using school_management_wpf_project.Models;
using school_management_wpf_project.Services;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace school_management_wpf_project.ViewModels {
	class LoginViewModel : ObservableObject {
		private string _username;
		private string _password;

		public LoginViewModel() {
			_username = "";
			_password = "";
			LoginCommand = new RelayCommand(Login);
		}

		public string Username {
			get => _username;
			set {
				SetProperty(ref _username, value);
				OnPropertyChanged(nameof(Username));
			}
		}

		public string Password {
			get => _password;
			set {
				SetProperty(ref _password, value);
				OnPropertyChanged(nameof(Password));
			}
		}

		public event PropertyChangedEventHandler? PropertyChanged;

		public ICommand LoginCommand {
			get;
		}

		public User LoggedInUser {
			get; set;
		}

		public string GetLoggedInUserRole() {
			return LoggedInUser.Role;
		}

		public bool IsLoggedIn() {
			return LoggedInUser != null;
		}

		public void Login() {
			var loggedInUser = UserService.Login(_username, _password);
			if(loggedInUser != null) {
				LoggedInUser = loggedInUser;
				MessageBox.Show("login successful");
			}
			else {
				MessageBox.Show("the user doesnt exist");
			}
		}
	}
}
