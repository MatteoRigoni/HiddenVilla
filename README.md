# HiddenVilla

> Sample project per la gestione di camere e prenotazioni di un hotel, costruito con stack .NET e Blazor.

## Indice
- [Panoramica](#panoramica)
- [Architettura & Struttura soluzione](#architettura--struttura-soluzione)
- [Prerequisiti](#prerequisiti)
- [Setup locale (quick start)](#setup-locale-quick-start)
- [Configurazione](#configurazione)
- [Comandi utili](#comandi-utili)
- [Roadmap / TODO](#roadmap--todo)
- [Contribuire](#contribuire)
- [Licenza](#licenza)

---

## Panoramica

HiddenVilla è un progetto didattico focalizzato sulla gestione di camere e prenotazioni. L’obiettivo è mostrare un’architettura a livelli con separazione tra modelli, accesso ai dati, logica applicativa, API e front‑end Blazor.

## Architettura & Struttura soluzione

La soluzione (`HiddenVilla.sln`) è suddivisa in più progetti/librerie:

- **Models/** – Entità e DTO condivisi tra i layer.
- **Common/** – Costanti, helper e utilità comuni.
- **DataAccess/** – Accesso ai dati (es. DbContext, repository, unit of work).
- **Business/** – Servizi applicativi e logica di dominio.
- **HIddenVilla_API/** – ASP.NET Core Web API che espone gli endpoint per il front‑end.
- **HiddenVilla_Client/** – Front‑end Blazor (client) per la UI.
- **HiddenVilla_Server/** – Host lato server (es. configurazione, pipeline, asset statici o eventuale Blazor Server).

> N.B. Alcuni dettagli (versione .NET, provider DB, autenticazione) possono variare: personalizza questa sezione in base ai `.csproj` e agli `appsettings.json` del tuo ambiente.

## Prerequisiti

- **.NET SDK** 7 o 8 (verifica il `TargetFramework` nei `.csproj`).
- **Provider DB**: SQL Server / PostgreSQL / SQLite (scegline uno e aggiorna le stringhe di connessione).
- **EF Core Tools** (se usi migrazioni):  
  ```bash
  dotnet tool install --global dotnet-ef
