using Verwaltungssystem;

namespace TestsVerwaltungssystem;

public class Tests
{
    private Benutzer _projektleiter;
    private Benutzer _mitarbeiter;
    private Projekt _projekt;
    [SetUp]
    public void Setup()
    {
        _projektleiter = new Benutzer(1,"salome",Rolle.Projektleiter);
        _mitarbeiter = new Benutzer(2,"bertrand",Rolle.Mitarbeiter);
        _projekt = new Projekt();
    }

    [Test]
    public void Benutzer_Hat_Richtige_Id()
    {
        Assert.That(_projektleiter.id, Is.EqualTo(1));
    }
    
    [Test]
    public void Benutzer_Kann_Information_Erstellen()
    {
        var info = new Information("Test", new List<string>());
        _projekt.AddInformation(info);

        Assert.That(_projekt.Informationen.Contains(info), Is.True);
    }
    [Test]
    public void Suche_Nach_Tag_Funktioniert()
    {
        var info = new Information("Analyse", new List<string> { "Analyse" });
        _projekt.AddInformation(info);

        var result = _projekt.SucheNachTag("Analyse");

        Assert.That(result.Count(), Is.EqualTo(1));
    }
}