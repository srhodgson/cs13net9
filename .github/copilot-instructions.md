ou # Copilot Instructions

This repository is the companion code for a Packt C# / .NET programming book. It is a
collection of small, self-contained teaching examples rather than a single application.

## Layout

- Each chapter is a top-level folder (`Chapter01` … `Chapter05`). Every chapter has its own
  `.sln` (e.g. `Chapter04/Chapter04.sln`) that contains only that chapter's projects.
- Each project folder contains a `.csproj` and one or more `.cs` files.
- `obj/` and `bin/` folders exist on disk from local builds but are **gitignored**. Do not
  edit, delete, or commit them.

### Project kinds

- **Console apps** — `OutputType=Exe`, entry point is top-level statements in `Program.cs`.
- **Class libraries** — plain `Microsoft.NET.Sdk` projects (no `OutputType`), e.g. `CalculatorLib`,
  `PacktLibraryModern`, `PacktLibraryNet2`.
- **Test project** — `Chapter04/CalculatorLibUnitTests` is the *only* test project (xUnit) and
  references `CalculatorLib` via `ProjectReference`.

## Build, run, and test

There is no root solution and no `global.json`; the installed SDK is auto-selected. The common
target is `net9.0`, but a few projects differ — check the `.csproj` before assuming:
`Debugging`, `HotReloading`, `WritingFunctions`, and `PeopleApp` target `net10.0`, and
`PacktLibraryNet2` targets `netstandard2.0` with `LangVersion 13`.

- Build a whole chapter: `dotnet build Chapter04/Chapter04.sln`
- Run a console app: `dotnet run --project Chapter05/PeopleApp/PeopleApp.csproj`
- Run all tests: `dotnet test Chapter04/CalculatorLibUnitTests`
- Run a single test / theory:
  `dotnet test Chapter04/CalculatorLibUnitTests --filter "FullyQualifiedName~TestAdding"`

## Conventions specific to this repo

- **Preserve the teaching comments.** Source files are full of intentional version-marker
  comments such as `// C# 9 or later.` and commented-out alternative syntaxes. These *are* the
  content. Do not remove, "clean up", or modernize them.
- **`#region` blocks** group each teaching section (e.g. `#region Constructors`, `#region
  Indexers`). Keep them and place new code inside the relevant region.
- **Nullable and implicit usings are on** for every project (`Nullable=enable`,
  `ImplicitUsings=enable`).
- **Console shorthand.** Most console apps declare
  `<Using Include="System.Console" Static="true" />` in the `.csproj` (or start `Program.cs` with
  `using static System.Console;`) so `WriteLine(...)` is used with no `Console.` prefix. Follow the
  existing style in the file you edit.
- **Top-level functions / helpers.** When a console app needs extra functions, they live in a
  sibling `partial class Program` inside `Program.Functions.cs` / `Program.Helpers.cs` with **no
  namespace declaration**, so they merge into the auto-generated `Program` class in the empty
  namespace.
- **Shared namespaces.** Chapter 05 libraries use the file-scoped namespace `Packt.Shared`. The
  `Person` type is split across `Person.cs` and `PersonAutoGen.cs` via `partial class` — when
  adding members to `Person`, pick the right partial file by kind (fields/constructors/methods in
  `Person.cs`, properties/indexers in `PersonAutoGen.cs`).
- **Wiring demo apps.** Example apps that consume a library do so with a
  `<ProjectReference>` (e.g. `PeopleApp` references both `PacktLibraryModern` and
  `PacktLibraryNet2`). New example code should reference existing libraries the same way rather
  than duplicating types.

## Adding a new example

- Put it in the chapter folder that matches its topic and add a project entry to that chapter's
  `.sln` (projects are referenced by relative path, e.g. `Name\Name.csproj`).
- Mirror the nearest existing project's `.csproj` (target framework, `Static` `Using` entries,
  `LangVersion`) rather than inventing new settings.
