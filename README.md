# Automated Investment API

Backend system that simulates a programmed stock investment feature.

The system distributes an investment amount across a portfolio of stocks and automatically generates purchase orders.

---

# Tech Stack

- .NET 8
- ASP.NET Core Web API
- MySQL
- Entity Framework Core
- Swagger

---

# Architecture

The project follows a layered backend architecture.

Controllers  
API endpoints

Services  
Business logic and purchase engine

Data  
Database access (Entity Framework)

Domain  
Application entities

---

# Project Structure

Controllers
Data
Domain
Services
Program.cs

---

# API Endpoints

Execute programmed purchase

POST /investment/purchase?amount=1000

Get generated orders

GET /investment/orders

Get portfolio assets

GET /investment/portfolio

---

# Example Flow

1 Start API

dotnet run

2 Open Swagger

http://localhost:5261/swagger

3 Execute purchase

POST /investment/purchase?amount=1000

4 Check generated orders

GET /investment/orders

---

# Purpose

This project was built as part of a backend engineering challenge to demonstrate:

- REST API design
- database integration
- backend architecture
- financial business logic


## Example API Flow

1. Start the API

dotnet run

2. Open Swagger in your browser

http://localhost:5261/swagger

3. Execute purchase

POST /investment/purchase?amount=1000

4. Check generated orders

GET /investment/orders

5. Get portfolio summary

GET /investment/summary