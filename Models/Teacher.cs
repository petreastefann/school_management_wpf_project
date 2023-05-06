using System.Collections.ObjectModel;

namespace school_management_wpf_project.Models {
	public class Teacher {
		public int Id {
			get; set;
		}
		public string FirstName {
			get; set;
		}
		public string LastName {
			get; set;
		}
		public ObservableCollection<Subject> Subjects {
			get; set;
		}
		public ObservableCollection<Classroom> Classrooms {
			get; set;
		}
		public Teacher(int id, string firstName, string lastName, ObservableCollection<Subject> subjects, ObservableCollection<Classroom> classrooms) {
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Subjects = subjects;
			Classrooms = classrooms;
		}
	}
}
