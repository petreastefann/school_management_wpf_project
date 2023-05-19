using System.Collections.Generic;
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
		public List<Classroom> Classrooms {
			get; set;
		}
	}
}
