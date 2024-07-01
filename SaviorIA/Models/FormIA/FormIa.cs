namespace SaviorIA.Models;

public class FormIa
{
    public DateTime FechaNacimiento { get; set; }
    public string Ubicacion { get; set; }
    public string NumeroIdentificacion { get; set; }
    public string PrimerNombre { get; set; }
    public string SegundoNombre { get; set; }
    public string PrimerApellido { get; set; }
    public string SegundoApellido { get; set; }
    public int Edad { get; set; }
    public string Genero { get; set; }
    public string PreguntaUno { get; set; }
    public string PreguntaDos { get; set; }
    public string PreguntaTres { get; set; }
    public string PreguntaCuatro { get; set; }
    public string PreguntaCinco { get; set; }
    public string PreguntaSeis { get; set; }
    public string PreguntaSiete { get; set; }
    public string PreguntaOcho { get; set; }
    public string PreguntaNueve { get; set; }
    public string PreguntaDiez { get; set; }
    public string PreguntaOnce { get; set; }



        public override string ToString()
    {
        return $"FechaNacimiento: {FechaNacimiento}, Ubicacion: {Ubicacion}, NumeroIdentificacion: {NumeroIdentificacion}, " +
               $"PrimerNombre: {PrimerNombre}, SegundoNombre: {SegundoNombre}, PrimerApellido: {PrimerApellido}, " +
               $"SegundoApellido: {SegundoApellido}, Edad: {Edad}, Genero: {Genero}, " +
               $"PreguntaUno: {PreguntaUno}, PreguntaDos: {PreguntaDos}, PreguntaTres: {PreguntaTres}, " +
               $"PreguntaCuatro: {PreguntaCuatro}, PreguntaCinco: {PreguntaCinco}, PreguntaSeis: {PreguntaSeis}, " +
               $"PreguntaSiete: {PreguntaSiete}, PreguntaOcho: {PreguntaOcho}, PreguntaNueve: {PreguntaNueve}, " +
               $"PreguntaDiez: {PreguntaDiez}, PreguntaOnce: {PreguntaOnce}";
    }
}
