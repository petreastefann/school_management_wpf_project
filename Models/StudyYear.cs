using System.Collections.ObjectModel;
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
		public virtual ObservableCollection<Specialization> Specializations {
			get; set;
		}

		public StudyYear(ObservableCollection<Specialization> specializations, int year) {
			Specializations = specializations;
			Year = year;
		}

		public StudyYear() {
			Specializations = new ObservableCollection<Specialization>();
			Year = 0;
		}
	}
}
