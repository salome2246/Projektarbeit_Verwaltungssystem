namespace Verwaltungssystem;

public class Benutzer
{
    public int id;
    private string name;
    private Rolle rolle;
    public List<Projekt> Projekte { get; set; } = new List<Projekt>();

    public Benutzer(int id, string name, Rolle rolle)
    {
        this.id = id;
        this.name = name;
        this.rolle = rolle;
    }

    public Projekt ProjektErstellen(int projektId, string name)
    {
        // Prüfung: darf der Benutzer ein Projekt erstellen?
        if (rolle != Rolle.Projektleiter)
        {
            throw new InvalidOperationException(
                "Nur Projektleiter dürfen Projekte erstellen.");
        }

        Projekt neuesProjekt = new Projekt
        {
            Id = projektId,
            Name = name,
            Projektleiter = this,
            
        };
        
        Projekte.Add(neuesProjekt);
        return neuesProjekt;
    }

    public void ProjekteAusgeben()
    {
        foreach (Projekt projekt in Projekte)
        {
            Console.WriteLine(projekt.Name);
        }
    }

    public Information InformationErstellen() //projekt ID mitgeben
    {
        Information neueInfo = new Information(); //(projektID oder Name)
        return  neueInfo ;
    }
    
    
    
}
