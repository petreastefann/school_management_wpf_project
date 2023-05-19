using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace school_management_wpf_project.Models {
	public class HomeroomTeacher : Teacher {
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
		public int ClassroomId {
			get; set;
		}
		public virtual ObservableCollection<Subject> Subjects {
			get; set;
		}
		public virtual ObservableCollection<Classroom> Classrooms {
			get; set;
		}

		public HomeroomTeacher(string firstName, string lastName, int classroomId, ObservableCollection<Subject> subjects, ObservableCollection<Classroom> classrooms) {
			FirstName = firstName;
			LastName = lastName;
			ClassroomId = classroomId;
			Subjects = subjects;
			Classrooms = classrooms;
		}
		public HomeroomTeacher() {
			FirstName = "";
			LastName = "";
			ClassroomId = 0;
			Subjects = new ObservableCollection<Subject>();
			Classrooms = new ObservableCollection<Classroom>();
		}
	}
}
