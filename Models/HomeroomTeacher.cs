using System.Collections.ObjectModel;

namespace school_management_wpf_project.Models {
	public class HomeroomTeacher : Teacher {
		public int ClassId {
			get; set;
		}

		public HomeroomTeacher(int id, string firstName, string lastName, ObservableCollection<Subject> subjects, ObservableCollection<Class> classes, int classId)
			: base(id, firstName, lastName, subjects, classes) {
			ClassId = classId;
		}
	}
}
