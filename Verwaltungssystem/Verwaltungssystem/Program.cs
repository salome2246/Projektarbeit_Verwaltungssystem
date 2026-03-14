using System.Text.Json;
using Verwaltungssystem.Services;

namespace Verwaltungssystem;

class Program
{
    static void Main(string[] args)
    {
        string ordner = "Datenspeicher";
        
        // Pfad zur JSON-Datei
        string filePath = Path.Combine(ordner,
            "//Users/salome/Desktop/AL/Projektarbeit_Verwaltungssystem/Verwaltungssystem/Verwaltungssystem/Datenspeicher/daten.json");
        
        DatenContext context = DatenContext.Load(filePath);
        
        ProjectService projectService = new ProjectService();
        InformationService infoService = new InformationService();

        Benutzer projektleiter = new Benutzer(1, "Salome", Rolle.Projektleiter);
        Benutzer mitarbeiter = new Benutzer(2, "Bertrand", Rolle.Mitarbeiter);
        
        context.Benutzer.Add(projektleiter);
        context.Benutzer.Add(mitarbeiter);
        
        Projekt projektA = projectService.erstelleProjekt("ProjektA","Kunde1",projektleiter,context);
        Information infoA = infoService.erstelleInformation(projektA, mitarbeiter, Informationstyp.Text, "Das ist die Info");
        projectService.informationHinzufügen(projektA,infoA);
        infoService.kommentarHinzufügen(infoA,mitarbeiter,"das ist der Kommentar 1");

        var inhalteMitBlau = context.SucheInformationenNachTag(Tag.Gelb);

        foreach (var info in inhalteMitBlau)
        {
            Console.WriteLine($"Info {info.Id}: {info.Inhalt}");
        }
        
        // Daten speichern
        context.Save(filePath);
    }
}
