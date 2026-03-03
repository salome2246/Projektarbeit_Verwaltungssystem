using Verwaltungssystem;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace TestsVerwaltungssystem
{
    [TestFixture]
    public class Tests
    {
        private Benutzer benutzer;
        private Projekt projekt;
        
        [SetUp]
        public void Setup()
        {
            // Benutzer und Projekt einmal pro Test vorbereiten
            benutzer = new Benutzer { BenutzerId = 1, Name = "Max", Rolle = Rolle.Projektleiter };
            projekt = benutzer.ErstelleProjekt("Testprojekt", "Kunde XY");
        }

        [Test]
        public void Benutzer_Hat_Richtige_Id()
        {
            // Prüft die ID des Benutzers aus Setup
            Assert.AreEqual(1, benutzer.BenutzerId, "Benutzer-ID stimmt nicht.");
        }

        [Test]
        public void Benutzer_Kann_Information_Erstellen()
        {
            // Tags für die Information
            List<Tag> tags = new List<Tag> { Tag.Gelb, Tag.Rosa };

            // Benutzer fügt Information zum Projekt hinzu
            Information info = benutzer.SchreibeInformation(projekt, "Projektstart geplant", tags);

            // Prüfen, dass die Information im Projekt ist
            Assert.IsTrue(projekt.Informationen.Contains(info), "Information wurde nicht dem Projekt hinzugefügt.");
            // Prüfen Anzahl der Tags
            Assert.AreEqual(2, info.Tags.Count, "Die Anzahl der Tags stimmt nicht.");
            // Prüfen Inhalt der Information
            Assert.AreEqual("Projektstart geplant", info.Inhalt, "Inhalt der Information stimmt nicht.");
        }

        [Test]
        public void Suche_Nach_Tag_Funktioniert()
        {
            // Informationen mit verschiedenen Tags erstellen
            Information info1 = benutzer.SchreibeInformation(projekt, "Kickoff", new List<Tag> { Tag.Gelb });
            Information info2 = benutzer.SchreibeInformation(projekt, "Review", new List<Tag> { Tag.Rosa });
            Information info3 = benutzer.SchreibeInformation(projekt, "Deployment", new List<Tag> { Tag.Gelb, Tag.Grün });

            // Suche nach allen Informationen mit Tag.Gelb
            var gelbInfos = projekt.Informationen.Where(i => i.Tags.Contains(Tag.Gelb)).ToList();

            // Prüfen, dass genau 2 Informationen gefunden wurden
            Assert.AreEqual(2, gelbInfos.Count, "Es sollten genau 2 Informationen mit Tag Gelb gefunden werden.");
            // Prüfen, dass info1 und info3 in der Liste sind
            Assert.IsTrue(gelbInfos.Contains(info1), "info1 sollte in der Liste sein.");
            Assert.IsTrue(gelbInfos.Contains(info3), "info3 sollte in der Liste sein.");
        }
    }
}