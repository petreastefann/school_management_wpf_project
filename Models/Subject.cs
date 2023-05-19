using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace school_management_wpf_project.Models {
	public class Subject {
		[Key]
		public int Id {
			get; set;
		}
		public string Name {
			get; set;
		}
		public virtual ObservableCollection<Teacher> Teachers {
			get; set;
		}

		public Subject(string name, ObservableCollection<Teacher> teachers) {
			Name = name;
			Teachers = teachers;
		}

		public Subject() {
			Name = "";
			Teachers = new ObservableCollection<Teacher>();
		}
	}
}
