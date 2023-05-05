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
		public ObservableCollection<Class> Classes {
			get; set;
		}
		public Teacher(int id, string firstName, string lastName, ObservableCollection<Subject> subjects, ObservableCollection<Class> classes) {
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Subjects = subjects;
			Classes = classes;
		}
	}
}
