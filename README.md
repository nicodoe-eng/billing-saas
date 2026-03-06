# Billing SaaS Platform

A multi-tenant billing platform built with .NET using Clean Architecture principles.
The system is designed to manage recurring payments for organizations such as schools, universities, political parties, and membership-based institutions.

The platform acts as a **billing bridge between organizations and banking/payment systems**, allowing tenants to automate invoice generation, track payments, and manage billing cycles.

---

## Project Goals

This project is being developed as a **production-style portfolio system** to demonstrate backend engineering skills including:

* Clean Architecture implementation
* Domain-driven system design
* Multi-tenant SaaS architecture
* Recurring billing systems
* Database modeling
* API development with .NET

---

## Tech Stack

* **.NET 10**
* **ASP.NET Core Web API**
* **PostgreSQL**
* **Docker**
* **Entity Framework Core**
* **Clean Architecture**

---

## Architecture

This project follows the **Clean Architecture pattern**, separating responsibilities into independent layers.

src
├── BillingSystem.API
├── BillingSystem.Application
├── BillingSystem.Domain
└── BillingSystem.Infrastructure

### Layer Responsibilities

**Domain**

Contains core business entities and domain logic.

Examples:

* Tenant
* Subscription
* Invoice
* Payment
* BillingCycle

**Application**

Contains business use cases and application services.

Examples:

* Invoice generation
* Billing cycle processing
* Payment processing

**Infrastructure**

Contains external integrations such as:

* Database access (PostgreSQL)
* Payment gateway integrations
* External service implementations

**API**

Entry point of the application.

Provides REST endpoints for:

* Tenant management
* Billing operations
* Invoice queries
* Payment processing

---

## Planned Features

* Multi-tenant billing system
* Recurring billing engine
* Automatic invoice generation
* Payment tracking
* Bank/payment gateway integration
* Subscription plan management
* Invoice lifecycle management

---

## Local Development Setup

### 1. Start Database (Docker)

docker compose up -d

This starts a PostgreSQL container used by the application.

---

### 2. Build the Solution

dotnet build

---

### 3. Run the API

dotnet run --project src/BillingSystem.API

---

## Project Structure

billing-saas
├── docker
│   └── docker-compose.yml
├── src
│   ├── BillingSystem.API
│   ├── BillingSystem.Application
│   ├── BillingSystem.Domain
│   └── BillingSystem.Infrastructure
└── tests

---

## Current Development Status

Early development phase.

Current focus:

* Domain model design
* Clean Architecture setup
* PostgreSQL integration
* Core billing logic

---

## Author

Backend developer focused on:

* .NET backend systems
* Accounting and financial systems
* Inventory systems
* SaaS platforms

---

## License

This project is currently for **educational and portfolio purposes**.
