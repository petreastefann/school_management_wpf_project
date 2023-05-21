using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using school_management_wpf_project.BusinessLogicLayer;
using school_management_wpf_project.Models;
using school_management_wpf_project.Services;
using System.Windows;
using System.Windows.Input;

namespace school_management_wpf_project.ViewModels {
	public class AdminViewModel : ObservableObject {
		private User _user;
		private StudyYear _studyYear;
		private Specialization _specialization;

		public AdminViewModel() {
			// initialize members
			User = UserService.GetLoggedInUser();
			StudyYear = new StudyYear();
			Specialization = new Specialization();

			// initialize commands
			AddStudyYearCommand = new RelayCommand(AddStudyYear);
			AddSpecializationCommand = new RelayCommand(AddSpecialization);

		}

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

		////////////////////////////////////////////	ICommands

		public ICommand AddStudyYearCommand {
			get;
		}

		public ICommand AddSpecializationCommand {
			get;
		}

		////////////////////////////////////////////	Methods

		private void AddStudyYear() {
			StudyYearBLL.Add(StudyYear);
			MessageBox.Show("Study year added successfully");
		}

		private void AddSpecialization() {
			SpecializationBLL.Add(Specialization);
			MessageBox.Show("Specialization added successfully");
		}
	}
}
