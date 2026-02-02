namespace Verwaltungssystem;

public class Projekt
{
    public int Id;
    public string Name;
    private string Kunde;
    public Benutzer Projektleiter;
    private string Kernanforderungen;
    public List<Kommentar> Kommentare { get; set; } = new List<Kommentar>();
}