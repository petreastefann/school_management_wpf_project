using System.ComponentModel.DataAnnotations;

namespace school_management_wpf_project.Models {
	public class Specialization {
		[Key]
		public int Id {
			get; set;
		}
		public string Name {
			get; set;
		}
	}
}
