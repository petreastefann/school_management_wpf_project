using System.Collections.ObjectModel;

namespace school_management_wpf_project.Models {
	public class Year {
		public int Id {
			get; set;
		}
		public ObservableCollection<Specialization> Specializations {
			get; set;
		}

		public Year(int id, ObservableCollection<Specialization> specializations) {
			Id = id;
			Specializations = specializations;
		}
	}
}
