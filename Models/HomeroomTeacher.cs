using System.Collections.ObjectModel;

namespace school_management_wpf_project.Models {
	public class HomeroomTeacher : Teacher {
		public int ClassId {
			get; set;
		}

		public HomeroomTeacher(int id, string firstName, string lastName, ObservableCollection<Subject> subjects, ObservableCollection<Classroom> classrooms, int classId)
			: base(id, firstName, lastName, subjects, classrooms) {
			ClassId = classId;
		}
	}
}
