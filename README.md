# ASPNetCore8-Blog-CleanCQRS

This is a blog application built with ASP.NET Core 8, following the Clean Architecture principles and using the CQRS (Command Query Responsibility Segregation) pattern.

## Table of Contents

- [Overview](#overview)
- [Architecture](#architecture)
- [Features](#features)
- [Usage](#usage)
- [Acknowledgments](#acknowledgments)

# Overview

The **ASPNetCore8-Blog-CleanCQRS** application is designed to demonstrate how to structure an ASP.NET Core application using Clean Architecture. It incorporates the CQRS pattern to separate read and write operations, providing scalability and maintainability for the application.

# Architecture

This project implements the following architectural patterns:

- **Clean Architecture**: Separates the application into layers (Domain, Application, Infrastructure, Presentation) to ensure a clear separation of concerns.
- **CQRS**: Segregates the data modification operations from the data retrieval operations for better command and query performance.

## Project Structure

```plaintext
├── API
├── Application
├── Domain
└── Infrastructure
└── README.md
```

# Features
CRUD operations for blog posts

## Before running this application, ensure you have the following installed:
- .NET 8 SDK
- PostgreSQL
- VS Code

# Installation
Follow these steps to set up the project locally:

Clone the repository:

```bash
git clone https://github.com/Sir-Uus/ASPNetCore8-Blog-CleanCQRS.git
cd ASPNetCore8-Blog-CleanCQRS
```

## Set up the database:

Create a PostgreSQL database and update the connection string in the appsettings.json file located in the Presentation project.

## Restore and build the project:

```bash
dotnet restore
dotnet build
```

## Apply migrations:

Ensure the database is up to date with the latest migrations:

```bash
dotnet ef database update --project src/Infrastructure
```

# Usage
To run the application, execute the following command in the root directory:

```bash
dotnet run --project src/Presentation
```
The application will be available at https://localhost:5001 (or http://localhost:5000).

## API Documentation
API documentation is available via Swagger. Navigate to /swagger in your browser to access it once the application is running.

# Acknowledgments
- Jason Taylor for the Clean Architecture principles.
- AutoMapper for object mapping.
- MediatR for implementing the CQRS pattern.
