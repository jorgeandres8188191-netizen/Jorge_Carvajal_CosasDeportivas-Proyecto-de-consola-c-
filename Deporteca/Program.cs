// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Quiero hacer un conflicto 


public class Deportes
{
    public int ID;
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public int NumeroJugadores { get; set; }
    public List<string> Competicion { get; set; }
    public List<Equipos> Equipo { get; set; }
}

public class Jugadores
{
    public int ID;
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Posicion { get; set; }
    public int NumeroCamiseta { get; set; }
}
public class Equipos
{
    public int ID;
    public string Nombre { get; set; }
    public string Ciudad { get; set; }
    public int Fundacion { get; set; }
    public List<Jugadores> Jugador { get; set; }
    public List<Partidos> Partido { get; set; }
    public Deportes Deporte { get; set; }
}

public class Partidos
{
    public int ID;
    public Equipos EquipoLocal { get; set; }
    public Equipos EquipoVisitante { get; set; }
    public DateTime Fecha { get; set; }
    public string Estadio { get; set; }
    public string Resultado { get; set; }
}