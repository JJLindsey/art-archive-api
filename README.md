# Art Archive API

**ASP.NET Core 9 REST API for artwork metadata and certificate generation**

This repository contains the backend for the *Art Archive & Provenance Tracker*, a headless API designed to store artwork metadata and generate downloadable **Certificates of Authenticity**.

The API is intentionally decoupled from the frontend to mirror real-world production architectures.

## Project Overview
Museums, collectors, and cultural institutions often rely on fragmented systems for artwork records and provenance documnetation.
This API provides a centralized, type-safe backend for:
- Managing artwork metadata
- Persisting records using a lightweight SQL database
- Generating professional PDF certificates on demand

### Tech
- **C# / .NET 9**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **SQLite**
- **QuestPDF** (PDF document generation)

