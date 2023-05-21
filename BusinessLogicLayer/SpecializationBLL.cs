using school_management_wpf_project.DataAccessLayer;
using school_management_wpf_project.Models;
using System.Collections.Generic;

namespace school_management_wpf_project.BusinessLogicLayer {
	class SpecializationBLL {
		public static void Add(Specialization specialization) {
			SpecializationDAL.Add(specialization);
		}
		public static List<Specialization> GetAll() {
			return SpecializationDAL.GetAll();
		}
	}
}
