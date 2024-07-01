namespace SaviorIA.Models;

public class LoginModel : ContentPage
{
	public string UserName { get; set; }
	public string Password { get; set; }

	public LoginModel(string userName, string password)
	{
		UserName = userName;
		Password = password;
	}

}