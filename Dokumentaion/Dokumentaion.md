### DOKUMENTATON PROJEKT VERWALTUNGSSYSTEM
#### im Fach Lösungsalgorithmen
#### Herbstsemester 2025-2026
#### Salome Gilgen

---


##### INHALTSVERZEICHNIS
1. [AUFGABENSTELLUNG](#aufgabenstellung)
2. [PROJEKTBESCHIREB](#projektbeschrieb)
4. [ZIELSETZUNG](#zielsetzung)
5. [ANALYSE](#analyse)
6. [TESTS](#tests)
7. [DATENPERSISTENZ](#datenpersistenz)
8. [IMPLEMENTIERUNG](#implementierung)
8. [VORGEHEN](#vorgehen)
9. [REFLEXION](#reflexion)


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
- Projekte zu löschen oder ändern ist vorerst nicht möglich.
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

[PersistenzVarianten](https://github.com/salome2246/Projektarbeit_Verwaltungssystem/blob/3fe9798e1d578b384495678cdf22231ea0d560b9/Dokumentaion/persistenz/persistenzVarainten.pdf)

Auf Basis dieser Analyse entscheide ich mich für Variante 2, 
da sie für die projektbezogenen Anforderungen (die Suche innerhalb einzelner Projekte und kleine Datenmengen)
am besten geeignet ist.

---

#### IMPLEMENTIERUNG

BASICVERSION 101

In einem ersten Schritt wurde eine minimale Version der Anwendung implementiert [BasicVersion 1.0.1](https://github.com/salome2246/Projektarbeit_Verwaltungssystem/tags)

Die Implementierung basiert auf dem folgenden Klassendiagramm, das aus der Analyse in Kapitel vier hervorgegangen ist.

[KlassendiagrammBasicVarainte](https://github.com/salome2246/Projektarbeit_Verwaltungssystem/blob/3fe9798e1d578b384495678cdf22231ea0d560b9/Dokumentaion/klassendiagramm/KDBasicVariante.mmd)

ADVANCEDVERSION 201

In einem zweiten Schritt wurde eine erweiterte Version implementiert [AdvancedVersion 2.0.2]()

Mit folgenden Anpassungen:

- Das Objekt Information wurde um einen "Informationstyp" erweitert. 
- Ein InformationsService und ein ProjektService übernehmen neu das Erstellen von Projekt und Infos.
- Die Klassen wurden für eine bessere Übersicht in Module und Services unterteilt.

[KlassendiagrammAdvancedVarainte](https://github.com/salome2246/Projektarbeit_Verwaltungssystem/blob/3fe9798e1d578b384495678cdf22231ea0d560b9/Dokumentaion/klassendiagramm/KDAdvancedVarainte.mmd)

---
#### UI-Visualisierung

Eine UI- Visualiserung der Applikation findet sich unter folgendem Link:

[UIVisualisierung](https://example.com)

---

#### VORGEHEN
Grob lässt sich das Vorgehen in drei Phasen beschreiben:

Phase 01 – Experimentierphase

Phase 02 – Überarbeitungs- und Anpassungsphase

Phase 03 - Clear to Chaotic

Die Abschnitte wurden entsprechend in 01, 02 und 03 unterteilt.

SETUP  
01: Ich setze das Projekt auf GitHub auf. Im Bereich Projects erfasse ich alle Tasks, die sich aus der Aufgabestellung, den Zielsetzungen und den Bewertungskriterien ergeben.

Jeden Task versehe ich mit folgenden Angaben:

Status: To Do, In Progress, Done, LaterOrNever, Fragen

Organisation: Analyse, Dokumentation, Code, Präsentation

Zeitaufwand: Aufgewendete Zeit für den jeweilgen Task.

Als Entwicklungsumgebung entscheide ich mich für Rider, da ich damit bereits vertraut bin und die IDE mich gut unterstützt.


ANALYSE  
01: Ich versuche, die Projektbeschreibung so einfach wie möglich zu interpretieren, da meine Erfahrung noch sehr begrenzt ist und ich den Zeitaufwand nur schwer abschätzen kann.
Die Aufgabenstellung übersetze ich in ein Salome Diagramm. Dadurch kann ich den Inhalt ohne formale Vorschriften grafisch darstellen. Das hilft mir, den Sachverhalt besser zu verstehen und einen ersten Überblick zu gewinnen. Wichtig ist mir dabei, alle relevanten Informationen aus dem Text zu übernehmen, damit nichts vergessen wird.

Darauf aufbauend entwickle ich die Analysediagramme nach dem Roten Faden, um das Verwaltungssystem aus allen Blickwinkeln zu beleuchten. Das Klassendiagramm erstelle ich zunächst nur rudimentär, da ich möglichst schnell in die Umsetzung gehen möchte, um zu prüfen, ob sich meine theoretischen Überlegungen auch praktisch implementieren lassen.

02: Bei der Umsetzung stelle ich fest, dass noch einige Unklarheiten bestehen.
Ich untersuche den Aufbau der „Information“ genauer und überlege, welche Struktur sich für die Speicherung meiner Daten eignet.
Zudem gliedere ich den Code in Modelle, Enums sowie in einen ProjektService und einen InformationsService, die jeweils für die entsprechenden Funktionen zuständig sind. Das erscheint mir insgesamt übersichtlicher.

UMSETZUNG

01: Im ersten Schritt arbeite ich experimentell. Ich erstelle die Klassen, die sich aus dem Klassendiagramm ableiten lassen, und beginne mit den rudimentären Funktionen, die ich zuvor in der Analyse identifiziert habe.

Zunächst nutze ich Konsolenausgaben, um den Code zu überprüfen. Danach entscheide ich mich, Unit-Tests zu implementieren, die die Kontrolle über die Funktionsweise übernehmen. Die einzelnen Teile des Codes lasse ich von KI generieren. Die Datenspeicherung berücksichtige ich zunächst leider überhaupt nicht.

Schnell stelle ich fest, dass ich einige Punkte genauer betrachten muss:

- Unit-Tests

- Struktur der Datenspeicherung

- Aufbau der Informationen

- Gesamtstruktur des Programms

Ich gehe in die Recherche und versuche die verschieden Themen zu klären.

02: Basierend auf den Erkenntnissen meiner Recherchen erstelle ich ein zweites Klassendiagramm und strukturiere meinen Code neu. Ebenfalls implementiere ich eine Suchfunktion. Als Ergänzung lasse ich ein kleines Konsolenprogramm generieren über das die Grundlegenden Funktionen gesteuert werden können.

03: Ich möchte das kleine Konsolenprogramm durch manuell erstellte Objekte ersetzen, da ich das für ein weiteres Arbeiten, für übersichtlicher halte.
Leider vergesse ich vorher zu committen, versuche die Logik der Services nochmals anzupassen und stelle fest, dass Informationen doppelt gespeichert werden. Ich wechsle von einer Anpassung zur anderen und lande schliesslich im Chaos.
Nachdem ich das Gröbste behoben habe, entscheide ich mich, das Projekt vorerst so stehen zu lassen – auch wenn noch viele Fragen offen sind.

---
#### REFLEXION

ZIELERREICHUNG:  
Analyse: Ich konnte die benötigten Diagramme umsetzen. Das anfangs etwas parallele stattfinden von Analyse und Umsetzung empfand ich dabei als hilfreich.

Technische Umsetzung: Ich konnte die grundlegenden Anforderungen umsetzen und diese auch mittels Tests überprüfen. Die Daten können in einer JSON-Datei gespeichert werden. Gleichzeitig bin ich mir bewusst, dass noch viele Funktionen fehlen, die für ein wirkliches Funktionieren der Applikation notwendig wären.

Dokumentation: Das fortlaufende Führen der Dokumentation ist zeitweise etwas auf der Strecke geblieben. Documentation as Code konnte ich im Endeffekt zwar so umsetzten, hat aber nur so mässig gut funktioniert. Da die Dokumentationsdatei für mich ein Arbeitstool ist, das ich immer wieder überarbeite, ist ein Word-Dokument mit seinen erweiterten Textbearbeitungsmöglichkeiten letztlich praktischer.

Präsentation: Da es zeitlich nicht gereicht hat, mich in ein Prototyping-Tool einzuarbeiten, habe ich mich entschieden, mich auf die Visualisierung des UI zu beschränken. Dies hat mir dennoch geholfen, die Anforderungen noch einmal zu überprüfen.

Lernen: Ich konnte in jedem Bereich etwas dazulernen. Im Bereich der Dokumentation konnte ich meine persönliche Best Practice weiterentwickeln und GitHub Projects besser kennenlernen.  
Während der Analyse und Umsetzung fand ich vor allem die Fragen rund um Design und Architektur spannend: Welche Beziehungen sind sinnvoll? Was gehört logisch zusammen? Gerade auch im Bezug auf wie die Daten persistiert werden.
In diese Themen wäre ich gerne noch tiefer eingetaucht.
Leider kam das Recherchieren aufgrund des Aufwands für die Dokumentation und einiger technischer Schwierigkeiten etwas zu kurz.

Abschliessend möchte ich festhalten, dass ich einfach noch zu wenig weiss und ich deshalb über viele grundlegende Dinge gestolpert bin. (Probleme mit Git, zu spät verstanden, dass ich bei Unittests der Datenspeicher natürlich nicht mittesten muss etc) Dies hat mich teilweise viel Zeit gekostet.

Durch den Zeitdruck war ich zudem etwas hin- und hergerissen zwischen Ausprobieren, Lernen und dem möglichst effizienten Erreichen der Projektziele. Rückblickend wäre es auch hilfreich gewesen, früher mit der Arbeit zu beginnen, damit ich mir rechtzeitig Unterstützung hätte holen können.


Ausblick:
-Die Suchfunktion müsste nochmals genauer angeschaut werden. Im Datenkontext file ist die Suchfunktion wohl auch nicht am richtigen Ort.
-Andere Grundlegende Funktionen, wie das Löschen oder Ändern von Projekte müsste implementiert werden.
-Grundsätzlich müsste die Struktur nochmals überdacht werden, ob das mit den zwei Services wirklich eine gute Idee war.

