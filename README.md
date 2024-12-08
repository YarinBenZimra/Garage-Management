# Garage Management System

Welcome to the **Garage Management System**! This project is a console-based application designed to manage vehicles in a garage environment. Built with C# and .NET, it demonstrates advanced object-oriented principles including polymorphism, exception handling, and modular design using multiple projects.

---

## Table of Contents

- [Project Overview](#project-overview)
- [Features](#features)
- [Prerequisites](#prerequisites)
- [Installation and Setup](#installation-and-setup)
- [How to Use](#how-to-use)
- [Design and Implementation](#design-and-implementation)
- [Notes](#notes)

---

## Project Overview

The Garage Management System provides a complete solution for managing various types of vehicles, including electric cars, motorized motorcycles, and trucks. The system separates the business logic from the user interface to ensure maintainability and scalability. 

It supports features like:
- Tracking vehicle details (e.g., tire pressure, fuel/energy levels).
- Changing vehicle status in the garage.
- Refueling motorized vehicles or recharging electric vehicles.

---

## Features

1. **Vehicle Management**:
   - Add vehicles to the garage.
   - Track vehicle-specific properties like fuel type, energy level, and wheel specifications.

2. **Maintenance Features**:
   - Inflate tires to their maximum pressure.
   - Refuel motorized vehicles or recharge electric vehicles.

3. **Data Filtering and Display**:
   - Filter vehicles by status (e.g., "In Repair," "Fixed").
   - Display detailed information for all vehicles.

4. **Error Handling**:
   - Handles invalid inputs gracefully using custom exceptions.

5. **Object-Oriented Design**:
   - Modular design with reusable components and polymorphism for various vehicle types.

---

## Prerequisites

Ensure you have the following installed:
- **Visual Studio** (recommended for building the project).
- **.NET Framework/SDK**.
- **Git** (for cloning the repository).

---

## Installation and Setup

### Step 1: Clone the Repository

Start by cloning the repository:

```bash
git clone https://github.com/YarinBenZimra/Garage-Management.git
```

### Step 2: Open and Build the Project

#### Using Visual Studio (Recommended)
1. Navigate to the project folder:
   ```bash
   cd Garage-Management
   ```
2. Open the solution file:
   - Double-click `Garage-Management.sln` to open the project in Visual Studio.
3. Build the solution:
   - Go to the **Build** menu and select **Build Solution** (or press `Ctrl + Shift + B`).
4. Start the project:
   - Press `F5` to run the application.

---

## How to Use

After starting the application, a console menu will appear, allowing you to perform the following actions:
1. Insert a new vehicle into the garage.
2. Display all vehicles in the garage (with filtering options by status).
3. Change the state of a vehicle in the garage (e.g., "In Repair," "Fixed").
4. Inflate vehicle tires to the maximum pressure.
5. Refuel motorized vehicles.
6. Charge electric vehicles.
7. Display complete details for a specific vehicle.

---

## Design and Implementation

### Class Structure
- **Base Class**: `Vehicle`  
  - Includes shared properties like license number, tire pressure, and wheels.
- **Derived Classes**:
  - `ElectricVehicle` (Derived Classes: `ElectricCar`, `ElectricMotorcycle`).
  - `MotorizedVehicle` (Derived Classes: `MotorizedCar`, `MotorizedMotorcycle`, `Truck`).

### Key Components
1. **Business Logic**:
   - Located in the `Ex03.GarageLogic` project, defined as a `Dll`.
2. **User Interface**:
   - Located in the `Ex03.ConsoleUI` project, which interacts with the logic layer.
3. **Exception Handling**:
   - Custom exceptions like `ValueOutOfRangeException` ensure robust error handling.
4. **Collections**:
   - Utilizes `List<Vehicle>`.

---

## Notes

1. **Separation of Logic and UI**:
   - The business logic is isolated in the `Ex03.GarageLogic` library, making the system maintainable and scalable.
2. **Extensibility**:
   - Easily extendable to support new vehicle types or additional garage features.
3. **Custom Exception Types**:
   - `FormatException`, `ArgumentException`, and `ValueOutOfRangeException` are implemented to ensure user input validation.

---

Feel free to explore, use, and extend the project. Contributions are welcome! 🚗🔧
