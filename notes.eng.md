# Presentasjon

### 01

* My name's Jon
* I'm going to talk about Realm
* Mobile database that isn't SQLite
* Who's heard about Realm?
* Used Realm?
* Ask questions as we go along

### 03

* Consists of two parts
* RMD
    * Amost 3 years
    * Local database on client
* RMP
    * 6 months
    * Runs on a separate server
    * Changes on client is pushed to server
        * Then from server to clients
    * Server sync is automatic (think Firebase)

### 04

* RMD
    * Open source
    * Free to use
    * Hosted on Github
    * Wrapper libraries also open source
* RMP
    * Free to use
        * Runs on separate server
        * Recommends Digital Ocean ($5 / month)
    * Pro for $1500/month
        * Access to Realm database through API
            * Else only sync with clients
            * Other services can read and write
        * Aiming for cheaper prices in future

### 05

* For mobile platforms
* iOS, MacOS, Android, Xamarin, React Native, Win32
* UWP on the way and soon to be released

### 06

* 30 new server databases since 2000
* Mobile databases are SQLite (2000) and Realm
* Optimalized for modern need / mobile platform

### 07

* SQLite is used by many solutions:
    * CouchDB
    * Core Data
    * Entity Framework
* Realm has it's own engine in C++

### 08

* Realm is not a relational database, but an object database
    * "Tables" with rows and columns
    * One-to-one relations
    * One-to-many relations
* ACID compliant
* No defining of schema
    * Based on the classes you wish to store
    * Gets indexing and primary key from classes
    * More on this later
* Queries are supported
    * Realm uses the native query syntax (where available)

### 09

* Objects are always up-to-date
    * Will always be identical to objects in the database
    * Notifications when properties are changed
* Queries are dynamic
    * Result changes when objects are changed or inserted
    * Notifcations when changes occur
* Integrates with native GUI updates

<details>
  <summary>Queries</summary>
  <h4>Swift/Obj-C</h4>
  <ul>
    <li><code>NSPredicate</code> syntax</li>
  </ul>
  <h4>C#</h4>
  <ul>
    <li><code>IQueryable</code> syntax (identical to Linq)</li>
  </ul>
  <h4>JavaScript</h4>
  <ul>
    <li>Chaining of functions</li>
    <li>Custom for Realm</li>
  </ul>
  <h4>Java</h4>
  <ul>
    <li>Chaining of functions</li>
    <li>Custom for Realm</li>
  </ul>
</details>

### 10

* Very high performance
    * Comparison with SQLite and libraries built on SQLite
    * Takes query compilation into account
* Count objects
* Tested on iPad in 2014

### 11

* Queries per second

### 12

* Inserts per second

### 13

* Mature product
* Founded in 2011
* Public release in 2014

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