using System.ComponentModel;
using System.Diagnostics;

namespace SaviorIA.Views.Menu.Tests;

public partial class Beck : ContentPage, INotifyPropertyChanged
{

    private Dictionary<string, int> valoresSeleccionados = new Dictionary<string, int>();
    private int contador;
     public int Contador 
    { 
        get { return contador; } 
        set
        {
            if (contador != value)
            {
                contador = value;
                OnPropertyChanged(nameof(Contador));
            }
        }
    } 
    public Beck()
    {
        InitializeComponent();
        BindingContext = this; 
    }


          private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        var radioButton = (RadioButton)sender;
        if (e.Value)
        {
            int valor = Convert.ToInt32(radioButton.Value);
            string groupName = radioButton.GroupName;

            if (valoresSeleccionados.ContainsKey(groupName))
            {
                valoresSeleccionados[groupName] = valor;
            }
            else
            {
                valoresSeleccionados.Add(groupName, valor);
            }

            Contador += valor; // Incrementar el contador
        }
        else
        {
            int valor = Convert.ToInt32(radioButton.Value);
            string groupName = radioButton.GroupName;
            if (valoresSeleccionados.ContainsKey(groupName))
            {
                int valorAnterior = valoresSeleccionados[groupName];
                if (valorAnterior == valor)
                {
                    Contador -= valor; // Decrementar el contador
                    valoresSeleccionados.Remove(groupName);
                }
            }
        }

        Debug.WriteLine($"Contador: {Contador}");
    }
}