using System.Collections.ObjectModel;

namespace school_management_wpf_project.Models {
	public class ClassroomTeacher : Teacher {
		public ClassroomTeacher(int id, string firstName, string lastName, ObservableCollection<Subject> subjects, ObservableCollection<Classroom> classrooms)
			: base(id, firstName, lastName, subjects, classrooms) {
		}
	}
}
