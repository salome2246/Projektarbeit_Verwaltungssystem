using System.Text.Json;

namespace Verwaltungssystem;

public class DatenContext
{
    public List<Benutzer> Benutzer { get; set; } = new();
    public List<Projekt> Projekte { get; set; } = new();

    public void Save(string filePath)
    {
        string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, json);
    }

    public static DatenContext Load(string filePath)
    {
        if (!File.Exists(filePath)) return new DatenContext();
        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<DatenContext>(json) ?? new DatenContext();
    }
    
    public List<Information> SucheInformationenNachTag(Tag tag)
    {
        return Projekte
            .SelectMany(p => p.Informationen)
            .Where(info => info.Tags.Contains(tag))
            .ToList();
    }
}