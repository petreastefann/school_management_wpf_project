using school_management_wpf_project.DataAccessLayer;
using school_management_wpf_project.Models;
using System.Collections.Generic;

namespace school_management_wpf_project.BusinessLogicLayer {
	public class StudyYearSpecializationBLL {
		public static void Add(StudyYearSpecialization studyYearSpecialization) {
			StudyYearSpecializationDAL.Add(studyYearSpecialization);
		}
		public static List<StudyYearSpecialization> GetAll() {
			return StudyYearSpecializationDAL.GetAll();
		}
	}
}
