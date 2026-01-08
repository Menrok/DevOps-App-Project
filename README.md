# DevOps C# Project

Projekt demonstracyjny przygotowany na potrzeby zaliczenia przedmiotu **DevOps**.  
Celem projektu jest zaprezentowanie kompletnego procesu DevOps, obejmującego zarządzanie kodem źródłowym, backlogiem zadań, testami automatycznymi oraz pipeline’ami CI/CD.

Aplikacja posiada uproszczoną logikę biznesową i służy wyłącznie jako nośnik do prezentacji procesów DevOps, a nie jako pełnoprawny system produkcyjny.

---

## Autor

- **Michał Handzel**

---

## Opis aplikacji

Projekt jest aplikacją **ASP.NET Core Web API** zrealizowaną w oparciu o podejście **Minimal API**.  
Udostępnia proste endpointy HTTP, które mogą być łatwo testowane oraz wykorzystywane w pipeline’ach CI/CD.

W ramach projektu zaprezentowano:
- pracę z systemem kontroli wersji Git oraz platformą GitHub (branche, Pull Requesty, commity),
- zarządzanie backlogiem i zadaniami przy użyciu GitHub Projects,
- testy jednostkowe i integracyjne z wykorzystaniem xUnit,
- pipeline Continuous Integration zbudowany w GitHub Actions,
- automatyczne wdrożenie aplikacji (Continuous Deployment) do chmury Microsoft Azure.

---

## Sekrety i bezpieczeństwo

Projekt wykorzystuje **GitHub Secrets** do przechowywania wrażliwych danych konfiguracyjnych.  
Sekrety są przekazywane do aplikacji jako zmienne środowiskowe i wykorzystywane w pipeline CI bez zapisywania ich bezpośrednio w repozytorium.

---

## Konteneryzacja aplikacji

Aplikacja została skonteneryzowana przy użyciu **Docker**
W repozytorium znajdują się:
- `Dockerfile` – definicja obrazu aplikacji,
- `.dockerignore` – lista plików wykluczonych z procesu budowania obrazu.

---

## Endpointy

- **`/`** – zwraca informacje o stanie aplikacji, środowisku oraz aktualnym czasie serwera  
- **`/products`** – zwraca przykładową listę produktów w formacie JSON  

---

## Uruchomienie lokalne

### Wymagania
- .NET SDK **8.0** lub nowszy  
- **Docker** (opcjonalnie – do uruchomienia aplikacji w kontenerze)

---

### Uruchomienie bez Dockera

```bash
dotnet restore
dotnet run
