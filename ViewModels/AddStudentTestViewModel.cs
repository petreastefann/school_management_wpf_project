using CommunityToolkit.Mvvm.Input;
using school_management_wpf_project.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace school_management_wpf_project.ViewModels {
	public class AddStudentTestViewModel : INotifyPropertyChanged {
		private int _id;
		private string _firstName;
		private string _lastName;
		private Classroom _classroom;
		private Specialization _specialization;
		private ObservableCollection<Student> _students;

		public AddStudentTestViewModel() {
			AddStudentCommand = new RelayCommand(AddStudent, CanAddPerson);
			_students = new ObservableCollection<Student>();
		}


		public int Id {
			get => _id;
			set {
				_id = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
				AddStudentCommand.NotifyCanExecuteChanged();
			}
		}

		public string FirstName {
			get => _firstName;
			set {
				_firstName = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstName)));
				AddStudentCommand.NotifyCanExecuteChanged();
			}
		}

		public string LastName {
			get => _lastName;
			set {
				_lastName = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastName)));
				AddStudentCommand.NotifyCanExecuteChanged();
			}
		}

		public Classroom Classroom {
			get => _classroom;
			set {
				_classroom = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Classroom)));
				AddStudentCommand.NotifyCanExecuteChanged();
			}
		}

		public Specialization Specialization {
			get => _specialization;
			set {
				_specialization = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Specialization)));
				AddStudentCommand.NotifyCanExecuteChanged();
			}
		}

		public ObservableCollection<Student> Students {
			get => _students;
			set {
				_students = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Students)));
			}
		}

		/// 

		public IRelayCommand AddStudentCommand {
			get;
		}

		private void AddStudent() {
			_students.Add(new Student(_id, _firstName, _lastName, _classroom, _specialization));
		}

		private bool CanAddPerson() {
			return !string.IsNullOrEmpty(_firstName) && !string.IsNullOrEmpty(_lastName);
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName) {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
