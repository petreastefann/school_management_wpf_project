using System.Collections.ObjectModel;

namespace school_management_wpf_project.Models {
	public class Specialization {
		public int Id {
			get; set;
		}
		public string Name {
			get; set;
		}
		public ObservableCollection<Class> Classes {
			get; set;
		}
		public Specialization(int id, string name, ObservableCollection<Class> classes) {
			Id = id;
			Name = name;
			Classes = classes;
		}
	}
}
