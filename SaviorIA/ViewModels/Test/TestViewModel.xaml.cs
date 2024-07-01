using System.Diagnostics;
using SaviorIA.ViewModels.Base;
using SaviorIA.Views.Menu.Tests;

namespace SaviorIA.ViewModels.MainMenu;
public partial class TestViewModel : ViewModelBase
{


	#region Propiedades

    private string _groupName;
    public string GroupName
    {
        get { return _groupName; }
        set
        {
            if (_groupName != value)
            {
                _groupName = value;
                OnPropertyChanged(nameof(GroupName));
            }
        }
    }

    private string _selection;
    public string Selection
    {
        get { return _selection; }
        set
        {
            if (_selection != value)
            {
                _selection = value;
                OnPropertyChanged(nameof(Selection));
            }
        }
    }
	#endregion


	#region Comandos
	Command _goToBeck;
	public Command GoToBeckCommand
	{
		get { return _goToBeck ??= new Command(() => GoToBeck(), () => !IsBusy); }
	}

	Command _goToSadPerson;
	public Command GoToSadPersonCommand
	{
		get { return _goToSadPerson ??= new Command(() => GoToSadPerson(), () => !IsBusy); }
	}



    
	#endregion


	private void GoToBeck()
	{
		Debug.WriteLine("here");
		Shell.Current.GoToAsync(nameof(Beck));
	}
	private void GoToSadPerson()
	{
		Debug.WriteLine("here");
		Shell.Current.GoToAsync(nameof(SadPerson));
	}
}