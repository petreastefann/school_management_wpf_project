namespace school_management_wpf_project.Models {
	public class Attendance {
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
		public Attendance(int id, int studentId, int subjectId, int semester, bool status) {
			Id = id;
			StudentId = studentId;
			SubjectId = subjectId;
			Semester = semester;
			Status = status;
		}
	}
}
