using Verwaltungssystem;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace TestsVerwaltungssystem;

public class Tests
{
    private DatenContext context;
    private Benutzer projektleiter;
    private Projekt projekt;
    private Benutzer mitarbeiter;

    [SetUp]
    public void Setup()
    {
        context = new DatenContext();
        
        projektleiter = new Benutzer 
        { 
            BenutzerId = 1, 
            Name = "Max", 
            Rolle = Rolle.Projektleiter 
        };
        
        mitarbeiter = new Benutzer 
        { 
            BenutzerId = 2, 
            Name = "Felix", 
            Rolle = Rolle.Mitarbeiter 
        };
        
        context.Benutzer.Add(projektleiter);
        context.Benutzer.Add(mitarbeiter);

        projekt = projektleiter.ErstelleProjekt("Testprojekt", "Kunde XY",context);
    }
    
    [Test]
    public void Projektleiter_Kann_Projekt_Erstellen()
    {
        var neuesProjekt = projektleiter.ErstelleProjekt("Neues Projekt", "Firma ABC", context);

        Assert.That(neuesProjekt, Is.Not.Null);
        Assert.That(context.Projekte.Count, Is.EqualTo(2)); 
        Assert.That(neuesProjekt.Projektleiter, Is.EqualTo(projektleiter));
    }
    
    [Test]
    public void Mitarbeiter_Darf_Kein_Projekt_Erstellen()
    {
        Assert.That(
            () => mitarbeiter.ErstelleProjekt("Verbotenes Projekt", "Firma XYZ", context),
            Throws.TypeOf<InvalidOperationException>()
        );

        Assert.That(context.Projekte.Count, Is.EqualTo(1));
    }

    [Test]
    public void Benutzer_Kann_Information_Erstellen()
    {
        var tags = new List<Tag> { Tag.Gelb, Tag.Rosa };

        var info = projektleiter.SchreibeInformation(projekt, "Projektstart geplant", tags);

        Assert.That(projekt.Informationen.Count, Is.EqualTo(1));
        Assert.That(info.Tags.Count, Is.EqualTo(2));
        Assert.That(info.Inhalt, Is.EqualTo("Projektstart geplant"));
    }

    [Test]
    public void Projektleiter_Darf_Maximal_3_Tags_Setzen()
    {
        var tags = new List<Tag> { Tag.Gelb, Tag.Rosa,Tag.Grün };

        var startCount = projekt.Informationen.Count;

        var info = projektleiter.SchreibeInformation(projekt, "Testinfo", tags);

        Assert.That(projekt.Informationen.Count, Is.EqualTo(startCount + 1));
        Assert.That(info.Tags.Count, Is.EqualTo(3));
    }
    
    [Test]
    public void Benutzer_Kann_Information_Kommentieren()
    {
        // Arrange
        var tags = new List<Tag> { Tag.Gelb };
        var info = projektleiter.SchreibeInformation(projekt, "Start geplant", tags);

        var startCount = info.Kommentare.Count;

        // Act
        var kommentar = mitarbeiter.SchreibeKommentar(info, "Bitte Agenda vorbereiten");

        // Assert
        Assert.That(info.Kommentare.Count, Is.EqualTo(startCount + 1));
        Assert.That(kommentar.Inhalt, Is.EqualTo("Bitte Agenda vorbereiten"));
        Assert.That(kommentar.Autor, Is.EqualTo(mitarbeiter));
        Assert.That(info.Kommentare, Does.Contain(kommentar));
    }
    
    [Test]
    public void Suche_Nach_Tag_Funktioniert()
    {
        projektleiter.SchreibeInformation(projekt, "Kickoff", new List<Tag> { Tag.Gelb });
        projektleiter.SchreibeInformation(projekt, "Review", new List<Tag> { Tag.Rosa });
       projektleiter.SchreibeInformation(projekt, "Deployment", new List<Tag> { Tag.Gelb, Tag.Grün });

        var gelbInfos = projekt.Informationen
            .Where(i => i.Tags.Contains(Tag.Gelb))
            .ToList();

        Assert.That(gelbInfos.Count, Is.EqualTo(2));
    }
}