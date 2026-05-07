# DesignPatterns

A learning-focused .NET 8 solution that collects implementations and examples of classic software design patterns. Each pattern is implemented as its own project (or will be) so you can explore individual patterns in isolation, compare implementations, and extend the repository with new examples.

This repository is intended for study and experimentation — clarity and pedagogy are prioritized over production concerns. Each pattern project contains its own `README.md` with pattern-specific explanation, sequence diagrams (where appropriate), sample usage, and notes.

---

## Contents / Project structure

Root layout (representative):

- `LearnDesignPatterns.sln` — solution file (targets .NET 8)    
- `**Example**Pattern/`  
    - `**Example**.csproj`  
    - `README.md` (pattern-specific)  
    - source files...
- `DesignPatternDriver/` - a console app to run demos  
    - `DesignPatternDriver.csproj`  
    - `Program.cs`
- ...other pattern projects...
- `README.md` (this file)

Note: every pattern project SHOULD include a `README.md` describing intent, class diagrams, how the example maps to the pattern, how to run the demo, and suggested exercises. See each project's `README.md` for pattern-specific detail.

---

## Goals

- Provide clear, minimal, idiomatic examples of common design patterns.
- Demonstrate patterns in modern .NET 8 using C#.
- Make it easy to add new patterns and to run individual pattern demos.
- Encourage experimentation and learning through small, focused projects.

---

## What you'll find here

- Implementations of structural, creational, and behavioral patterns (examples already implemented and more planned).
- Per-pattern documentation and usage examples.
- Simple console or test harnesses to exercise each pattern.
- Guidance and templates for adding new patterns.

---

## Implemented & Planned Patterns

Update this list as the repository evolves. Each implemented pattern will contain a project folder with a `README.md`.

- Implemented
  - [Abstract Factory](/AbstractFactoryPattern/README.md) — `AbstractFactoryPattern/`
  - [Decorator](/DecoratorPattern/README.md) — `DecoratorPattern/`
  - [Factory Method](/FactoryPattern/README.md) — `FactoryMethodPattern/`
  - [Observer](/ObserverPattern/README.md) — `ObserverPattern/`
  - [Strategy](/StrategyPattern/README.md) — `StrategyPattern/`

- Planned / To be implemented
  - Singleton
  - Command
  - Adapter
  - Facade
  - Template Method
  - Iterator
  - Composite
  - ...and others

(Keep this list up to date: add/remove entries as projects are added or removed.)

---

## How to open, build and run

Prerequisites:
- .NET 8 SDK
- Visual Studio 2022 (or VS Code / CLI)

Using Visual Studio:
1. Open the solution via __File > Open > Project/Solution__ and select `LearnDesignPatterns.sln`.
2. Explore projects in __Solution Explorer__.
3. Build via __Build > Build Solution__.
4. Run a pattern demo project via __Debug > Start Without Debugging__ or set the desired project as Startup Project and use __Debug > Start Debugging__.

Using the command line:
- Build solution:
  - `dotnet build`
- Run a specific pattern demo (example):
  - `dotnet run --project src/AbstractFactoryPattern/AbstractFactoryPattern.csproj`
- Run tests (if present):
  - `dotnet test`

---

## How to explore a pattern

1. Open the pattern project folder.
2. Read that project's `README.md` for intent, class diagrams, and usage.
3. Run the demo or unit tests for that project to see the pattern in action.
4. Inspect implementation files to understand responsibilities and collaborations.

---

## Adding a new pattern example

1. Create a new project — prefer a self-contained console or library project named with the pattern, e.g. `StrategyPattern`.
   - `dotnet new console -o StrategyPattern`
2. Add a `README.md` in the new project explaining:
   - The pattern intent and when to use it.
   - How your example maps to the pattern roles (client, concrete strategies, context, etc.).
   - How to run the demo and suggested exercises.
3. Follow existing naming and folder conventions used in this repository.
4. Add unit tests under `tests/` (recommended).
5. Update the root `README.md` Implemented/Planned list.

---

## Coding conventions & recommendations

- Target .NET 8 and use modern C# language features when they clarify intent.
- Keep examples minimal: demonstrate the pattern without unrelated infrastructure.
- Prefer immutability where it improves clarity.
- Use clear folder and file naming: `PatternName/`, `PatternName.csproj`, `README.md`.
- Document public APIs and pattern roles inside each project `README.md`.

---

## Tests & CI

- Add unit tests for behaviors you expect from pattern components (e.g., strategy selection, correct product creation).
- Example CI: GitHub Actions workflow that runs `dotnet build` and `dotnet test` on push/PR.
- Keep tests small and focused on the pattern behavior rather than full application scenarios.

---

## Contributing

- Fork the repository and create a feature branch.
- Add or update a pattern project with a `README.md` and tests where applicable.
- Follow the repository structure and naming conventions.
- Create a PR with a clear description and link to the pattern(s) added or updated.

Suggested PR checklist:
- [ ] Pattern project compiles cleanly.
- [ ] Pattern project contains `README.md` documenting intent and usage.
- [ ] Tests added or updated (if applicable).
- [ ] Code is formatted and follows the repository conventions.

---

## License

This repository is intended for learning and may be licensed under the MIT license (add a `LICENSE` file to the repo if you want to apply it).

---

## Contact / Maintainers

- Repository: `https://github.com/Shivambansal97/DesignPatternsExamples`  
- For questions or contributions, open an issue or submit a pull request on GitHub.
