using System.Collections.Generic;
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

		public List<Subject> Subjects {
			get; set;
		}
		public List<Classroom> Classrooms {
			get; set;
		}
	}
}
