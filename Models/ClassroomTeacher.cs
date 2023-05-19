using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace school_management_wpf_project.Models {
	public class ClassroomTeacher {
		[Key]
		public int Id {
			get; set;
		}
		public string FirstName {
			get; set;
		}
		public string LastName {
			get; set;
		}

		public virtual ObservableCollection<Subject> Subjects {
			get; set;
		}
		public virtual ObservableCollection<Classroom> Classrooms {
			get; set;
		}

		public ClassroomTeacher(string firstName, string lastName) {
			FirstName = firstName;
			LastName = lastName;
			Subjects = new ObservableCollection<Subject>();
			Classrooms = new ObservableCollection<Classroom>();
		}

		public ClassroomTeacher() {
			FirstName = "";
			LastName = "";
			Subjects = new ObservableCollection<Subject>();
			Classrooms = new ObservableCollection<Classroom>();
		}
	}
}
