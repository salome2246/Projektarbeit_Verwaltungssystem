namespace Verwaltungssystem.Services;

public class InformationService
{
    private int nextInfoId = 1;
    private int nextCommentId = 1;

    public Information erstelleInformation(Projekt projekt, Benutzer autor, Informationstyp typ, string inhalt)
    {
        Information info = new Information
        {
            Id = nextInfoId++,
            Typ = typ,
            Inhalt = inhalt,
            Autor = autor
        };
        projekt.Informationen.Add(info);
        return info;
    }

    public void tagHinzufügen(Information info, Tag tag)
    {
        // Prüfen, ob max. 3 Tags überschritten werden
        if (info.Tags.Count >= 3)
        {
            throw new InvalidOperationException("Maximal 3 Tags erlaubt.");
        }

        // Tag hinzufügen
        info.Tags.Add(tag);
    }

    public Kommentar kommentarHinzufügen(Information info, Benutzer autor, string text)
    {
        var kommentar = new Kommentar
        {
            Id = nextCommentId++,
            Text = text,
            Autor = autor
        };

        info.Kommentare.Add(kommentar);

        return kommentar;
    }
}