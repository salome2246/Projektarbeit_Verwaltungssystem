
## Interpretation der Aufgabenstellung:

**Aufgabenstellung**
Wir sollen die Anforderungen eines kleinen Verwaltungssystems analysieren und in ein Klassendiagramm umsetzen. Dieses Klassendiagramm dient als Grundlage für die Implementierung einer Konsolenapplikation in C#.

Das Projekt umfasst zudem das Testen der Anwendung.
Dokumentation, Planung und Controlling sind wichtige Bestandteile der Arbeit.

Zum Abschluss soll die Arbeit unter anderem mit der Demonstration eines Prototyps präsentiert werden.

**Verständis des Verwaltungssystem**
Ich übersetzte die Aufgabenstellung in ein Salome-Diagramm.
Dies erlaubt mir, den Inhalt ohne formelle Vorschriften in eine grafische Umsetztung zu bringen. 
Dies erleichtert es mir den Sachverhalt zu verstehen und einen ersten Überblick zu erhalten. 
Wichitg ist mir dabei alle relevanten Informationen aus dem Text zu übernehmen, sodass nichts vergessen geht. Als Stakeholder halte ich die Firma Xarelto als Auftraggeber fest.
(Interne Stakholder sind der Projektleiter die Projektmitarbeitenden
und die IT Beauftrage (ich)). Die Kunden von Xarelto sind nur indirekt betroffen. deswegen werden sie explizit als nicht als Stakeholder erwähnt.
Daraus entwickle ich in der Analyse die weiteren Diagramme nach dem *Roten Faden*.

LINK SALOME-Diagramm

**Anpassung der Augfgabestelelung / SCOPE** --> oder einfach github tasks

-Die Anbindung (Schnittstellen) an die umliegende Systeme sowie die Authentification sind nicht im Scope des Projekts.
-Ebenfalls interpretiere ich die "Information" erstmals als reinen text um wie in meinen Zielsetzungne so schnell wie möglich vorwärts zu kommen. Wenn Zeit übrigbleibt möchte ich mich gerne mit dem Ding Inforamtion und dessen enbinsugn und Architektur auseinandersetzten.

-

## Zielsetzung

Ich möchte das Projekt von A-Z fertigstellen. Damit ich das erreichen kann werde ich versuchen das Projekt so simpel wie möglich zu halten und nur das Wichtigste umzusetzten. Alles was ich ohne grössere Konsequenzen weglassen kann, werde ich 
weglassen. Tasks, Anforderunge, die es zu erledigen gäbe, die ich aber im ersten schritt nicht für notwenig errachte 
werden festgehalten und als solche markeiert.( siehe Github Items in "LaterOrNever")
So könnte ich sie, falls noch zeit bleibt, zu einem späteren Zeitpunkt umsetzten. Diese Vorgehen wähle ich weil sich für mich  der Zeitaufwand nicht wirklich einschätzen lässt.


Untenstehend gliedere ich die Unterziele in 4 Kategoriern:

**Analyse**
Ich möchte die Diagramme entsprechend dem Roten Faden bis zum 2. März erstellt haben, um die Aufgabenstellung analysieren zu können und eine Basis für die Implementierung mit c# zu haben.

**technische Umsetung**

Ich möchte folgende grundlegende Anforderungen bis Projektende umgestzt haben:

PL kann ein Projekt erstellen. (Kernanforderungen streiche ich)
PM darf kein Projekt erstellen
Benutzer können eine Information erstellen. (muss immer zu einem Projekt gehören, info sit erstmals nur string)
Benutzer  müssen die Inormation  mit 1-3 Tags versehen.
Benutzer können die Information kommentieren. 
Benutzer können die Inforamtionen nach Tags durchsuchen.

Ausserdem möchte ich bis zu Projektende eine Datenbank implementiert haben

Ich möchte mindesten 2 Unittest geschrieben haben.

**Dokmentation**  
- Für die Dokumentation möchte ich mich an der Philosophie Documentation as Code orentieren.
Nicht nur der Code sondern auch die Dokumentaion soll als md file in dem Github Repository zu finden sein. Ausgenommen davon sind die Diagramme, die ich beforzuge mit Farbe zu gestalten und desewgen auf das Tool "freeform" zurückgreifen werde.
Durch diese Vorgehnen sind alle Unterlagen an einem Ort zu finden und wird mir Zeit sparen.

- Ich möchte die Dokumentation fortlaufend führen , nicht nachträglich.(immer am Ende einer Arbeitseinheit)  Damit diese nicht durch nachträgliche Interpretation oder Lücken verzehrrt wird.

**Präsentation**

Ich möchte einen Prototyp erstellten der die Implementierten Funktion wiederspigelt.


**Lernen**
Ich möchte bis zur Abgabe am 16. März das ganze Projekt entsprechnd emienr Zielsetzugnen durchgesielt habe, sodass cih  aus allen Bereichen (Analyse, Technische Umsetzung, Dokumentation und Präsentation) etwas lernen kann.



# Vorgehen / Prozess:
## SetUp
Febraur
Ich setzte das Projekt in github auf. In Projects erfasse ich alle aus der Aufgabestellung den Zielsetzungen und Bewertungskriterien herforgehenden Tasks. 
Jeden Task versehe ich mit Status (to to, in Progress, done, laterOrNever, Fragen), Organisation (Analyse, Doku, Code, Präsentation) und Zeit. 
Als Entweicklungsumgebeung entscheide ich mich für Riders, da ich diese bereitss kenne und mich gut unterstützt.


## Analyse
Februar
Aus dem Salome-Diagramm entwickle ich die Analysediagramme nach dem *Roten Faden*
So kann ich die Aufgabe von allen Seiten beleuchten.
Das Klassendiagramm fertige ich nur rudimentär an, da ich so schnell wie möglich ins coden kommen möchte. Um zu prüfen ob isch meine theoretischen Gedanken in der Praxis auch implementieren lassen.



## Codeeee

Februar
Ich erstelle die aus dem Klassendagramm abgeleiteten Klassen. Ich möchte als erstes die ganz rudimentären funktionen bauen. Einen User erstellen, der ein Projekt hinzufügen kann.

Um den code zu überprüfen arbeite ich mit consolen ausgaben.

Sollte ich die anforderungen in **Unit tests** schreieben. ICh denke ja.
X Benuter ID automatisch erstellen

März
Ich muss mich nach einer Pause wieder einarbeiten und überprüfe nochmals die aufgabenstellung. Nach der wilden rumprobier phase muss ich aus zeitlichen gründen etwwas zielorienterter arbeiten. 
Die überarbeitetn BASIC Anforderunge iwll ich alle mit einem Unit test festhalten. In dem Testpaln halt ich fest welcher test welche anforderung auf ewelche weise überrüft

ICh übernehme das überarbeite Klassendiagramm und übersetzte es mit hilfe von Chat GPT in c# code.

## Test
Ich schriebe für die 6 abgeleiteten Basic anforderungen eine Testplan daruas implementiere ich 6 Nunittest.


## Anforderungen 

Februar
Anforderunganalyse mti chatgpt erstellt. 

Februar late
Anfoderungen in Primär und sekundär unterteilt um meinem Ziel so einfach wei möglich, dafür fertig treu zu bleibed rei davon in units test festgehalten

März
Nach einer Pause muss ich mich nochmals neu einfinde. Ich überarbeite die Anforderungen nochmals. und einge mich auf deise:

PL kann ein Projekt erstellen. (Kernanforderungen streiche ich)
PM darf kein Projekt erstellen
Benutzer können eine Information erstellen. (muss immer zu einem Projekt gehören, info sit erstmals nur string)
Benutzer  müssen die Inormation  mit 1-3 Tags versehen.
Benutzer können die Information kommentieren. 
Benutzer können die Inforamtionen nach Tags durchsuchen.


##Prototyp

März
Sinhaftigkeit kann in Fragegestellt werden, aber auch nicht inmeiner Zielsetzung
Mehr zu analyse zwecjen gedacht als was es sein könnte.

## Iteratives arbeiten

Fertig rum gepröbelt jetz wird vorwärtsgemacht: Ich überarbetei die anforderungen ans programm nochmals, nur nötigstes.

Unittest aktuallisern und testplan erstllen


## Domainmodeling
März
Das im Febrrar sehr rudimenr erstellte Klassendiagramm überarbeite ich nachdem ich dei Anforderungen nochmals geklärt habe.
ich übernehme alle Bestandteile des Salomediagramm und übersetzte die 5 basic definierten Anforderunge in methoden.


## Datenbank

März
Ich habe den Gedanken an die persistene Datensicherung etwas verdrängt und muss diese nun nachholen, nachdem das consolen programm einigermassen läuft.

ich entscheide mih für jason da schon mal gemacht.

Ich ersuch herauszufinden eine Art datenschema zu erstellen. **Learnings**


wieso tag eigene tabelle und rolle nciht. Many to many
Chatgpt schlägt vor benuter im projekt zu speichern. iche ntscheide mich aus architektonischen gründen für eine benutzer un ein projekt repository.
projetk speichern kommt in dide punktion projekt erstellen
benutzer nich in konstruktor!

03.
ich entscheid mich das ding information nochmas genauer anzuschaen und die architektur zu hinterfragen.dies führ dazu dass ich den code nochmals neu baue 


## Fragen


**Unit tests**
**private / public dinger**
 
## Learnings
##Reflexion