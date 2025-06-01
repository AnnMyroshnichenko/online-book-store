# Book Store - ASP.NET Core MVC E-Commerce Application
It is a full-featured e-commerce web application built with ASP.NET Core MVC (.NET 8), Entity Framework Core, and ASP.NET Core Identity. It demonstrates best practices in modern web development, including clean architecture, role-based access control, and third-party integrations like Stripe for payments. The application is designed with scalability and maintainability in mind, making it suitable for real-world deployment.

**Note:** This project is currently under development and not yet complete.

## Features
- User Roles & Identity Management: Role-based access control with Admin and Customer roles.

- Product Catalog: CRUD operations for categories and products.

- Shopping Cart: Add, update, and remove items from the cart.

- Order Processing: Place orders with order summary.

- Stripe Payment Integration: Secure payment processing using Stripe API.

- Email Notifications: Automated emails for order confirmations and status updates.

- Responsive UI: Built with Bootstrap 5.

- Repository Pattern: Clean separation of concerns with the repository and unit of work patterns.

- Deployment Ready: Configured for deployment on Microsoft Azure and IIS.

## Technologies Used
Backend: ASP.NET Core MVC (.NET 8)

ORM: Entity Framework Core

Frontend: Razor Pages, Bootstrap 5

Database: SQL Server

Payment Gateway: Stripe API

Email Service: SMTP

Authentication: ASP.NET Core Identity with role management

Deployment: Microsoft Azure


## Getting Started

### Prerequisites

- Visual Studio 2022

- .NET 8 SDK

- SQL Server

- Stripe account


### Installation
- Clone the repository

- Set Environment Variables for the connection string, Stripe API and Email:

On Windows (PowerShell)
```
$env:ConnectionStrings__DefaultConnection="Server=YOUR_SERVER;Database=your_db;Trusted_Connection=True;"
$env:Stripe__PublishableKey="your-publishable-key"
$env:Stripe__SecretKey="your-secret-key"
$env:EmailSettings__Host="smtp.sendgrid.net"
$env:EmailSettings__Port="587"
$env:EmailSettings__Username="your-username"
$env:EmailSettings__Password="your-password"
$env:EmailSettings__From="no-reply@bulkybook.com"
```

On Linux / macOS (Bash)
```
export ConnectionStrings__DefaultConnection="Server=YOUR_SERVER;Database=your_db;Trusted_Connection=True;"
export Stripe__PublishableKey="your-publishable-key"
export Stripe__SecretKey="your-secret-key"
export EmailSettings__Host="smtp.sendgrid.net"
export EmailSettings__Port="587"
export EmailSettings__Username="your-username"
export EmailSettings__Password="your-password"
export EmailSettings__From="no-reply@bulkybook.com"
```

- Apply migrations and seed the database:

```
Update-Database
```

- Run the application:

```
dotnet run
```

## Deployment
The application is configured for deployment on Microsoft Azure.

Publish the application using Visual Studio's Publish Wizard or via CLI:

```
dotnet publish --configuration Release
```

## Contributing
Contributions are welcome! Please fork the repository and submit a pull request for any enhancements or bug fixes.

## License
This project is licensed under the MIT License. See the LICENSE file for details.

## Acknowledgments
This project is based on the course “.NET Core MVC - The Complete Guide 2025 [E-commerce]” by Bhrugen Patel.
