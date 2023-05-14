using school_management_wpf_project.Models;
using school_management_wpf_project.Views;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace school_management_wpf_project.ViewModels {
	public class MainViewModel : INotifyPropertyChanged {
		private User _user;
		private UserControl _currentView;

		public MainViewModel() {
			CurrentView = new LoginView();
			User = new User();
		}

		public User User {
			get => _user;
			set {
				_user = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(User)));
			}
		}
		public UserControl CurrentView {
			get => _currentView;
			set {
				_currentView = value;
				OnPropertyChanged();
			}
		}

		///

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string propertyName = null) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}

}
