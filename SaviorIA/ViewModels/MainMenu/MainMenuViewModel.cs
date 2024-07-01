using System.Diagnostics;
using SaviorIA.ViewModels.Base;
using SaviorIA.Views;
using SaviorIA.Views.Menu;

namespace SaviorIA.ViewModels.MainMenu;

public class MainMenuViewModel : ViewModelBase
{
	#region Comandos
	Command _goToRegister;
	public Command GoToRegisterCommand
	{
		get { return _goToRegister ??= new Command(() => GoToPageRegister(), () => !IsBusy); }
	}

	Command _goToDiagnostic;
	public Command GoToDiagnosticCommand
	{
		get { return _goToDiagnostic ??= new Command(() => GoToPageDiagnostic(), () => !IsBusy); }
	}
	Command _goToEstrategies;
	public Command GoToEstrategiesCommand
	{
		get { return _goToEstrategies ??= new Command(() => GoToPageEstrategies(), () => !IsBusy); }
	}

	Command _goToTests;
	public Command GoToTestsCommand
	{
		get { return _goToTests ??= new Command(() => GoToPageTests(), () => !IsBusy); }
	}

	Command _goToGeneralAdjustments;
	public Command GoToGeneralAdjustments
	{
		get { return _goToGeneralAdjustments ??= new Command(() => GoToPageGeneralAdjustments(), () => !IsBusy); }
	}

	Command _goToAbout;
	public Command GoToAbout
	{
		get { return _goToAbout ??= new Command(() => GoToPageAbout(), () => !IsBusy); }
	}


	#endregion





	private void GoToPageRegister()
	{
		Debug.WriteLine("Hola");
		Shell.Current.GoToAsync(nameof(Register));
	}

	private void GoToPageAbout()
	{
		Debug.WriteLine("Hola");
		Shell.Current.GoToAsync(nameof(About));
	}

	private void GoToPageGeneralAdjustments()
	{
		Debug.WriteLine("Hola");
		Shell.Current.GoToAsync(nameof(GeneralAdjustments));
	}

	private void GoToPageEstrategies()
	{
		Debug.WriteLine("Hola");
		Shell.Current.GoToAsync(nameof(Estrategy));
	}

		private void GoToPageDiagnostic()
	{
		Shell.Current.GoToAsync(nameof(Diagnostic));
	}


	private void GoToPageTests()
	{
		Shell.Current.GoToAsync(nameof(Test));
	}

}