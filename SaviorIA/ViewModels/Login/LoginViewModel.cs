using System.Diagnostics;
using SaviorIA.Models;
using SaviorIA.ViewModels.Base;

namespace SaviorIA.ViewModels.Login;

public class LoginViewModel : ViewModelBase
{

	#region Propiedades

	private string _username;
	public string Username
	{
		get { return _username; }
		set
		{
			if (_username != value)
			{
				_username = value;
				OnPropertyChanged(nameof(Username));
			}
		}
	}

	private string _password;
	public string Password
	{
		get { return _password; }
		set
		{
			if (_password != value)
			{
				_password = value;
				OnPropertyChanged(nameof(Password));
			}
		}
	}
	private bool _isPasswordVisible;
	public bool IsPasswordVisible
	{
		get { return _isPasswordVisible; }
		set
		{
			if (_isPasswordVisible != value)
			{
				_isPasswordVisible = value;
				OnPropertyChanged(); // Asegúrate de que este método notifique a la vista sobre el cambio
			}
		}
	}

	#endregion


	#region Comandos
	Command _loginCommand;
	public Command LoginCommand
	{
		get { return _loginCommand ??= new Command(async () => await Login(), () => !IsBusy); }
	}


	Command _toLoginCommand;
	public Command ToLoginCommand
	{
		get { return _toLoginCommand ??= new Command(async () => await ToLogin(), () => !IsBusy); }
	}


	Command _visibilityPasswword;
	public Command VisibilityPasswwordCommand
	{
		get { return _visibilityPasswword ??= new Command(() => VisibilityPassword(), () => !IsBusy); }
	}


	#endregion


	#region Metodos

	private async Task ToLogin()
	{
		await Shell.Current.GoToAsync($"//{nameof(Login)}");
	}

	public void VisibilityPassword()
	{
		IsPasswordVisible = !IsPasswordVisible;
	}
	private async Task Login()
	{
		LoginModel loginUser = new LoginModel(Username, Password);
		App.PersonLoged = loginUser;
		Debug.WriteLine(loginUser);
		await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
	}


	#endregion


}