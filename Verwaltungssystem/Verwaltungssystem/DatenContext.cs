namespace Verwaltungssystem;

public class DatenContext
{
    public List<Benutzer> Benutzer { get; set; } = new();
    public List<Projekt> Projekte { get; set; } = new();
    
    public List<Information> SucheInformationenNachTag(Tag tag)
    {
        return Projekte
            .SelectMany(p => p.Informationen)
            .Where(info => info.Tags.Contains(tag))
            .ToList();
    }
}