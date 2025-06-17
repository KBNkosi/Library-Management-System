# Library System Management

A modern library management system built with .NET 7.0 that helps manage books, users, and library operations efficiently.

## Features

- Book Management
  - Add, update, and remove books from the library inventory
  - Track book availability and status

- User Management
  - Support for different user roles (Admin, Librarian, Member)
  - User authentication and authorization
  - Member management and tracking

- Library Operations
  - Book borrowing and returns
  - Library resource management
  - User activity tracking

## Technical Details

- **Framework**: .NET 7.0
- **Language**: C# 11.0
- **Project Type**: Console Application

## Project Structure

The project consists of several key components:

- `Book.cs` - Defines the book entity and related operations
- `User.cs` - Base user class implementation
- `Admin.cs` - Administrative user role implementation
- `Member.cs` - Library member role implementation
- `Librarian.cs` - Librarian role implementation
- `Library.cs` - Core library management functionality

## Getting Started

### Prerequisites

- .NET 7.0 SDK or later
- Any IDE that supports .NET development (recommended: Visual Studio 2022, JetBrains Rider)

### Installation

1. Clone the repository:
```bash
git clone <repository-url>
```
2. Navigate to the project directory:
```bash
cd <project-directory>
```
3. Build the project:
4. Run the application:

## Contributing

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License—see the LICENSE file for details

## Support

For support, please open an issue in the project repository.