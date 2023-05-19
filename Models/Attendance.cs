using System.ComponentModel.DataAnnotations;

namespace school_management_wpf_project.Models {
	public class Attendance {
		[Key]
		public int Id {
			get; set;
		}
		public int StudentId {
			get; set;
		}
		public int SubjectId {
			get; set;
		}
		public int Semester {
			get; set;
		}
		public bool Status {
			get; set;
		}

		public Attendance(int studentId, int subjectId, int semester, bool status) {
			StudentId = studentId;
			SubjectId = subjectId;
			Semester = semester;
			Status = status;
		}
		public Attendance() {
			StudentId = 0;
			SubjectId = 0;
			Semester = 0;
			Status = false;
		}
	}
}
