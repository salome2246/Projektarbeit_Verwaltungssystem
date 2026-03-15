namespace Verwaltungssystem;

public class Kommentar
{
    public int Id { get; set; }
    public string Text { get; set; }
    public Benutzer Autor { get; set; }
    
}