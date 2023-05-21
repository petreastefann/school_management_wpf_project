using school_management_wpf_project.Data;
using school_management_wpf_project.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace school_management_wpf_project.ViewModels {
	public class TeacherViewModel {
		private User _user;

		public TeacherViewModel(User user, SchoolDbContext schoolDbContext) {
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

		protected void OnPropertyChanged([CallerMemberName] string propertyName = null) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
