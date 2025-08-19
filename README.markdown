# Driving License Vehicles Application

A desktop application designed to manage driving license services, including issuing local and international licenses, renewing licenses, and handling related tasks. This is an **educational project** built to demonstrate proficiency in C#, .NET Framework, SQL Server, and software architecture principles, showcasing the developer's growth in applying advanced programming concepts.

## Table of Contents
- [Project Overview](#project-overview)
- [Features](#features)
- [Architecture](#architecture)
- [Technologies Used](#technologies-used)
- [Installation](#installation)
- [Usage](#usage)
- [Requirements](#requirements)
- [License](#license)
- [Contact](#contact)

## Project Overview
This project is a **Windows Desktop Application** developed to simulate a driving license management system. It allows users to issue local and international licenses, renew licenses, replace lost or damaged licenses, release licenses from seizure, and schedule re-examinations for failed tests. The project was built as a learning exercise to apply **Three-Tier Architecture**, **Dependency Injection**, and various **Design Patterns**, reflecting continuous improvement and experimentation with modern software development practices.

## Features
- Issue a driving license for the first time after passing three tests (vision, theoretical, and practical).
- Renew existing licenses.
- Issue replacements for lost or damaged licenses.
- Release licenses from seizure.
- Issue international licenses.
- Schedule re-examination for users who fail the driving tests.

## Architecture
The project is built using a **Three-Tier Architecture** (Presentation, Business Logic Layer - BLL, Data Access Layer - DAL) to ensure separation of concerns and maintainability. Key architectural highlights include:
- **DAL (Data Access Layer)**:
  - Initially used raw SQL queries as strings executed directly.
  - Later upgraded to **Stored Procedures** for improved performance and security.
  - Includes **Mapper** classes to read data from `SqlDataReader` independently.
  - Uses a **Parameters Binder** class to handle SQL command parameters separately from DAL methods.
- **DTO (Data Transfer Objects)**:
  - Added to encapsulate data transfer between layers, enhancing modularity.
- **BLL (Business Logic Layer)**:
  - Designed to handle business logic only, avoiding data storage.
  - Utilizes **Interfaces** to reduce coupling between layers.
- **Dependency Injection**:
  - Implemented a custom **Container** class to simulate Dependency Injection manually.
  - BLL depends on DAL Interfaces, and Presentation depends on BLL Interfaces, minimizing direct dependencies.
- **Design Patterns**:
  - Incorporates various design patterns to demonstrate evolving programming skills.

The project is a work in progress, with new concepts and improvements added regularly as part of the learning process.

## Technologies Used
- **C#** with **.NET Framework 4.7.2**
- **SQL Server 2021** for database management
- Developed manually without external libraries to simulate framework principles
- Built using **Visual Studio 2019**

## Installation
This project is primarily educational and intended for demonstration purposes. To set up and run it locally, follow these steps:

1. **Clone the repository**:
   ```bash
   git clone https://github.com/badrahmed66/Driving-License-Vehicles-Department-Application
   ```
2. **Open the project**:
   - Open the solution file (`.sln`) in **Visual Studio 2019**.
3. **Set up the database**:
   - Install **SQL Server 2021 Express** (or compatible version).
   - Use **SQL Server Management Studio (SSMS)** to create a new database.
   - Run the provided `database.sql` file (if available) to set up the database schema.
   - Update the connection string in the project’s configuration file (e.g., `app.config`) to point to your SQL Server instance.
4. **Build and run**:
   - Build the solution in Visual Studio (`Ctrl+Shift+B`).
   - Run the application by pressing `F5`.

*Note: As this is an educational project, some setup steps may require manual configuration.*

## Usage
1. **Launch the application**:
   - Run the project in Visual Studio (`F5`) or execute the generated `.exe` file after building.
2. **Log in**:
   - Use the following credentials to access the application:
     - **Username**: badr2
     - **Password**: 123456
3. **Navigate the features**:
   - Use the user interface to issue licenses, renew licenses, schedule tests, or perform other tasks as listed in the [Features](#features) section.

*Note: This is a learning project, so some features may be under development or contain experimental code.*

## Requirements
- **Visual Studio 2019** with .NET Desktop Development workload
- **.NET Framework 4.7.2**
- **SQL Server 2021 Express** (or compatible) and **SQL Server Management Studio (SSMS)**

## License
Distributed under the [MIT License](LICENSE). See `LICENSE` file for more information.

## Contact
This project is maintained by [Ahmed Badr]. For inquiries, you can reach out via:
- Email: [badrbadr4441@gmail.com]
