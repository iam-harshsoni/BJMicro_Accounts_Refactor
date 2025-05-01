# BjMicroaccounts Refactoring Project

## 🧱 Legacy to Modern: A .NET 8 Transformation

This project is a complete refactoring of the legacy **BjMicroaccounts** monolithic application originally built on the .NET Framework 4.5. The new version is being developed using **.NET 8**, adopting a **Clean Architecture** approach to achieve modularity, testability, and cross-platform compatibility.

---

## 🎯 Objective

✅ **Modernize** the legacy codebase using best practices  
✅ **Decouple** business logic from infrastructure and presentation layers  
✅ Enable **Web API** consumption for cross-platform access  
✅ Integrate **WinForms** for traditional desktop users  
✅ Develop an **Angular frontend** for modern web-based interaction  
✅ Improve **maintainability, performance**, and **developer experience**

---

## ⚙️ Tech Stack

| Layer              | Technology                         |
|-------------------|-------------------------------------|
| Backend API        | .NET 8 Web API (REST)              |
| Architecture       | Clean Architecture                 |
| Desktop UI         | WinForms (for Windows users)       |
| Web UI             | Angular                            |
| Dependency Injection | Built-in .NET DI container       |
| ORM                | Entity Framework Core              |
| Testing            | xUnit / NUnit (planned)            |
| Auth (Planned)     | JWT / Identity                     |

---

## 🗂 Project Structure

```
BjMicroaccounts/
│
├── src/
│   ├── BjMicroaccounts.API/                # .NET 8 Web API (REST)
│   ├── BjMicroaccounts.Application/        # Use Cases, Interfaces
│   ├── BjMicroaccounts.DataAccess/         # Entities, ValueObjects, Enums
│   ├── BjMicroaccounts.Models/             # EF Core, External Services
│   |── BjMicroaccounts.Utils/              # Helper, Enum etc.
│   ├── BjMicroaccounts/                    # Desktop Client (Legacy UI Users)
│
├── frontend/
│   └── angular-app/                    # Modern Web UI (Angular)
│
├── tests/                              # Unit & Integration Tests
│
├── .editorconfig
├── .gitignore
├── README.md
└── LICENSE
```

---

## 🚧 Current Status

- ✅ Core Domain and Application layers defined  
- ✅ Infrastructure integration with EF Core  
- ✅ API layer scaffolding completed  
- 🚧 Angular frontend in progress  
- 🚧 Legacy logic being ported and cleaned  
- 🚧 WinForms integration planned

---

## 🚀 Running the Project

1. **Backend Setup (.NET 8):**

```bash
cd src/BjMicroaccounts.API
dotnet run
```

2. **Frontend Setup (Angular):**

```bash
cd frontend/angular-app
npm install
ng serve
```

---

## 🧪 Testing

```bash
cd tests
dotnet test
```

---

## 🔍 Clean Architecture Overview

This project follows the [Clean Architecture](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures#clean-architecture) pattern:

- **Domain Layer** – Pure business rules, no dependencies
- **Application Layer** – Application-specific logic, use case orchestration
- **Infrastructure Layer** – External integrations (DB, APIs, File system)
- **API/Presentation Layer** – Interfaces for web or desktop

---

## 🤝 Contribution Guidelines

Pull requests and discussions are welcome. Please follow these steps:

- Fork the repo
- Create a new branch
- Write clean, tested code following existing conventions
- Submit a PR

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).

---

## 🙌 Acknowledgements

- Based on lessons from Clean Architecture by Robert C. Martin
- Inspired by .NET community practices and Microsoft guidance

```

Let me know if you'd like me to generate a matching `LICENSE` file or provide badges (build status, version, etc.) for GitHub display.
