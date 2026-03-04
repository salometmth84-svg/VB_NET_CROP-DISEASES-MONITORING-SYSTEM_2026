# Crop Disease Monitoring System

A Windows Forms desktop application built with **VB.NET (.NET 10)** that allows farmers and agricultural staff to track crop registrations and record disease outbreaks with severity ratings.

---

## Features

| Feature | Description |
|---|---|
| User authentication | Register and log in with hashed passwords |
| Crop management | Add crops and associate them with a farmer |
| Disease recording | Log diseases per crop with symptoms, severity, and date |
| Disease viewer | View all recorded disease entries in a searchable grid |

---

## Tech Stack

| Layer | Technology |
|---|---|
| Language | VB.NET |
| Framework | .NET 10, Windows Forms |
| Database | SQLite via `Microsoft.Data.Sqlite` 9.0.5 |
| Native SQLite | `SQLitePCLRaw.bundle_e_sqlite3` 3.0.2 |

---

## Getting Started

See [`docs/setup.md`](docs/setup.md) for full setup and run instructions.

Quick start:

```
1. Open "CROP DISEASE MONITORIN SYSTEM.slnx" in Visual Studio 2022+
2. Restore NuGet packages (automatic on build)
3. Press F5 to run
```


---

## Project Structure

```
CROP DISEASE MONITORIN SYSTEM/
├── DatabaseHelper.vb          # All SQLite operations (shared/static methods)
├── LoginForm.vb               # App entry point — login screen
├── RegisterForm.vb            # New user registration
├── MainMenuForm.vb            # Navigation hub
├── AddCropForm.vb             # Add a crop entry
├── RecordDiseaseForm.vb       # Record a disease against a crop
├── ViewDiseasesForm.vb        # View all disease records
├── docs/                      # Project documentation
└── CROP DISEASE MONITORIN SYSTEM.vbproj
```
"# VB_NET_CROP-DISEASES-MONITORING-SYSTEM_2026" 
