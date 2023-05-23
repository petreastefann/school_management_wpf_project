using CommunityToolkit.Mvvm.ComponentModel;
using school_management_wpf_project.BusinessLogicLayer;
using school_management_wpf_project.Models;
using school_management_wpf_project.Services;
using System.Collections.ObjectModel;

namespace school_management_wpf_project.ViewModels {
	public class StudentViewModel : ObservableObject {
		private User _user;
		private StudentCourse _studentCourse;

		public StudentViewModel() {
			User = UserService.GetLoggedInUser();
			StudentCourse = new StudentCourse();
			AvailableStudentCourses = new ObservableCollection<StudentCourse>(StudentCourseBLL.GetAllByStudent(User));

			// initialize commands
		}

		////////////////////////////////////////////	gets and sets

		public User User {
			get => _user;
			set {
				_user = value;
				OnPropertyChanged(nameof(User));
			}
		}

		public StudentCourse StudentCourse {
			get => _studentCourse;
			set {
				_studentCourse = value;
				OnPropertyChanged(nameof(StudentCourse));
			}
		}

		public ObservableCollection<StudentCourse> AvailableStudentCourses {
			get; set;
		}

		////////////////////////////////////////////	ICommands



		////////////////////////////////////////////	Methods


	}
}
