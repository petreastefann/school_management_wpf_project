using school_management_wpf_project.Views;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace school_management_wpf_project.ViewModels {
	public class MainViewModel : INotifyPropertyChanged {
		private UserControl _currentView;
		public UserControl CurrentView {
			get => _currentView;
			set {
				_currentView = value;
				OnPropertyChanged();
			}
		}

		public MainViewModel() {
			CurrentView = new LoginView();
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string propertyName = null) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}

}
