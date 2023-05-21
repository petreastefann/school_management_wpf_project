using school_management_wpf_project.Models;
using school_management_wpf_project.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace school_management_wpf_project.ViewModels {
	public class AdminViewModel {
		private User _user;
		private StudyYear _studyYear;

		public AdminViewModel() {
			_user = UserService.GetLoggedInUser();
		}

		public User User {
			get => _user;
			set {
				_user = value;
				OnPropertyChanged(nameof(User));
			}
		}

		public StudyYear StudyYear {
			get => _studyYear;
			set {
				_studyYear = value;
				OnPropertyChanged(nameof(StudyYear));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string propertyName = null) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
