using Savior.Views.FormSavior;
using SaviorIA.Views;
using SaviorIA.Views.Menu;
using SaviorIA.Views.Menu.Tests;

namespace SaviorIA;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		
		//Registro de rutas
		Routing.RegisterRoute(nameof(InitialPage), typeof(InitialPage));
		Routing.RegisterRoute(nameof(Login), typeof(Login));


		Routing.RegisterRoute(nameof(Diagnostic), typeof(Diagnostic));
		Routing.RegisterRoute(nameof(Register), typeof(Register));
		Routing.RegisterRoute(nameof(FormSavior), typeof(FormSavior));
		Routing.RegisterRoute(nameof(Test), typeof(Test));
		Routing.RegisterRoute(nameof(Beck), typeof(Beck));
		Routing.RegisterRoute(nameof(SadPerson), typeof(SadPerson));

		Routing.RegisterRoute(nameof(Estrategy), typeof(Estrategy));
		Routing.RegisterRoute(nameof(Configuration), typeof(Configuration));

		Routing.RegisterRoute(nameof(GeneralAdjustments), typeof(GeneralAdjustments));
		Routing.RegisterRoute(nameof(About), typeof(About));
		Routing.RegisterRoute(nameof(respuestaIa), typeof(respuestaIa));


		

	}

}
