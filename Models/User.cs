﻿using System.ComponentModel.DataAnnotations;

namespace school_management_wpf_project.Models {
	public class User {
		[Key]
		public int Id {
			get; set;
		}
		public string Username {
			get; set;
		}
		public string FirstName {
			get; set;
		}
		public string LastName {
			get; set;
		}
		public string Password {
			get; set;
		}
		public string Role {
			get; set;
		}
	}
}
