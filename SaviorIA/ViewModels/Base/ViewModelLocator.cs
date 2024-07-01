using SaviorIA.Services.Settings;
using SaviorIA.ViewModels.Formularios;
using SaviorIA.ViewModels.Login;
using SaviorIA.ViewModels.MainMenu;


namespace SaviorIA.ViewModels.Base
{
    public class ViewModelLocator
    {
        private static IServiceProvider _serviceProvider;
        private static IServiceCollection services;

        static ViewModelLocator()
        {
            services = new ServiceCollection(); 
            services.AddScoped<LoginViewModel>();
            services.AddScoped<MainMenuViewModel>();
            services.AddScoped<TestViewModel>();
            services.AddScoped<FormIaViewModel>();
            
            

            // repositorio
            // services.AddSingleton<BaseRepository>();
            // services.AddSingleton<IMediaPicker>(MediaPicker.Default);
           
            _serviceProvider = services.BuildServiceProvider();
        }
        public LoginViewModel loginViewModel
        {
            get => Resolve<LoginViewModel>();
        }


        public MainMenuViewModel mainMenuViewModel
        {
            get => Resolve<MainMenuViewModel>();
        }

        public TestViewModel testViewModel
        {
            get => Resolve<TestViewModel>();
        }
        public FormIaViewModel formIaViewModel
        {
            get => Resolve<FormIaViewModel>();
        }

       

        public static T Resolve<T>() where T : class
        {
            return _serviceProvider.GetRequiredService<T>();
        }
        public static void Register<T>(Func<T> function) where T : class
        {
            services.AddSingleton<T>((sp) => function());
            _serviceProvider = services.BuildServiceProvider();
        }
    }
}
