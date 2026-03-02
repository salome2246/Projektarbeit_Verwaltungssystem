namespace Verwaltungssystem;

public class Projekt
{
    public int ProjektId { get; set; }
    public string Name { get; set; }
    public string Kunde { get; set; }
    public Benutzer Projektleiter { get; set; }
    public List<Information> Informationen { get; set; } = new List<Information>();

   
}


