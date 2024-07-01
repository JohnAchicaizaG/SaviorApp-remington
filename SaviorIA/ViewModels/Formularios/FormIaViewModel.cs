using System.Diagnostics;
using Savior.Views.FormSavior;
using SaviorIA.Models;
using SaviorIA.ViewModels.Base;
using System.Text.Json;
using System.Net.Http;

using System.Text;
using System.Text.Json.Serialization;
using SaviorIA.Views.Menu;

namespace SaviorIA.ViewModels.Formularios;
public partial class FormIaViewModel : ViewModelBase
{
    // private readonly HttpClient client;

    HttpClient _client;
    JsonSerializerOptions _serializerOptions;

    public FormIaViewModel()
    {
        _client = new HttpClient();
        _serializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };
    }

    #region Registro

    
    private string _nombresIa;
    public string NombresIA
    {
        get => _nombresIa;
        set
        {
            _nombresIa = value;
            OnPropertyChanged();
        }
    }

    
    private string _diagnosticoIa;
    public string DiagnosticoIa
    {
        get => _diagnosticoIa;
        set
        {
            _diagnosticoIa = value;
            OnPropertyChanged();
        }
    }


    private string _mensaje;
    public string Mensaje
    {
        get => _mensaje;
        set
        {
            _mensaje = value;
            OnPropertyChanged();
        }
    }


        private int _puntuacion;
    public int Puntuacion
    {
        get => _puntuacion;
        set
        {
            _puntuacion = value;
            OnPropertyChanged();
        }
    }



    

    #endregion

    #region Propiedades Register

    private DateTime _fechaNacimiento;
    public DateTime FechaNacimiento
    {
        get => _fechaNacimiento;
        set
        {
            _fechaNacimiento = value;
            OnPropertyChanged();
        }
    }


    private string _ubicacion;
    public string Ubicacion
    {
        get => _ubicacion;
        set
        {
            _ubicacion = value;
            OnPropertyChanged();
        }
    }


    private string _numeroIdentificacion;
    public string NumeroIdentificacion
    {
        get => _numeroIdentificacion;
        set
        {
            _numeroIdentificacion = value;
            OnPropertyChanged();
        }
    }


    private string _primerNombre;
    public string PrimerNombre
    {
        get => _primerNombre;
        set
        {
            _primerNombre = value;
            OnPropertyChanged();
        }
    }

    private string _segundoNombre;
    public string SegundoNombre
    {
        get => _segundoNombre;
        set
        {
            _segundoNombre = value;
            OnPropertyChanged();
        }
    }

    private string _primerApellido;
    public string PrimerApellido
    {
        get => _primerApellido;
        set
        {
            _primerApellido = value;
            OnPropertyChanged();
        }
    }

    private string _segundoApellido;
    public string SegundoApellido
    {
        get => _segundoApellido;
        set
        {
            _segundoApellido = value;
            OnPropertyChanged();
        }
    }

    private int _edad;
    public int Edad
    {
        get => _edad;
        set
        {
            _edad = value;
            OnPropertyChanged();
        }
    }

    private string _genero;
    public string Genero
    {
        get => _genero;
        set
        {
            _genero = value;
            OnPropertyChanged();
        }
    }

    #endregion


    #region Propiedades Register

    private string _preguntaUno;
    public string PreguntaUno
    {
        get => _preguntaUno;
        set
        {
            _preguntaUno = value;
            OnPropertyChanged();
        }
    }

    private string _preguntaDos;
    public string PreguntaDos
    {
        get => _preguntaDos;
        set
        {
            _preguntaDos = value;
            OnPropertyChanged();
        }
    }

    private string _preguntaTres;
    public string PreguntaTres
    {
        get => _preguntaTres;
        set
        {
            _preguntaTres = value;
            OnPropertyChanged();
        }
    }

    private string _preguntaCuatro;
    public string PreguntaCuatro
    {
        get => _preguntaCuatro;
        set
        {
            _preguntaCuatro = value;
            OnPropertyChanged();
        }
    }

    private string _preguntaCinco;
    public string PreguntaCinco
    {
        get => _preguntaCinco;
        set
        {
            _preguntaCinco = value;
            OnPropertyChanged();
        }
    }

    private string _preguntaSeis;
    public string PreguntaSeis
    {
        get => _preguntaSeis;
        set
        {
            _preguntaSeis = value;
            OnPropertyChanged();
        }
    }

    private string _preguntaSiete;
    public string PreguntaSiete
    {
        get => _preguntaSiete;
        set
        {
            _preguntaSiete = value;
            OnPropertyChanged();
        }
    }

    private string _preguntaOcho;
    public string PreguntaOcho
    {
        get => _preguntaOcho;
        set
        {
            _preguntaOcho = value;
            OnPropertyChanged();
        }
    }

    private string _preguntaNueve;
    public string PreguntaNueve
    {
        get => _preguntaNueve;
        set
        {
            _preguntaNueve = value;
            OnPropertyChanged();
        }
    }

    private string _preguntaDiez;
    public string PreguntaDiez
    {
        get => _preguntaDiez;
        set
        {
            _preguntaDiez = value;
            OnPropertyChanged();
        }
    }

    private string _preguntaOnce;
    public string PreguntaOnce
    {
        get => _preguntaOnce;
        set
        {
            _preguntaOnce = value;
            OnPropertyChanged();
        }
    }

    #endregion


    Command _pruebas;
    public Command PruebasCommand
    {
        get { return _pruebas ??= new Command(() => pruebas(), () => !IsBusy); }
    }
    Command _send;
    public Command SendCommand
    {
        get { return _send ??= new Command(() => sendForm(), () => !IsBusy); }
    }


    private void pruebas()
    {
        Shell.Current.GoToAsync(nameof(FormSavior));
    }


    //     public async void sendForm()
    //     {
    //         // Crear el objeto JSON de prueba
    //         var data = new
    //         {
    //             mensaje = "Este es un mensaje de prueba"
    //         };
    //         string jsonData = JsonSerializer.Serialize(data);

    //         // URL a la que enviar la solicitud POST
    //         string url = "http://192.168.100.6:3000/gpt/savior";

    //         // Crear una instancia de HttpClient
    //         using (HttpClient client = new HttpClient())
    //         {
    //             // Configurar la solicitud HTTP POST
    //             var content = new StringContent(jsonData, System.Text.Encoding.UTF8, "application/json");

    //             try
    //             {
    //                 // Realizar la solicitud HTTP POST
    //                 HttpResponseMessage response = await client.PostAsync(url, content);

    //                 // Verificar si la solicitud fue exitosa
    //                 if (response.IsSuccessStatusCode)
    //                 {
    //                     // Leer y mostrar la respuesta del servidor
    //                     string responseContent = await response.Content.ReadAsStringAsync();
    //                     Console.WriteLine("Respuesta del servidor:");
    //                     Console.WriteLine(responseContent);
    //                 }
    //                 else
    //                 {
    //                     Console.WriteLine($"Error en la solicitud: {response.StatusCode}");
    //                 }
    //             }
    //             catch (Exception ex)
    //             {
    //                 Console.WriteLine($"Error al enviar la solicitud: {ex.Message}");
    //             }
    //         }

    // }



    // private async void EnviarSolicitudHTTP()
    // {

    // }



    private async void sendForm()
    {
         await Shell.Current.GoToAsync(nameof(respuestaIa));
        Debug.WriteLine("entramos");
        try
        {
            FormIa formIa = new FormIa
            {
                FechaNacimiento = FechaNacimiento,
                Ubicacion = Ubicacion,
                NumeroIdentificacion = NumeroIdentificacion,
                PrimerNombre = PrimerNombre,
                SegundoNombre = SegundoNombre,
                PrimerApellido = PrimerApellido,
                SegundoApellido = SegundoApellido,
                Edad = Edad,
                Genero = Genero,
                PreguntaUno = PreguntaUno,
                PreguntaDos = PreguntaDos,
                PreguntaTres = PreguntaTres,
                PreguntaCuatro = PreguntaCuatro,
                PreguntaCinco = PreguntaCinco,
                PreguntaSeis = PreguntaSeis,
                PreguntaSiete = PreguntaSiete,
                PreguntaOcho = PreguntaOcho,
                PreguntaNueve = PreguntaNueve,
                PreguntaDiez = PreguntaDiez,
                PreguntaOnce = PreguntaOnce
            };

            // Serializar objeto a JSON
            string json = JsonSerializer.Serialize(formIa);

            // URL a la que enviar la solicitud POST
            string url = "http://192.168.100.98:3000/gpt/savior";

            // Crear objeto HttpClient
            using (HttpClient client = new HttpClient())
            {
                // Configurar el contenido de la solicitud
                StringContent content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                // Enviar solicitud POST y obtener respuesta
                HttpResponseMessage response = await client.PostAsync(url, content);

                // Verificar si la solicitud fue exitosa (código de estado 200)
                if (response.IsSuccessStatusCode)
                {
                    // Leer y procesar la respuesta
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine("Respuesta del servidor: " + responseContent);
                    JsonDocument jsonDocument = JsonDocument.Parse(responseContent);
                    var root = jsonDocument.RootElement;

                    ResponseData responseData = new ResponseData
                    {
                        Nombres = root.GetProperty("nombres").GetString(),
                        DiagnosticoIa = root.GetProperty("diagnosticoIa").GetString(),
                        Mensaje = root.GetProperty("mensaje").GetString(),
                        Puntuacion = root.GetProperty("Puntuacion").GetInt32()
                    };
                    NombresIA = responseData.Nombres;
                    DiagnosticoIa = responseData.DiagnosticoIa;
                    Mensaje = responseData.Mensaje;
                    Puntuacion = responseData.Puntuacion;

                    Debug.WriteLine(Mensaje,DiagnosticoIa, Mensaje, Puntuacion);
                    
                    await Shell.Current.GoToAsync(nameof(respuestaIa));

                }
                else
                {
                    // Si la solicitud no fue exitosa, mostrar el código de estado
                    Debug.WriteLine("La solicitud no fue exitosa. Código de estado: " + response.StatusCode);
                }

            }
        }
        catch (Exception ex)
        {

            Console.WriteLine($"Error: {ex.Message}");
        }
    }







}

public class ResponseData
{
    [JsonPropertyName("nombres")]
    public string Nombres { get; set; }

    [JsonPropertyName("diagnosticoIa")]
    public string DiagnosticoIa { get; set; }


    [JsonPropertyName("mensaje")]
    public string Mensaje { get; set; }

    [JsonPropertyName("Puntuacion")]
    public int Puntuacion { get; set; }
}