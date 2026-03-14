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
        InformationService infoService = new InformationService();
        //ProjectService projectService = new ProjectService();
        

       // Benutzer projektleiter = new Benutzer(1, "Salome", Rolle.Projektleiter);
        //Benutzer mitarbeiter = new Benutzer(2, "Bertrand", Rolle.Mitarbeiter);
        
       // context.Benutzer.Add(projektleiter);
        //context.Benutzer.Add(mitarbeiter);
        
        //Projekt projektA = projectService.erstelleProjekt("ProjektA","KundeA",projektleiter,context);
        //Information infoA = infoService.erstelleInformation(projektA, mitarbeiter, Informationstyp.Text, "das is die inforamtion");
       // infoService.kommentarHinzufügen(infoA, mitarbeiter,"das ist der kommentar");
       // infoService.tagHinzufügen(infoA,Tag.Blau);
       

        var inhalteMitBlau = context.SucheInformationenNachTag(Tag.Blau);

        foreach (var info in inhalteMitBlau)
        {
            Console.WriteLine($"Info {info.Id}: {info.Inhalt}");
        }
        
        var infor = inhalteMitBlau.FirstOrDefault();
        if (infor != null)
        {
            
            infoService.tagHinzufügen(infor,Tag.Rosa);
            
        }
        else
        {
            Console.WriteLine("Keine Information gefunden.");
        }
        
        // Daten speichern
        context.Save(filePath);
        
        
    }
}
