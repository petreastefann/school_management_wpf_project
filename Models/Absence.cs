using System.ComponentModel.DataAnnotations;

namespace school_management_wpf_project.Models {
	public class Absence {
		[Key]
		public int Id {
			get; set;
		}

		public User Student {
			get; set;
		}

		public Course Course {
			get; set;
		}

		public bool IsMotivated {
			get; set;
		}

	}
}
