# 🚀 User Management API (.NET 8)

A production-ready **User Management REST API** built using **.NET 8 Web API** following **Clean Architecture principles**.

---

## 📌 Overview

This project demonstrates how to design scalable backend services using:

* Layered Architecture (Controller → Service → Repository)
* Dependency Injection
* Entity Framework Core (Code First)
* RESTful API design

---

## ⚙️ Tech Stack

* 💻 .NET 8 Web API
* 🗄️ Entity Framework Core
* 🧠 In-Memory Database (can switch to SQL Server)
* 📦 Dependency Injection
* 📑 Swagger (API Documentation)

---

## 🧱 Architecture

```
Controller  →  Service  →  Repository  →  Database
```

* **Controller** → Handles HTTP requests
* **Service** → Business logic
* **Repository** → Data access layer
* **DbContext** → Database interaction

---

## 📁 Project Structure

```
UserManagement/
 ├── Controllers/
 │    └── UserController.cs
 ├── Services/
 │    ├── IUserService.cs
 │    └── UserService.cs
 ├── Repositories/
 │    ├── IUserRepository.cs
 │    └── UserRepository.cs
 ├── Models/
 │    └── User.cs
 ├── Data/
 │    └── AppDbContext.cs
 ├── Program.cs
 └── appsettings.json
```

---

## 🚀 Features

✅ Create User
✅ Get All Users
✅ Get User by ID
✅ Update User
✅ Delete User
✅ Clean and scalable architecture

---

## ▶️ Getting Started

### 🔹 Prerequisites

* .NET 8 SDK installed
* Visual Studio / VS Code

---

### 🔹 Run the Project

```bash
dotnet restore
dotnet run
```

---

### 🔹 Swagger UI

After running, open:

```
http://localhost:5000/swagger
```

---

## 🔌 API Endpoints

### 📍 Get All Users

```
GET /api/users
```

### 📍 Get User by ID

```
GET /api/users/{id}
```

### 📍 Create User

```
POST /api/users
```

#### Request Body

```json
{
  "name": "Rishi",
  "email": "rishi@gmail.com"
}
```

---

### 📍 Update User

```
PUT /api/users/{id}
```

---

### 📍 Delete User

```
DELETE /api/users/{id}
```

---

## 🧪 Sample Response

```json
{
  "id": 1,
  "name": "Rishi",
  "email": "rishi@gmail.com"
}
```

---

## 🔄 Future Enhancements

* 🔐 JWT Authentication & Authorization
* 🗄️ SQL Server Integration
* 🐳 Docker Containerization
* 📩 Message Queue (RabbitMQ / Kafka)
* ⚡ Caching with Redis

---

## 📊 Performance Highlights

* ⚡ Optimized API response time using async/await
* 🔄 Efficient data handling with EF Core
* 🧱 Scalable layered architecture

---

## 🤝 Contributing

Contributions are welcome! Feel free to fork and improve the project.

---

## 📜 License

This project is open-source and available under the MIT License.

---

## 👨‍💻 Author

**Rishi Soni**

* 💼 Aspiring SDE-2 Backend Engineer
* 🚀 Passionate about scalable systems & microservices

---

## 🌟 Show Your Support

If you found this project useful:
⭐ Star the repo
🔗 Share on LinkedIn
📌 Follow for more projects

---
