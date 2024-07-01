using System.Diagnostics;
using Savior.Views.FormSavior;

namespace SaviorIA.Views.Menu;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
	}


	private async void stepTwo(object sender, TappedEventArgs e)
	{
		Debug.WriteLine("paso2 here");

		// Navegar a la página FormSavior
		await Shell.Current.GoToAsync(nameof(FormSavior));
	}
}