namespace Verwaltungssystem;

class Program
{
    static void Main(string[] args)
    {
        Benutzer benutzer1 = new Benutzer(1,"Salome",Rolle.Projektleiter);
        benutzer1.ProjektErstellen(1, "erstesProjekt");
        benutzer1.ProjekteAusgeben();
        
        
    }
    
    
}