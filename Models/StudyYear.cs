using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace school_management_wpf_project.Models {
	public class StudyYear {
		[Key]
		public int Id {
			get; set;
		}
		public int Year {
			get; set;
		}
		public List<Specialization> Specializations {
			get; set;
		}
	}
}
