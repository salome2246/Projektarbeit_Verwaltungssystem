using System.Text.Json;
using Verwaltungssystem.Services;

namespace Verwaltungssystem;
class Program
{
    static void Main(string[] args)
    {
        string ordner = "Datenspeicher";

        // Prüfen, ob Ordner existiert, sonst erstellen
        if (!Directory.Exists(ordner))
        {
            Directory.CreateDirectory(ordner);
        }

        // Pfad zur JSON-Datei
        string filePath = Path.Combine(ordner, "//Users/salome/Desktop/AL/Projektarbeit_Verwaltungssystem/Verwaltungssystem/Verwaltungssystem/Datenspeicher/daten.json");
        DatenContext context = DatenContext.Load(filePath);
        
        ProjectService projectService = new ProjectService();
        InformationService infoService = new InformationService();
       

        Benutzer projektleiter = new Benutzer(1, "Max", Rolle.Projektleiter);
        Benutzer mitarbeiter = new Benutzer(2, "Anna", Rolle.Mitarbeiter);

        Projekt aktuellesProjekt = null;
        Information aktuelleInfo = null;
        
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Verwaltungssystem Menü ---");
            Console.WriteLine("1 Projekt erstellen");
            Console.WriteLine("2 Information schreiben");
            Console.WriteLine("3 Tag hinzufügen");
            Console.WriteLine("4 Kommentar schreiben");
            Console.WriteLine("5 Nach Tag suchen");
            Console.WriteLine("6 Beenden");

            Console.Write("Auswahl: ");
            string eingabe = Console.ReadLine();

            switch (eingabe)
            {
                case "1":
                    Console.Write("Projektname: ");
                    string pname = Console.ReadLine();

                    Console.Write("Kunde: ");
                    string kunde = Console.ReadLine();

                    aktuellesProjekt = projectService.erstelleProjekt(
                        pname,
                        kunde,
                        projektleiter,
                        context
                    );

                    Console.WriteLine("Projekt erstellt!");
                    break;

                case "2":
                    if (aktuellesProjekt == null)
                    {
                        Console.WriteLine("Bitte zuerst ein Projekt erstellen.");
                        break;
                    }

                    Console.Write("Information Inhalt: ");
                    string text = Console.ReadLine();

                    aktuelleInfo = infoService.erstelleInformation(
                        aktuellesProjekt,
                        mitarbeiter,
                        Informationstyp.Text,
                        text
                    );

                    Console.WriteLine("Information erstellt.");
                    break;

                case "3":
                    if (aktuelleInfo == null)
                    {
                        Console.WriteLine("Bitte zuerst eine Information erstellen.");
                        break;
                    }

                    Console.WriteLine("Tag wählen:");
                    Console.WriteLine("1 Rosa");
                    Console.WriteLine("2 Grün");
                    Console.WriteLine("3 Gelb");
                    Console.WriteLine("4 Blau");

                    string tagInput = Console.ReadLine();

                    Tag tag = tagInput switch
                    {
                        "1" => Tag.Rosa,
                        "2" => Tag.Grün,
                        "3" => Tag.Gelb,
                        "4" => Tag.Blau,
                        _ => throw new Exception("Ungültiger Tag")
                    };

                    infoService.tagHinzufügen(aktuelleInfo, tag);

                    Console.WriteLine("Tag hinzugefügt.");
                    break;

                case "4":
                    if (aktuelleInfo == null)
                    {
                        Console.WriteLine("Bitte zuerst eine Information erstellen.");
                        break;
                    }

                    Console.Write("Kommentar: ");
                    string kommentarText = Console.ReadLine();

                    infoService.kommentarHinzufügen(
                        aktuelleInfo,
                        projektleiter,
                        kommentarText
                    );

                    Console.WriteLine("Kommentar hinzugefügt.");
                    break;

                case "5":

                    Console.WriteLine("Nach welchem Tag suchen?");
                    Console.WriteLine("1 Rosa");
                    Console.WriteLine("2 Grün");
                    Console.WriteLine("3 Gelb");
                    Console.WriteLine("4 Blau");

                    string suche = Console.ReadLine();

                    Tag suchTag = suche switch
                    {
                        "1" => Tag.Rosa,
                        "2" => Tag.Grün,
                        "3" => Tag.Gelb,
                        "4" => Tag.Blau,
                        _ => throw new Exception("Ungültiger Tag")
                    };

                    var infos = context.SucheInformationenNachTag(suchTag);

                    Console.WriteLine("\nGefundene Informationen:");

                    foreach (var info in infos)
                    {
                        Console.WriteLine(info.Inhalt);
                    }

                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }
        }
        
        // Daten speichern
        context.Save(filePath);
    }
}
