using Verwaltungssystem;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Verwaltungssystem.Services;

namespace TestsVerwaltungssystem;

public class Tests
{
    private DatenContext context;
    private Benutzer projektleiter;
    private Benutzer mitarbeiter;
    private Projekt projekt;
    private Information info;
    private Kommentar kommentar;

    private ProjectService projectService;
    private InformationService infoService;

    [SetUp]
    public void Setup()
    {
        context = new DatenContext();
        infoService = new InformationService();
        projectService = new ProjectService();
        

        projektleiter = new Benutzer(1, "salome", Rolle.Projektleiter);
        mitarbeiter = new Benutzer(2, "bertrand", Rolle.Mitarbeiter);
        

        projekt = projectService.erstelleProjekt("ProjektA", "chnd1", projektleiter, context);

        info = infoService.erstelleInformation(
            projekt,
            mitarbeiter,
            Informationstyp.Text,
            "das ist die Information"
        );

        kommentar = infoService.kommentarHinzufügen(
            info,
            mitarbeiter,
            "Das ist der Kommentar"
        );
    }
    
    [Test]
    public void Projektleiter_Kann_Projekt_Erstellen()
    {
        Assert.That(projekt, Is.Not.Null);
        Assert.That(projekt.Projektleiter, Is.EqualTo(projektleiter));
        Assert.That(context.Projekte, Has.Member(projekt));
    }
    
    [Test]
    public void Mitarbeiter_Darf_Kein_Projekt_Erstellen()
    {
        Assert.Throws<InvalidOperationException>(() =>
            projectService.erstelleProjekt("Test Projekt", "Test Kunde", mitarbeiter, context));
        Assert.That(context.Projekte.Count, Is.EqualTo(1));
    }

    [Test]
    public void Benutzer_Kann_Information_Erstellen()
    {
        
        Assert.That(info, Is.Not.Null);
        Assert.That(info.Inhalt, Is.EqualTo("das ist die Information"));
        Assert.That(projekt.Informationen, Has.Member(info));
    }

    [Test]
    public void Information_Darf_Maximal_Drei_Tags_Haben()
    {
        infoService.tagHinzufügen(info, Tag.Rosa);
        infoService.tagHinzufügen(info, Tag.Grün);
        infoService.tagHinzufügen(info, Tag.Gelb);

        Assert.That(
            () => infoService.tagHinzufügen(info, Tag.Rosa),
            Throws.TypeOf<InvalidOperationException>()
        );
    }
    
    [Test]
    public void Benutzer_Kann_Information_Kommentieren()
    {
        Assert.That(kommentar, Is.Not.Null);
        Assert.That(info.Kommentare, Has.Member(kommentar));
        Assert.That(kommentar.Autor, Is.EqualTo(mitarbeiter));
        Assert.That(kommentar.Text, Is.EqualTo("Das ist der Kommentar"));
    }
    
    [Test]
    public void SucheInformationenNachTag_Findet_Richtige_Information()
    {
        infoService.tagHinzufügen(info, Tag.Rosa);

        var result = context.SucheInformationenNachTag(Tag.Rosa);

        Assert.That(result, Has.Member(info));
    }
}