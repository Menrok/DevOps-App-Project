# DevOps C# Project

Projekt demonstracyjny przygotowany na potrzeby zaliczenia przedmiotu DevOps.  
Celem projektu jest zaprezentowanie kompletnego procesu DevOps, obejmującego zarządzanie kodem źródłowym, backlogiem zadań, testami automatycznymi oraz pipeline’ami CI/CD.

Aplikacja posiada uproszczoną logikę biznesową i służy wyłącznie jako nośnik do prezentacji procesów DevOps, a nie jako pełnoprawny system produkcyjny.

---

## Autor

- Michał Handzel

---

## Opis aplikacji

Projekt jest aplikacją **ASP.NET Core Web API** zrealizowaną w oparciu o podejście **Minimal API**.  
Udostępnia proste endpointy HTTP, które mogą być łatwo testowane oraz wykorzystywane w pipeline’ach CI/CD.

W ramach projektu zaprezentowano:
- pracę z systemem kontroli wersji Git oraz platformą GitHub (branche, Pull Requesty, commity),
- zarządzanie backlogiem i zadaniami przy użyciu GitHub Projects,
- testy jednostkowe i integracyjne z wykorzystaniem xUnit,
- pipeline Continuous Integration zbudowany w GitHub Actions,
- automatyczne wdrożenie aplikacji (Continuous Deployment) do chmury Microsoft Azure. Pipeline skonfigurowany.

---

## Sekrety i bezpieczeństwo

Projekt wykorzystuje GitHub Secrets do przechowywania wrażliwych danych.
Sekrety są przekazywane do aplikacji jako zmienne środowiskowe i wykorzystywane w pipeline CI bez zapisywania ich w repozytorium.

## Endpointy


`/` Zwraca informacje o stanie aplikacji, środowisku oraz aktualnym czasie serwera
`/products` Zwraca przykładową listę produktów w formacie JSON

---

## Uruchomienie lokalne

### Wymagania
- .NET SDK 8.0 lub nowszy

### Kroki
```bash
dotnet restore
dotnet run