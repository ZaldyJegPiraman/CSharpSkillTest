# CSharpSkillTest

CSharpSkillTest is a Windows Forms application created using **Visual Studio 2022**, targeting **.NET 9.0**.
The project demonstrates both the **Strategy Pattern** and the **MVC (Model–View–Controller)** architecture by allowing users to sort text using different sorting algorithms.
A dedicated **MSTest** unit test project is also included.

## Project Overview

This application allows the user to:

1. Enter a string.
2. Select a sorting strategy:
   - Bubble Sort
   - Quick Sort
3. Display the sorted output.

Design patterns used:

- Strategy Pattern — sorting algorithms are interchangeable.
- MVC Pattern — separates the UI, business logic, and data.

## Technology Stack

- Visual Studio 2022
- .NET 9.0
- Windows Forms
- MSTest
- MVC + Strategy Pattern

## Project Structure

CSharpSkillTest/
├── Models/
│ ├── ISortStrategy.cs
│ ├── BubbleSortStrategy.cs
│ ├── QuickSortStrategy.cs
│ └── SortModel.cs
│
├── Controllers/
│ └── SortController.cs
│
├── Views/
│ ├── MainForm.cs
│ └── MainForm.Designer.cs
│
├── Program.cs
├── CSharpSkillTest.csproj
├── CSharpSkillTest.sln
│
└── UnitTests/
├── SortTests.cs
└── CSharpSkillTest.UnitTests.csproj

## How to Run

1. Open CSharpSkillTest.sln in Visual Studio 2022.
2. Set **CSharpSkillTest** as the startup project.
3. Press **F5** to run.

## Running Unit Tests

1. Open **Test Explorer**.
2. Build the solution.
3. Click **Run All**.

## Features

- Clean Windows Forms UI
- Multiple sorting strategies
- Extensible architecture
- Includes MSTest-based unit tests

