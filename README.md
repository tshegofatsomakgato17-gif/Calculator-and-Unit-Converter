# Calculator and Unit Converter

## Project Overview

The Calculator and Unit Converter is a C# console application developed to perform basic mathematical calculations and common unit conversions.

The application uses a menu-driven interface that allows users to select an operation, enter values, and view the calculated results. The main menu continues to display until the user chooses to exit.

## Features

### 1. Calculator
- Addition
- Subtraction
- Multiplication
- Division
- Division-by-zero error handling

### 2. Distance Converter
- Kilometres to miles
- Miles to kilometres

### 3. Temperature Converter
- Celsius to Fahrenheit
- Fahrenheit to Celsius

### 4. Currency Converter
- Ghanaian Cedis (GHS) to United States Dollars (USD)
- Allows the user to enter the exchange rate.

### 5. Input Validation
- Checks that numerical inputs are valid.
- Rejects invalid menu selections.
- Prevents the application from crashing when invalid numerical input is entered.
- Validates that the currency exchange rate is greater than zero.

## Technologies Used

- C#
- .NET 10
- Visual Studio
- xUnit for automated testing
- Git and GitHub for version control

## Project Structure

The solution contains two projects:

**Main Application**
- `Program.cs` – Contains the main menu and application logic.
- `CalculatorFunctions.cs` – Contains the calculation and conversion methods.
- `InputHelper.cs` – Handles user input and validation.

**Unit Test Project**
- `UnitTest1.cs` – Contains automated tests for the calculation and conversion methods.

## How to Run the Application

### Using Visual Studio
1. Open the solution file in Visual Studio.
2. Set the Calculator and Unit Converter project as the startup project if necessary.
3. Build the solution.
4. Press `Ctrl + F5` to run the application without debugging.
5. Follow the menu instructions in the console.

### Using the .NET CLI
From the solution directory, run:

```bash
dotnet run --project "path-to-main-project.csproj"
```

Replace the example path with the actual path to the main application's `.csproj` file.

## Running Automated Tests

The project uses xUnit to test the calculation and conversion methods.

To run the automated tests using Visual Studio:
1. Open Test Explorer.
2. Select Run All Tests.
3. Review the test results.

Alternatively, run the following command from the solution directory:

```bash
dotnet test
```

**Current test results:** 12 passed, 0 failed, 0 skipped.

## Architecture and Design Decisions

The application separates its responsibilities into different classes to improve organisation, readability, and maintainability.

- `Program.cs` manages the user interface, menu navigation, and application flow.
- `CalculatorFunctions.cs` contains reusable methods for calculations and conversions.
- `InputHelper.cs` handles input validation and helps prevent invalid numerical input from interrupting the application.
- The separate xUnit test project verifies that the calculation and conversion methods produce the expected results.

This separation makes the application easier to maintain, test, and extend.

## Assumptions

- The user supplies the currency exchange rate.
- The exchange rate represents how many Ghanaian Cedis equal one United States Dollar.
- Currency conversion is calculated using the supplied rate rather than a live exchange-rate service.
- Results are displayed to two decimal places.
- Negative numerical values are accepted by the application.

## Known Limitations

- The currency converter does not retrieve live exchange rates.
- The application runs in a console and does not have a graphical user interface.
- Only the specified mathematical operations and conversions are supported.

## Author

Developed as a C# programming project.