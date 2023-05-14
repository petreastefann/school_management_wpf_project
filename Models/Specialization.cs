using System.Collections.ObjectModel;

namespace school_management_wpf_project.Models {
	public class Specialization {
		public int Id {
			get; set;
		}
		public string Name {
			get; set;
		}
		public ObservableCollection<Classroom> Classrooms {
			get; set;
		}
		public Specialization(int id, string name, ObservableCollection<Classroom> classrooms) {
			Id = id;
			Name = name;
			Classrooms = classrooms;
		}
		public Specialization() {
			Id = 0;
			Name = "";
			Classrooms = new ObservableCollection<Classroom>();
		}
	}
}
