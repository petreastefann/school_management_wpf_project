using school_management_wpf_project.DataAccessLayer;
using school_management_wpf_project.Models;
using System.Collections.Generic;

namespace school_management_wpf_project.BusinessLogicLayer {
	class TeacherBLL {
		public static List<User> GetAll() {
			return TeacherDAL.GetAll();
		}
	}
}
