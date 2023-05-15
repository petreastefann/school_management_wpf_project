using school_management_wpf_project.Models;
using System.ComponentModel;

namespace school_management_wpf_project.ViewModels {
	public class MainMenuViewModel : INotifyPropertyChanged {
		private User _user;

		public MainMenuViewModel(User user) {
			_user = user;
		}

		public User User {
			get => _user;
			set {
				_user = value;
				OnPropertyChanged(nameof(User));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
