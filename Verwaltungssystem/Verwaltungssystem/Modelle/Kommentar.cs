namespace Verwaltungssystem;

public class Kommentar
{
    public int KommentarId { get; set; }
    public string Inhalt { get; set; }
    public Benutzer Autor { get; set; }

    
}