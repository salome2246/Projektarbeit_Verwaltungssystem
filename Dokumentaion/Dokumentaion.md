### DOKUMENTATON PROJEKT VERWALTUNGSSYSTEM
#### im Fach Lösungsalgorithmen
#### Herbstsemester 2025-2026
#### Salome Gilgen

---


##### INHALTSVERZEICHNIS
1. [AUFGABENSTELLUNG](#PROJEKTBESCHIREB)
2. [PROJEKTBESCHIREB](#projektstruktur)
4. [ZIELSETZUNG](#services)
5. [ANALYSE](#services)
6. [TESTS](#services)
7. [DATENPERSISTENZ](#services)
8. [IMPLEMENTIERUNG](#)
8. [VORGEHEN](#services)
9. [REFLEXION](#REFLEXION)


##### AUFGABENSTELLUNG

Wir sollen die Anforderungen eines kleinen Verwaltungssystems analysieren und in ein Klassendiagramm umsetzen.  
Dieses Klassendiagramm dient als Grundlage für die Implementierung einer Konsolenapplikation in C#.  
Das Projekt umfasst zudem das Testen der Anwendung. Auch sind Dokumentation, Planung und Controlling wichtige Bestandteile der Arbeit.  
Zum Abschluss soll die Arbeit unter anderem mit der Demonstration eines Prototyps präsentiert werden.

##### PROJEKTBESCHRIEB

Die Firma Xarelto möchte ein kleines Projekt-Verwaltungssystem einführen.  
Die Projektleiterin soll Projekte erstellen können.  
Projektleiterin und Projektmitarbeiterin sollen dem Projekt Informationen hinzufügen können. (Text, Bild oder andere Dokumente).  
Die Informationen sollen jeweils mit Tags (nicht mehr als drei) versehen werden.  
Ebenfalls können Kommentare zu einer Information verfasst werden.  
Projektleiterin und Projektmitarbeiterin möchten die Informationen nach Tags durchsuchen können.  
Die Firma Xarelto ist Auftraggeberin. Interne Stakeholder sind die Projektleiterin, die Projektmitarbeitenden und die IT-Beauftrage (ich).  
Die Kunden von Xarelto sind nur indirekt betroffen und werden deswegen nicht als Stakeholder erwähnt.

[SalomeDiagramm](https://github.com/salome2246/Projektarbeit_Verwaltungssystem/blob/3fe9798e1d578b384495678cdf22231ea0d560b9/Dokumentaion/analyse/01_salomeDiagramm.png)

ANPASSUNG UND SPEZIFIZERIUNG DES PROJEKTBESCHRIEBS

- Die Anbindung (Schnittstellen) an die umliegenden Systeme sowie die Benutzer Authentifizierung sind nicht Teil des Projekts.
- Die "Information" interpretiere ich erstmals als reinen Text um, wie in meinen Zielsetzungen beschrieben, so schnell als möglich vorwärtszukommen.
- Das Attribut «Kernanforderungen» des Projekts streiche ich ebenfalls, da ich dessen Umsetzung für den Lernmehrwert als vernachlässigbar erachte.
- Löschen oder ändern der Projekte ist nicht möglich.
---

##### ZIELSETZUNG
Ich möchte das Projekt von A bis Z fertigstellen. Um dieses Ziel zu erreichen, werde ich versuchen,
das Projekt so simpel wie möglich zu halten und nur das Wesentliche umzusetzen.  
Alles, was ich ohne grössere Konsequenzen weglassen kann, wird ausgelassen. Tasks oder Anforderungen, die im ersten Schritt
nicht notwendig erscheinen, werden dokumentiert und als solche markiert (siehe GitHub Items in „LaterOrNever“).
So kann ich sie, falls noch Zeit bleibt,
zu einem späteren Zeitpunkt umsetzen.  
Dieses Vorgehen wähle ich, da sich der Zeitaufwand für mich nicht zuverlässig einschätzen lässt.  
Untenstehend gliedere ich die Unterziele in vier Kategorien:

ANALYSE  
Ich möchte die Diagramme gemäss dem roten Faden bis zum 2. März erstellt haben, um eine Basis für die Implementierung in c# zu schaffen.

TECHNISCHE UMSETZUNG  
Die grundlegenden Anforderungen (Aufgelistet im Abschnitt Anforderungen) sollen bis Projektende umgesetzt sein.  
Zusätzlich möchte ich bis Projektende eine Möglichkeit gefunden haben, die erzeugten Daten zu speichern und mindestens
zwei Unit-Tests geschrieben haben.

DOKUMENTATION  
Ich möchte mich an der Philosophie Documentation as Code orientieren.  
Nicht nur der Code, sondern auch die Dokumentation wird als .md-Datei
im GitHub-Repository verfügbar sein.  
Ausnahme bilden Diagramme, die ich farbig gestalte und daher im Tool „Freeform“ erstelle.  
Die Dokumentation soll fortlaufend geführt werden, nicht nachträglich. Sie wird immer am Ende einer Arbeitseinheit aktualisiert, damit keine Lücken oder Interpretationsfehler entstehen.

PRÄSENTATION  
Ich möchte einen Prototyp erstellen, der die implementierten Funktionen widerspiegelt.

LERNEN  
Bis zur Abgabe am 16. März möchte ich das Projekt vollständig durchgespielt haben, sodass ich aus allen Bereichen – Analyse, technische Umsetzung, Dokumentation und Präsentation – etwas lernen kann.

---

##### ANALYSE
Der folgende Abschnitt dient dazu ein besseres Verständnis des Verwaltungssystems zu bekommen.  
Als Grundlage dient der angepasste Projektbeschrieb.

KONTEXTDIAGRAMM  
Das Kontextdiagramm zeigt die vorhandenen Prozesse und Leistungen des Verwaltungssystems
sowie dessen Beziehungen zu den umliegenden Systemen.  
Das Verwaltungssystem könnte in einem späteren Schritt an ein CRM-System angebunden werden.  
Ebenfalls denkbar wäre es, für das Bereitstellen von Inhalten einen eigenen Service zu entwickeln.

[Kontextdiagramm](https://github.com/salome2246/Projektarbeit_Verwaltungssystem/blob/3fe9798e1d578b384495678cdf22231ea0d560b9/Dokumentaion/analyse/02_kontextdiagramm.png)

USE CASE DIAGRAMM  
Das Use-Case-Diagramm stellt die Anwendungsfälle dar und zeigt eine Übersicht der geplanten Prozesse im Verwaltungssystem.

[UseCaseDiagramm](https://github.com/salome2246/Projektarbeit_Verwaltungssystem/blob/3fe9798e1d578b384495678cdf22231ea0d560b9/Dokumentaion/analyse/03_useCaseDiagramm.png)

AKTIVITÄTSDIAGRAMM  
Das Aktivitätsdiagramm zeigt die zwei essenziellen Abläufe.
1.	Ein Nutzer erstellt ein Projekt mit Projektinfos. Diesem fügt er Informationen hinzu.Für die Information wählt er Tags und erstellt einen Kommentar. Das alles wird in einem Projekt gespeichert.
2.	Ein Nutzer sucht nach Tags und erhält entsprechende Suchergebnisse

Die Prozesse passieren in 3 verschieden Verantwortlichkeitsbereichen. Eine Projektanlage wo das Projekt erstellt wird und eine Projektablage,
wo das Projekt gespeichert wird. Der Benutzer stellt die Schnittstelle dar und kann die im Diagramm dargestellten Funktionen aufrufen.

[Aktivitätsdiagramm](https://github.com/salome2246/Projektarbeit_Verwaltungssystem/blob/3fe9798e1d578b384495678cdf22231ea0d560b9/Dokumentaion/analyse/03_useCaseDiagramm.png)

SEQUENZDIAGRAMM  
Das Sequenzdiagramm zeigt, wie Objekte in einem System über die Zeit miteinander interagieren.  
Daraus können später Klassen und Methoden abgleitet werden.
Es wird ersichtlich, dass Information und Kommentar vom Projekt abhängige sind und ohne dieses nicht existieren können.

[Sequenzdiagramm](https://github.com/salome2246/Projektarbeit_Verwaltungssystem/blob/3fe9798e1d578b384495678cdf22231ea0d560b9/Dokumentaion/analyse/05_sequenzdiagramm.png)

ZUSTANDSDIAGRAMM  
Ein Zustandsdiagramm beschreibt die verschiedenen Zustände eines Objekts und die Übergänge, die durch Ereignisse oder Bedingungen ausgelöst werden.  
Als zentrale Objekte definiere ich Projekt, Information und Kommentar.

[Zustandsdiagramm](https://github.com/salome2246/Projektarbeit_Verwaltungssystem/blob/3fe9798e1d578b384495678cdf22231ea0d560b9/Dokumentaion/analyse/06_zustandsdiagramm.png)

AUFBAU INFORMATION  
Das Objekt "Information" verlangte nach einer genaueren Untersuchung.  
Drei möglich Varianten untersuche ich genauer.

[InformationVarianten](https://github.com/salome2246/Projektarbeit_Verwaltungssystem/blob/3fe9798e1d578b384495678cdf22231ea0d560b9/Dokumentaion/analyse/informationVarainte.pdf)

---

ANFORDERUNGEN  
Aus dem angepassten Projektbeschrieb, dem Usecase Diagramm und dem Dokument [Anforderungsanalyse](https://github.com/salome2246/Projektarbeit_Verwaltungssystem/blob/3fe9798e1d578b384495678cdf22231ea0d560b9/Dokumentaion/analyse/Anforderungsanalyse.pdf) leite ich folgende grundlegende Anforderungen ab:
-  Projektleiter (PL) kann ein Projekt erstellen.
-  Benutzer können eine Information erstellen, die immer einem Projekt zugeordnet sein muss
-  Benutzer müssen die Information mit 1–3 Tags versehen.
-  Benutzer können die Information kommentieren.
-  Benutzer können Informationen eines Projekts nach Tags durchsuchen.

---

#### TESTS
Basierend auf den fünf Grundanforderungen entsteht die [Testplanung](https://github.com/salome2246/Projektarbeit_Verwaltungssystem/blob/3fe9798e1d578b384495678cdf22231ea0d560b9/Dokumentaion/test/Testplanung.pdf).
Um die Applikation auf die grundlegenden Funktionen zu überprüfen, werden die sechs Testfälle in NUnit Tests übersetzt.

---

#### DATENPERSISTENZ
Um die Daten zu speichern, entscheide ich mich dafür, JSON-Dateien zu verwenden, da wir das bereits im Unterricht
behandelt haben.  
Zur Struktur der Datenablage habe ich mehrere Möglichkeiten analysiert.  
Vor- und Nachteile, sowie deren Einfluss auf die Effizienz der geplanten Suchfunktion, sind in folgendem Dokument festgehalten:

[PersistenzVarainten](https://github.com/salome2246/Projektarbeit_Verwaltungssystem/blob/3fe9798e1d578b384495678cdf22231ea0d560b9/Dokumentaion/persistenz/persistenzVarainten.pdf)

Auf Basis dieser Analyse entscheide ich mich für Variante 2, 
da sie für die projektbezogenen Anforderungen (die Suche innerhalb einzelner Projekte und kleine Datenmengen)
am besten geeignet ist.

---

#### IMPLEMENTIERUNG

BASICVERSION 101

In einem ersten Schritt wurde eine minimale Version der Anwendung implementiert [BasicVersion 1.0.1](https://github.com/salome2246/Projektarbeit_Verwaltungssystem/tags)

Die Implementierung basiert auf dem folgenden Klassendiagramm, das aus der Analyse in Kapitel zwei hervorgegangen ist.

[KlassendiagrammBasicVarainte](https://github.com/salome2246/Projektarbeit_Verwaltungssystem/blob/3fe9798e1d578b384495678cdf22231ea0d560b9/Dokumentaion/klassendiagramm/KDBasicVariante.mmd)

ADVANCEDVERSION 201

In einem zweiten Schritt wurde eine erweiterte Version implementiert [AdvancedVersion 2.0.2]()

Mit folgenden Anpassungen:

-Das Objekt Information wurde erweitert und ist neu nach Varainte ... aufgebaut
-Die Klassen wurden für eine bessere Übersicht in Module Services unterteilt.

[KlassendiagrammAdvancedVarainte](https://github.com/salome2246/Projektarbeit_Verwaltungssystem/blob/3fe9798e1d578b384495678cdf22231ea0d560b9/Dokumentaion/klassendiagramm/KDAdvancedVarainte.mmd)

---
#### Prototyp

Ein Prototyp der Applikation findet sich unter folgendem Link:

[Protptyp](https://example.com)

#### VORGEHEN

---
#### REFLEXION