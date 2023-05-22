using System.ComponentModel.DataAnnotations;

namespace school_management_wpf_project.Models {
	public class Classroom {
		[Key]
		public int Id {
			get; set;
		}
		public string Name {
			get; set;
		}
		public Specialization Specialization {
			get; set;
		}
		public HomeroomTeacher HomeroomTeacher {
			get; set;
		}
	}
}
