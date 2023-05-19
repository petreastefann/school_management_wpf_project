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
		public string Password {
			get; set;
		}
		public string Role {
			get; set;
		}

		public User(string username, string password, string role) {
			Username = username;
			Password = password;
			Role = role;
		}
		public User() {
			Username = "";
			Password = "";
			Role = "";
		}
	}
}
