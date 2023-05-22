using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using school_management_wpf_project.BusinessLogicLayer;
using school_management_wpf_project.Models;
using school_management_wpf_project.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace school_management_wpf_project.ViewModels {
	public class AdminViewModel : ObservableObject {
		private User _user;
		private StudyYear _studyYear;
		private Specialization _specialization;
		private Course _course;
		private HomeroomTeacher _homeroomTeacher;
		private StudyYearSpecialization _studyYearSpecialization;
		private Classroom _classroom;

		public AdminViewModel() {
			// initialize members
			User = UserService.GetLoggedInUser();
			StudyYear = new StudyYear();
			Specialization = new Specialization();
			Course = new Course();
			Classroom = new Classroom();
			RoleChoices = new List<string> { "student", "teacher", "admin" };
			AvailableTeachers = new ObservableCollection<User>(TeacherBLL.GetAll());
			AvailableSpecializations = new ObservableCollection<Specialization>(SpecializationBLL.GetAll());
			AvailableStudyYears = new ObservableCollection<StudyYear>(StudyYearBLL.GetAll());
			AvailableStudyYearSpecializations = new ObservableCollection<StudyYearSpecialization>(StudyYearSpecializationBLL.GetAll());
			AvailableCourses = new ObservableCollection<Course>(CourseBLL.GetAll());
			AvailableClassrooms = new ObservableCollection<Classroom>(ClassroomBLL.GetAll());
			AvailableStudents = new ObservableCollection<User>(StudentBLL.GetAll());

			// initialize commands
			AddStudyYearCommand = new RelayCommand(AddStudyYear);
			AddSpecializationCommand = new RelayCommand(AddSpecialization);
			AddCourseCommand = new RelayCommand(AddCourse);
			AddClassCommand = new RelayCommand(AddClass);
			AddUserCommand = new RelayCommand(AddUser);
			LinkStudyYearToSpecializationCommand = new RelayCommand(LinkStudyYearToSpecialization);
			LinkCourseToStudyYearSpecializationCommand = new RelayCommand(LinkCourseToStudyYearSpecialization);
			LinkStudentToClassroomCommand = new RelayCommand(LinkStudentToClassroom);
		}

		////////////////////////////////////////////	gets and sets

		public User User {
			get => _user;
			set {
				SetProperty(ref _user, value);
				OnPropertyChanged(nameof(User));
			}
		}

		public StudyYear StudyYear {
			get => _studyYear;
			set {
				SetProperty(ref _studyYear, value);
				OnPropertyChanged(nameof(StudyYear));
			}
		}

		public Specialization Specialization {
			get => _specialization;
			set {
				SetProperty(ref _specialization, value);
				OnPropertyChanged(nameof(Specialization));
			}
		}

		public Course Course {
			get => _course;
			set {
				SetProperty(ref _course, value);
				OnPropertyChanged(nameof(Course));
			}
		}

		public HomeroomTeacher HomeroomTeacher {
			get => _homeroomTeacher;
			set {
				SetProperty(ref _homeroomTeacher, value);
				OnPropertyChanged(nameof(HomeroomTeacher));
			}
		}

		public StudyYearSpecialization StudyYearSpecialization {
			get => _studyYearSpecialization;
			set {
				SetProperty(ref _studyYearSpecialization, value);
				OnPropertyChanged(nameof(StudyYearSpecialization));
			}
		}

		public Classroom Classroom {
			get => _classroom;
			set {
				SetProperty(ref _classroom, value);
				OnPropertyChanged(nameof(Classroom));
			}
		}

		public List<string> RoleChoices {
			get; set;
		}

		public ObservableCollection<User> AvailableTeachers {
			get; set;
		}

		public ObservableCollection<Specialization> AvailableSpecializations {
			get; set;
		}

		public ObservableCollection<StudyYear> AvailableStudyYears {
			get; set;
		}

		public ObservableCollection<StudyYearSpecialization> AvailableStudyYearSpecializations {
			get; set;
		}

		public ObservableCollection<Course> AvailableCourses {
			get; set;
		}

		public ObservableCollection<Classroom> AvailableClassrooms {
			get; set;
		}

		public ObservableCollection<User> AvailableStudents {
			get; set;
		}

		////////////////////////////////////////////	ICommands

		public ICommand AddStudyYearCommand {
			get;
		}

		public ICommand AddSpecializationCommand {
			get;
		}

		public ICommand AddCourseCommand {
			get;
		}

		public ICommand AddClassCommand {
			get;
		}

		public ICommand LinkStudyYearToSpecializationCommand {
			get;
		}

		public ICommand AddUserCommand {
			get;
		}

		public ICommand LinkCourseToStudyYearSpecializationCommand {
			get;
		}

		public ICommand LinkStudentToClassroomCommand {
			get;
		}

		////////////////////////////////////////////	Methods

		private void AddStudyYear() {
			StudyYearBLL.Add(StudyYear);
			MessageBox.Show("study year added successfully");
		}

		private void AddSpecialization() {
			SpecializationBLL.Add(Specialization);
			MessageBox.Show("specialization added successfully");
		}

		private void AddCourse() {
			CourseBLL.Add(Course);
			MessageBox.Show("course added successfully");
		}

		private void AddClass() {
			ClassroomBLL.Add(Classroom);
			MessageBox.Show("classroom added succesfully");
		}

		private void LinkStudyYearToSpecialization() {
			StudyYearSpecialization s = new() {
				StudyYear = StudyYear,
				Specialization = Specialization
			};
			StudyYearSpecializationBLL.Add(s);
			MessageBox.Show("succesfully linked the study year to the specialization");
		}

		private void LinkCourseToStudyYearSpecialization() {
			CourseStudyYearSpecialization css = new() {
				StudyYearSpecialization = StudyYearSpecialization,
				Course = Course
			};
			CourseStudyYearSpecializationBLL.Add(css);
			MessageBox.Show("successfully linked course with the study year and specialization");
		}

		private void AddUser() {
			UserBLL.Add(User);
			MessageBox.Show("user added successfully");
		}

		private void LinkStudentToClassroom() {
			StudentClassroom sc = new() {
				Classroom = Classroom,
				Student = User
			};
			StudentClassroomBLL.Add(sc);
			MessageBox.Show("successfully linked student to classroom");
		}
	}
}
