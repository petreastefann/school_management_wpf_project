using school_management_wpf_project.DataAccessLayer;
using school_management_wpf_project.Models;
using System.Collections.Generic;

namespace school_management_wpf_project.BusinessLogicLayer {
	public class ClassroomBLL {
		public static void Add(Classroom classroomToAdd) {
			ClassroomDAL.Add(classroomToAdd);
		}
		public static List<Classroom> GetAll() {
			return ClassroomDAL.GetAll();
		}
	}
}
