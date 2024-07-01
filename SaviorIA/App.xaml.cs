
using SaviorIA.Models;
using SaviorIA.Views;

namespace SaviorIA;

public partial class App : Application
{
	public static LoginModel PersonLoged;
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		



		Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(Border), (handler, view) =>
	{
#if __ANDROID__
                handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#elif __IOS__
		handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
		handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;

#endif
	});


		Microsoft.Maui.Handlers.PickerHandler.Mapper.AppendToMapping(nameof(Picker), (handler, view) =>
	{
#if __ANDROID__
                handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#elif __IOS__
		handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
		handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;

#endif
	});

		Microsoft.Maui.Handlers.DatePickerHandler.Mapper.AppendToMapping(nameof(DatePicker), (handler, view) =>
		{
#if __ANDROID__
                handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#elif __IOS__
			handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;

#endif
		});



		Microsoft.Maui.Handlers.EditorHandler.Mapper.AppendToMapping(nameof(Editor), (handler, view) =>
		{
#if __ANDROID__
                handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#elif __IOS__
			handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;

#endif
		});



		Microsoft.Maui.Handlers.TimePickerHandler.Mapper.AppendToMapping(nameof(Timer), (handler, view) =>
		{
#if __ANDROID__
                handler.PlatformView.SetBackgroundColor(Android.Graphics.Color.Transparent);
#elif __IOS__
			handler.PlatformView.BackgroundColor = UIKit.UIColor.Clear;
#endif
		});


	}


	private void BootHomePage(object sender, EventArgs e)
	{
		Application.Current.MainPage = new NavigationPage(new InitialPage());
	}
}
