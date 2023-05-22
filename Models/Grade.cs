using System.ComponentModel.DataAnnotations;

namespace school_management_wpf_project.Models {
	public class Grade {
		[Key]
		public int Id {
			get; set;
		}
		public User Student {
			get; set;
		}
		public Subject Subject {
			get; set;
		}
		public int Value {
			get; set;
		}
		public int Semester {
			get; set;
		}
	}
}
