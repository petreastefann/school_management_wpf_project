using System.Collections.Generic;

namespace school_management_wpf_project.Models {
	public class StudentCourse {
		public int Id {
			get; set;
		}

		public User Student {
			get; set;
		}

		public Course Course {
			get; set;
		}

		public int Absences {
			get; set;
		}

		public List<Grade> Grades {
			get; set;
		}
	}
}
