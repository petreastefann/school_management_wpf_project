using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace school_management_wpf_project.ViewModels {
	public class LoginOrRegisterViewModel {
		public string Username {
			get; set;
		}
		public string Password {
			get; set;
		}
		public ObservableCollection<string> UserTypes { get; } = new ObservableCollection<string> { "admin", "classroom teacher", "homeroom teacher", "student" };
		public string UserType {
			get; set;
		}
		public IRelayCommand LoginCommand {
			get;
		}

		public LoginOrRegisterViewModel() {
			LoginCommand = new RelayCommand(Login, CanLogin);
		}

		private void Login() {
			// check if the user exists in the database (+password)
			//// if yes then take the user type 
		}

		private bool CanLogin() {
			return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password) && !string.IsNullOrEmpty(UserType);
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
