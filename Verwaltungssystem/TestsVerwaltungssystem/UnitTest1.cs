using Verwaltungssystem;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace TestsVerwaltungssystem;

public class Tests
{
    private Benutzer benutzer;
    private Projekt projekt;

    [SetUp]
    public void Setup()
    {
        benutzer = new Benutzer 
        { 
            BenutzerId = 1, 
            Name = "Max", 
            Rolle = Rolle.Projektleiter 
        };

        projekt = benutzer.ErstelleProjekt("Testprojekt", "Kunde XY");
    }

    [Test]
    public void Benutzer_Hat_Richtige_Id()
    {
        Assert.That(benutzer.BenutzerId, Is.EqualTo(1));
    }

    [Test]
    public void Benutzer_Kann_Information_Erstellen()
    {
        var tags = new List<Tag> { Tag.Gelb, Tag.Rosa };

        var info = benutzer.SchreibeInformation(projekt, "Projektstart geplant", tags);

        Assert.That(projekt.Informationen.Count, Is.EqualTo(1));
        Assert.That(info.Tags.Count, Is.EqualTo(2));
        Assert.That(info.Inhalt, Is.EqualTo("Projektstart geplant"));
    }

    [Test]
    public void Suche_Nach_Tag_Funktioniert()
    {
        benutzer.SchreibeInformation(projekt, "Kickoff", new List<Tag> { Tag.Gelb });
        benutzer.SchreibeInformation(projekt, "Review", new List<Tag> { Tag.Rosa });
        benutzer.SchreibeInformation(projekt, "Deployment", new List<Tag> { Tag.Gelb, Tag.Grün });

        var gelbInfos = projekt.Informationen
            .Where(i => i.Tags.Contains(Tag.Gelb))
            .ToList();

        Assert.That(gelbInfos.Count, Is.EqualTo(2));
    }
}