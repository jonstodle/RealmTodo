# Presentasjon

### 01

* Mitt navn er Jon
* Jeg skal snakke om Realm
* Mobil database som ikke er SQLite
* Hvem har hørt om Realm?
* Brukt Realm?
* Spør spørsmål underveis

### 03

* Består av to deler
* RMD
    * Snart 3 år
    * Database for lagring på klient
* RMP
    * Halvt år
    * Kjøres på egen server
    * Endringer på klient blir pushet til server
        * Deretter fra server til klienter
    * Server med automatisk synk (tenk Firebase)

### 04

* RMD
    * Open source
    * Gratis å bruke
    * Ligger på Github
    * Wrapper-bibliotek også åpne
* RMP
    * Gratis å bruke
        * Kjøres på egen server
        * Anbefaler Digital Ocean ($5 / måned)
    * Pro for $1500 pr måned
        * Tilgang til Realm-database fra server via API
            * Ellers kun klienter via synk
            * Andre tjenester kan lese og skrive data
        * Håper på billigere I fremtiden

### 05

* For mobile platformer
* iOS, MacOS, Android, Xamarin, React Native, Win32
* UWP er planlagt
    * Ingen tidsramme

### 06

* 30 nye serverdatabaser siden 2000
* Mobildatabase er bare SQLite (2000) og Realm
* Optimalisere for moderne behov / mobil plattform

### 07

* SQLite er brukt av mange løsninger:
    * CouchDB
    * Core Data
    * Entity Framework
* Realm har egen databasemotor I C++

### 08

* Realm er ikke en relasjonsdatabase, det er en objektdatabase
    * “Tabeller” med rader og kolonner
    * En-til-en-relasjoner
    * En-til-mange-relasjoner
* Følger ACID
* Ingen forhåndsdefinering av schema
    * Baseres på klassene du ønsker å lagre
    * Henter indeksering/primærnøkkel fra klasse
    * Kommer tilbake til dette
* En kan kjøre spørringer
    * Realm bruker hver plattforms “spørresyntaks”

### 09

* Objekter er alltid oppdaterte
    * Vil alltid være identisk objekt I databasen
    * Varsling ved endring av egenskap
* Spørringer er dynamiske
    * Ved endring eller innsetting av objekt oppdateres resultatet
    * Varsling ved endring
* Integrerer med plattforms system for GUI-oppdateringer

<details>
  <summary>Spørringer</summary>
  <h4>Swift/Obj-C</h4>
  <ul>
    <li><code>NSPredicate</code>-syntaks</li>
  </ul>
  <h4>C#</h4>
  <ul>
    <li><code>IQueryable</code>-syntaks (lik Linq)</li>
  </ul>
  <h4>JavaScript</h4>
  <ul>
    <li>Bruker "chaining" av funksjoner</li>
    <li>Egne funksjoner for Realm</li>
  </ul>
  <h4>Java</h4>
  <ul>
    <li>Bruker "chaining" av funksjoner</li>
    <li>Egne funksjoner for Realm</li>
  </ul>
</details>

### 10

* Veldig høy ytelse
    * Sammenligning med SQLite og biblioteket bygget på SQLite
    * Denne tar også høyde for gjenbruk av kompilerte SQLite-spørringer
* Tell antall objekt
* Tall fra 2014 på iPad

### 11

* Antall spørringer per sekund

### 12

* Antall objekt satt inn per sekund

### 13

* Modent produkt
* Ble startet i 2011
* Offentlig slipp i 2014

# Demo

### Add RealmObjects

* `Person.cs`: Id, Name
* `Todo.cs`: Id, Name, IsDone, Assignee

### Add Realm

* `App.xaml.cs`: Add static Realm property

### Add person logic

* `AddPersonPage.xaml.cs`: Add save logic
* `MainPage.xaml.cs`: Set items source on PersonListView
* `MainPage.xaml.cs`: Add navigation to PersonPage
* `PersonPage.xaml.cs`: Add person injection, set title

### Add todo logic

* `AddTodoPage.xaml.cs`: Add person injection
* `AddTodoPage.xaml.cs`: Add save logic
* `PersonPage.xaml.cs`: Pass in person when navigating to AddTodoPage
* `PersonPage.xaml.cs`: Set items source on TodoListView
* `PersonPage.xaml.cs`: Add IsDone toggling

### Add development config

* `App.xaml.cs`: Add static constructor
* `App.xaml.cs`: Set up RealmConfiguration (ShouldDeleteIfMigrationNeeded)
* `App.xaml.cs`: Set Realm configuration

### Add property to person

* `Person.cs`: Todos IQueryable<Todo>, Backlink
* `PersonPage.xaml.cs`: Switch to using Todos property on Person

### Order by multiple props

* `PersonPage.xaml.cs`: OrderBy(IsDone).ThenBy(Name)