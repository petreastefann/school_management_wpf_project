using school_management_wpf_project.DataAccessLayer;
using school_management_wpf_project.Models;

namespace school_management_wpf_project.BusinessLogicLayer {
	public class UserBLL {
		public static void Add(User user) {
			UserDAL.Add(user);
		}
	}
}
