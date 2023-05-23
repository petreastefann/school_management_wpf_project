using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using school_management_wpf_project.BusinessLogicLayer;
using school_management_wpf_project.Models;
using school_management_wpf_project.Services;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace school_management_wpf_project.ViewModels {
	public class TeacherViewModel : ObservableObject {
		private User _user;
		private Course _course;
		private StudentCourse _studentCourse;
		private User _student;

		public TeacherViewModel() {
			User = UserService.GetLoggedInUser();
			Course = new Course();
			AvailableCourses = new ObservableCollection<Course>(CourseBLL.GetAllByTeacher(User));
			AvailableStudentsForCourse = new ObservableCollection<User>(StudentBLL.GetAll());
			StudentCourse = new StudentCourse();

			// initialize commands
			UpdateAbsencesCommand = new RelayCommand(UpdateAbsences);
		}

		////////////////////////////////////////////	gets and sets

		public User User {
			get => _user;
			set {
				SetProperty(ref _user, value);
				OnPropertyChanged(nameof(User));
			}
		}

		public User Student {
			get => _student;
			set {
				SetProperty(ref _student, value);
				OnPropertyChanged(nameof(Student));
				if(Student != null && Course != null) {
					StudentCourse = StudentCourseBLL.GetByStudentAndCourse(Student, Course);
				}
			}
		}

		public Course Course {
			get => _course;
			set {
				SetProperty(ref _course, value);
				OnPropertyChanged(nameof(Course));
			}
		}

		public StudentCourse StudentCourse {
			get => _studentCourse;
			set {
				SetProperty(ref _studentCourse, value);
				OnPropertyChanged(nameof(StudentCourse));
			}
		}

		public ObservableCollection<Course> AvailableCourses {
			get; set;
		}

		public ObservableCollection<User> AvailableStudentsForCourse {
			get; set;
		}

		////////////////////////////////////////////	ICommands

		public ICommand UpdateAbsencesCommand {
			get;
		}

		////////////////////////////////////////////	Methods

		public void UpdateAbsences() {
			StudentCourse.Student = Student;
			StudentCourse.Course = Course;

			StudentCourseBLL.Update(StudentCourse);

			MessageBox.Show("the absences have been succesfully updated");
		}

		public void AddNewGrade() {

		}
	}
}
