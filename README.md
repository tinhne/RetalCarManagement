# RetalCarManagement

C# console exercise (January 2024) for object-oriented programming: a small vehicle registry with a base `Vehicle` class and two specialised vehicle types. Coursework-style practice project; the management menu is not finished.

## What it practises

- Inheritance and polymorphism: `Vehicle` → `Truck` (tonnage) and `TouristCar` (number of seats), with `virtual`/`override` `Input()` and `Output()` methods
- A generic input helper, `InputData<T>(prompt, Func<string, T> parse)`, that re-prompts until parsing succeeds
- Properties with backing fields and nullable reference types (`<Nullable>enable</Nullable>`)
- A `Dictionary<string, Vehicle>` keyed by number plate for add, search and delete (`VehicalManagement`)

## Structure

| File | Description |
| --- | --- |
| `RetalCarManagement/Vehicle.cs` | Base class: number plate, model name, capacity, inspection date, standard level (`DegreeStandards`); `InputData<T>` helper |
| `RetalCarManagement/Truck.cs` | Adds `NumberOfTons` |
| `RetalCarManagement/TouristCar.cs` | Adds `NumberOfSeats` |
| `RetalCarManagement/VehicalManagement.cs` | Dictionary-based registry: `EnterInfo`, `Search`, `Delete`, and a menu skeleton in `Show` |
| `RetalCarManagement/Program.cs` | Entry point: reads one `Truck` from the console and prints it |
| `RetalCarManagement/RetalCarManagement.csproj` | .NET 8 console project |

## How to run

Prerequisite: .NET 8 SDK.

```bash
dotnet run --project RetalCarManagement/RetalCarManagement.csproj
```

Run the inner project directly. The repository root also contains a second `RetalCarManagement.csproj` and a solution file that references a `LearnC#` project outside this repository, so building from the root fails.

## Known limitations

- `Program.Main` only exercises a single `Truck`; `VehicalManagement` is not called.
- `VehicalManagement.Show` prints the menu and reads a choice but never acts on it.
- In `EnterInfo`, the tourist-car branch is `case "Q"`, which is unreachable because `Q` exits first (the prompt says `D`).
- `Delegate.cs` is empty.

## Author

**Lê Văn Trung Tính** — Software Engineer | AI Product Builder

- Website: [trungtinh.site](https://trungtinh.site)
- GitHub: [@tinhne](https://github.com/tinhne)
