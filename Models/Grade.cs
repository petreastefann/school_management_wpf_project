using System.ComponentModel.DataAnnotations;

namespace school_management_wpf_project.Models {
	public class Grade {
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
		public int Value {
			get; set;
		}
		public int Semester {
			get; set;
		}

		public Grade(int studentId, int subjectId, int value, int semester) {
			StudentId = studentId;
			SubjectId = subjectId;
			Value = value;
			Semester = semester;
		}
		public Grade() {
			StudentId = 0;
			SubjectId = 0;
			Value = 0;
			Semester = 0;
		}
	}
}
