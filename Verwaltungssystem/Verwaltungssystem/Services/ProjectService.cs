namespace Verwaltungssystem.Services;

public class ProjectService
{
    private List<Projekt> projekte = new List<Projekt>();
    private int nextProjectId = 1;
    
    public Projekt erstelleProjekt(string name, string kunde, Benutzer projektleiter,DatenContext context)
    {
        // Prüfen, ob der Benutzer die Rolle "Projektleiter" hat
        if (projektleiter.Rolle != Rolle.Projektleiter)
        {
            throw new InvalidOperationException("Nur Benutzer mit der Rolle 'Projektleiter' dürfen ein Projekt erstellen.");
        }
        Projekt p = new Projekt
        {
            Id = nextProjectId++,
            Name = name,
            Kunde = kunde,
            Projektleiter = projektleiter
        };
        context.Projekte.Add(p);
        return p;
    }

    public void informationHinzufügen(Projekt projekt, Information info)
    {
        projekt.Informationen.Add(info);
    }
}