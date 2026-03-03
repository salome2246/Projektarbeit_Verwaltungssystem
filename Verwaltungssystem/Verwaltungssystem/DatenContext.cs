namespace Verwaltungssystem;

public class DatenContext
{
    public List<Benutzer> Benutzer { get; set; } = new();
    public List<Projekt> Projekte { get; set; } = new();
}