namespace school_management_wpf_project.Models {
	public class Grade {
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
		public int Value {
			get; set;
		}
		public Grade(int id, int studentId, int subjectId, int semester, int value) {
			Id = id;
			StudentId = studentId;
			SubjectId = subjectId;
			Semester = semester;
			Value = value;
		}
	}
}
