using System.Text.Json;

namespace Verwaltungssystem;

class Program
{
    static void Main(string[] args)
    {
        // 1️⃣ DatenContext laden oder neu erstellen
        DatenContext context;

        if (File.Exists("daten.json"))
        {
            string json = File.ReadAllText("daten.json");
            context = JsonSerializer.Deserialize<DatenContext>(json) ?? new DatenContext();
        }
        else
        {
            context = new DatenContext();
        }
        
        // 1️⃣ Benutzer erstellen
        Benutzer max = new Benutzer { BenutzerId = 1, Name = "Max", Rolle = Rolle.Projektleiter };
        context.Benutzer.Add(max);
        
        // 2️⃣ Benutzer erstellt ein Projekt
        Projekt projekt1 = max.ErstelleProjekt("Neues IT-Projekt", "Firma XY",context);
        Console.WriteLine($"Projekt '{projekt1.Name}' wurde erstellt von {projekt1.Projektleiter.Name}.");
        

        // 3️⃣ Benutzer fügt dem Projekt eine Information mit Tags hinzu
        List<Tag> tags = new List<Tag> { Tag.Gelb, Tag.Rosa };
        Information info1 = max.SchreibeInformation(projekt1, "Kickoff Meeting geplant", tags);
        Console.WriteLine($"Information hinzugefügt: '{info1.Inhalt}' mit Tags: {string.Join(", ", info1.Tags)}");

        // 4️⃣ Benutzer fügt der Information einen Kommentar hinzu
        Kommentar kommentar1 = max.SchreibeKommentar(info1, "Bitte Agenda vorbereiten");
        Console.WriteLine($"Kommentar von {kommentar1.Autor.Name}: '{kommentar1.Inhalt}'");
        
        var resultate = max.SucheNachTag(Tag.Gelb, context);

        foreach (var info in resultate)
        {
            Console.WriteLine(info.Inhalt);
        }

        // 5️⃣ Optional: Ausgabe aller Informationen und Kommentare des Projekts
        Console.WriteLine("\nProjektübersicht:");
        foreach (var info in projekt1.Informationen)
        {
            Console.WriteLine($"- Information: {info.Inhalt} [Tags: {string.Join(", ", info.Tags)}]");
            foreach (var com in info.Kommentare)
            {
                Console.WriteLine($"  - Kommentar von {com.Autor.Name}: {com.Inhalt}");
            }
        }
        
        var options = new JsonSerializerOptions { WriteIndented = true };
        File.WriteAllText("daten.json", JsonSerializer.Serialize(context, options));
    }
    
    //
}