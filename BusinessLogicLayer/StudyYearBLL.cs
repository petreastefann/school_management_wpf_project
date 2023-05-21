using school_management_wpf_project.DataAccessLayer;
using school_management_wpf_project.Models;
using System.Collections.Generic;

namespace school_management_wpf_project.BusinessLogicLayer {
	class StudyYearBLL {
		public static void Add(StudyYear studyYear) {
			StudyYearDAL.Add(studyYear);
		}

		public static List<StudyYear> GetAll() {
			return StudyYearDAL.GetAll();
		}
	}
}
