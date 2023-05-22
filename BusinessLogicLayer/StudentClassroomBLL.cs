using school_management_wpf_project.DataAccessLayer;
using school_management_wpf_project.Models;

namespace school_management_wpf_project.BusinessLogicLayer {
	public static class StudentClassroomBLL {
		public static void Add(StudentClassroom studentClassroom) {
			StudentClassroomDAL.Add(studentClassroom);
		}
	}
}
