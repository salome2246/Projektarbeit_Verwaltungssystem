**Tabelle: Benutzer**

- BenutzerId (PK)

- Name

- Rolle

**Tabelle: Projekt**

- ProjektId (PK)

- Name

- Kunde

- ProjektleiterId (FK → Benutzer)

**Tabelle: Information**

- InfoId (PK)

- Inhalt

ProjektId (FK → Projekt)

**Tabelle: Kommentar**

- KommentarId (PK)

**Inhalt**

- InfoId (FK → Information)

- AutorId (FK → Benutzer)

**Tabelle: InformationTag (Many-to-Many)**

- InfoId (FK)

- Tag