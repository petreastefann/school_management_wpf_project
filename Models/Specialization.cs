using System.Collections.ObjectModel;
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
		public virtual ObservableCollection<Classroom> Classrooms {
			get; set;
		}

		public Specialization(string name, ObservableCollection<Classroom> classrooms) {
			Name = name;
			Classrooms = classrooms;
		}
		public Specialization() {
			Name = "";
			Classrooms = new ObservableCollection<Classroom>();
		}
	}
}
