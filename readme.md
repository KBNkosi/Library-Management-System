# Library Management System

A library management application designed to support the day-to-day operations of a library by managing books, members, and borrowing workflows.

The system provides role-based access for administrators, librarians, and members, enabling efficient management of library resources and user activities.

## Problem

Managing library resources manually can make it difficult to track inventory, monitor borrowing activity, and manage different user responsibilities.

This application centralizes core library operations, allowing staff to manage books, oversee member activity, and process borrowing and return transactions through a structured system.

## Solution

The system provides:

### Book Management

- Add new books to the library inventory
- Update existing book information
- Remove books from the catalog
- Track availability and borrowing status

### User Management

- Support for multiple user roles:
  - Administrator
  - Librarian
  - Member
- User authentication and authorization
- Member record management

### Borrowing Workflows

- Book checkout and return processing
- Resource availability tracking
- User activity monitoring

## Key Capabilities

- Role-based access control
- Inventory management
- Borrowing and return workflows
- User account management
- Library resource tracking

## Architecture

The application is structured around distinct domain entities and responsibilities:

| Component | Responsibility |
|------------|---------------|
| Book | Represents library inventory and availability |
| User | Base user model and shared functionality |
| Admin | Administrative operations |
| Librarian | Library management operations |
| Member | Borrowing and account-related activities |
| Library | Core business logic and workflow management |

## Technologies

- C#
- .NET 7
- Object-Oriented Programming (OOP)

## Technical Highlights

- Object-oriented domain modeling
- Separation of responsibilities across entities
- Role-based permission structure
- Business logic encapsulation
- Reusable class hierarchy through inheritance

## Project Structure

```text
├── Book.cs
├── User.cs
├── Admin.cs
├── Member.cs
├── Librarian.cs
└── Library.cs
```

## Getting Started

### Prerequisites

- .NET 7 SDK or later
- Visual Studio 2022, JetBrains Rider, or another .NET-compatible IDE

### Installation

Clone the repository:

```bash
git clone <repository-url>
```

Navigate to the project directory:

```bash
cd <project-directory>
```

Build the project:

```bash
dotnet build
```

Run the application:

```bash
dotnet run
```

## Project Status

Archived project maintained as part of my software development portfolio.

This project represents an early implementation of resource management workflows and role-based system design concepts that continue to influence my approach to building business applications and workflow-driven systems.

## Future Enhancements

Potential improvements include:

- Database persistence
- Search and filtering functionality
- Reporting and analytics
- Web-based interface
- REST API integration
- Notification workflows

## License

This project is licensed under the MIT License. See the `LICENSE` file for details.
