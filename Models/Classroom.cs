using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace school_management_wpf_project.Models {
	public class Classroom {
		[Key]
		public int Id {
			get; set;
		}
		public string Name {
			get; set;
		}
		public virtual ObservableCollection<Student> Students {
			get; set;
		}
		public virtual ObservableCollection<Teacher> Teachers {
			get; set;
		}
		public virtual Specialization Specialization {
			get; set;
		}

		public Classroom(string name, ObservableCollection<Student> students, ObservableCollection<Teacher> teachers, Specialization specialization) {
			Name = name;
			Students = students;
			Teachers = teachers;
			Specialization = specialization;
		}

		public Classroom() {
			Name = "";
			Students = new ObservableCollection<Student>();
			Teachers = new ObservableCollection<Teacher>();
			Specialization = new Specialization();
		}
	}
}
