using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace school_management_wpf_project.Models {
	public class Subject {
		[Key]
		public int Id {
			get; set;
		}
		public string Name {
			get; set;
		}
		public List<HomeroomTeacher> HomeroomTeachers {
			get; set;
		}
	}
}
