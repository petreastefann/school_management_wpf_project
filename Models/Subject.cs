using System.Collections.ObjectModel;

namespace school_management_wpf_project.Models {
	public class Subject {
		public int Id {
			get; set;
		}
		public string Name {
			get; set;
		}
		public ObservableCollection<Teacher> Teachers {
			get; set;
		}
		public Subject(int id, string name, ObservableCollection<Teacher> teachers) {
			Id = id;
			Name = name;
			Teachers = teachers;
		}

		public Subject() {
			Id = 0;
			Name = "";
			Teachers = new ObservableCollection<Teacher>();
		}
	}
}
