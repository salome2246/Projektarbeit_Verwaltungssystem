namespace Verwaltungssystem;

public class Information
{
    public int Id { get; set; }
    public Informationstyp Typ { get; set; }
    public string Inhalt { get; set; }
    public List<Tag> Tags { get; set; } = new List<Tag>();
    public Benutzer Autor { get; set; }

    public List<Kommentar> Kommentare { get; set; } = new List<Kommentar>();
}