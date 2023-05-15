using CommunityToolkit.Mvvm.Input;
using school_management_wpf_project.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

public class MainMenuViewModel : INotifyPropertyChanged {
	private User _user;
	private ICommand _messageBoxForAdmins;
	private ICommand _messageBoxForTeachers;
	private ICommand _messageBoxForEverybody;

	public MainMenuViewModel(User user) {
		_user = user;
		_messageBoxForAdmins = new RelayCommand(MessageBoxForAdmins, CanExecuteAdminCommand);
		_messageBoxForTeachers = new RelayCommand(MessageBoxForTeachers, CanExecuteTeacherAdminCommand);
		_messageBoxForEverybody = new RelayCommand(MessageBoxForEverybody);
	}

	public User User {
		get => _user;
		set {
			_user = value;
			OnPropertyChanged(nameof(User));
		}
	}

	public ICommand MessageBoxForAdminsCommand {
		get => _messageBoxForAdmins;
	}

	public ICommand MessageBoxForTeachersCommand {
		get => _messageBoxForTeachers;
	}

	public ICommand MessageBoxForEverybodyCommand {
		get => _messageBoxForEverybody;
	}

	private void MessageBoxForAdmins() {
		MessageBox.Show("This is a message box for admins");
	}

	private void MessageBoxForTeachers() {
		MessageBox.Show("This is a message box for teachers");
	}

	private void MessageBoxForEverybody() {
		MessageBox.Show("This is a message box for everybody");
	}

	private bool CanExecuteAdminCommand() {
		return User.Role == "admin";
	}

	private bool CanExecuteTeacherAdminCommand() {
		return User.Role == "admin" || User.Role == "teacher";
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void OnPropertyChanged([CallerMemberName] string propertyName = null) {
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
