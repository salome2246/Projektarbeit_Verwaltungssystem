namespace Verwaltungssystem;

public class Information
{
    public int InfoId { get; set; }
    public string Inhalt { get; set; }
    public List<Tag> Tags { get; set; } = new List<Tag>();
    public List<Kommentar> Kommentare { get; set; } = new List<Kommentar>();
}