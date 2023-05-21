using System.ComponentModel.DataAnnotations;

namespace school_management_wpf_project.Models {
	public class LoggedInUser {
		[Key]
		public int Id {
			get; set;
		}

		public int UserId {
			get; set;
		}
	}
}
