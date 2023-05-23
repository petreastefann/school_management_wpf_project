using System.ComponentModel.DataAnnotations;

namespace school_management_wpf_project.Models {
	public class Grade {
		[Key]
		public int Id {
			get; set;
		}
		public int Value {
			get; set;
		}
	}
}
