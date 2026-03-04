# Setup Guide

## Prerequisites

| Requirement | Minimum Version |
|---|---|
| Visual Studio | 2022 (v17.x) or later |
| .NET SDK | 10.0 |
| Windows | Windows 10 or later (WinForms requires Windows) |

---

## NuGet Packages

These are declared in the `.vbproj` and are restored automatically on build:

| Package | Version | Purpose |
|---|---|---|
| `Microsoft.Data.Sqlite` | 9.0.5 | Managed SQLite ADO.NET driver |
| `SQLitePCLRaw.bundle_e_sqlite3` | 3.0.2 | Native `e_sqlite3.dll` provider (required by `Microsoft.Data.Sqlite`) |

> **Important:** `SQLitePCLRaw.bundle_e_sqlite3` must be present in your project references.  
> Without it, the app throws `DllNotFoundException: Unable to load DLL 'e_sqlite3'` at startup.  
> If you ever see that error, run `dotnet restore` or use **Tools → NuGet Package Manager → Restore** in Visual Studio.

---

## Build & Run

### Visual Studio

1. Open `CROP DISEASE MONITORIN SYSTEM.slnx`
2. Wait for NuGet restore to complete (status bar at the bottom)
3. Press **F5** (Debug) or **Ctrl+F5** (Run without debugger)

### Command Line

```powershell
cd "CROP DISEASE MONITORIN SYSTEM"
dotnet restore
dotnet run
```

---

## Database

- The SQLite database file `cropdisease.db` is created automatically in the working directory on first run.
- No manual setup is needed — `DatabaseHelper.InitializeDatabase()` runs on `LoginForm_Load` and creates all tables with `CREATE TABLE IF NOT EXISTS`.
- The database file is excluded from source control via `.gitignore` (`*.db` is matched by the `*.dbmdl` / binary exclusion patterns — add `*.db` explicitly if needed).

---

## First-Time Use

1. Run the application.
2. Click **Register** on the login screen to create your first account.
3. Password must be **at least 6 characters**.
4. Log in with your new credentials.
