namespace Verwaltungssystem;

public class Benutzer
{
    public int BenutzerId { get; set; }
    public string Name { get; set; }
    public Rolle Rolle { get; set; }

    public Projekt ErstelleProjekt(string name, string kunde, DatenContext context)
    {
        var projekt = new Projekt { Name = name, Kunde = kunde, Projektleiter = this };
        context.Projekte.Add(projekt);
        return projekt;
    }

    public Information SchreibeInformation(Projekt projekt, string inhalt, List<Tag> tags)
    {
        if(tags.Count < 1 || tags.Count > 3)
            throw new ArgumentException("Eine Information muss 1 bis 3 Tags haben.");

        var info = new Information { Inhalt = inhalt, Tags = tags };
        projekt.Informationen.Add(info);
        return info;
    }

    public Kommentar SchreibeKommentar(Information info, string inhalt)
    {
        var kommentar = new Kommentar { Inhalt = inhalt, Autor = this };
        info.Kommentare.Add(kommentar);
        return kommentar;
    }
    
    public List<Information> SucheNachTag(Tag tag, DatenContext context)
    {
        return context.SucheInformationenNachTag(tag);
    }
}
