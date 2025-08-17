# 🚀 Full-Stack Integration Project – Microsoft Capstone 2025

![MIT License](https://img.shields.io/badge/license-MIT-blue.svg)
![Microsoft Certified](https://img.shields.io/badge/Microsoft-Full--Stack%20Certified-blueviolet)
![Blazor](https://img.shields.io/badge/Blazor-.NET%206-purple)
![Status](https://img.shields.io/badge/status-Completed-brightgreen)

A modular, production-grade full-stack web application built with **Blazor**, **ASP.NET Core**, and **Entity Framework**, showcasing secure authentication, scalable architecture, and seamless front-end/back-end integration.

---

## 🎓 Certification Context

This repository was created as part of the **Microsoft Full-Stack Developer Professional Certificate** offered on Coursera.
It represents the final capstone for the specialization titled:
**"Full-Stack Integration"**  
Completed by **Francis Olum** on **August 16, 2025**.  
🔗 [Verified Certificate – Coursera](https://coursera.org/verify/professional-cert/PZIW9EU04LNW)

The certificate validates job-ready proficiency in:

- ✅ Front-end development with **Blazor**
- ✅ Back-end APIs using **ASP.NET Core**
- ✅ Database integration with **Entity Framework**
- ✅ Secure authentication and role-based access
- ✅ Performance optimization and DevOps deployment
- ✅ Scalable architecture and modular design

---

## 🧩 Project Features

- 🔐 **Authentication & Authorization**: Role-based access control using ASP.NET Identity  
- 🧮 **Database Integration**: SQL Server with Entity Framework Core  
- 🧱 **Modular Architecture**: Clean separation of concerns across layers  
- 📈 **Performance Optimization**: Caching, async operations, and profiling  
- 🚀 **Deployment Ready**: CI/CD pipeline compatibility and cloud readiness  

---

## 🛠️ Technologies Used

| Layer            | Stack                          |
|------------------|--------------------------------|
| Front-End        | Blazor (.NET 6)                |
| Back-End         | ASP.NET Core Web API           |
| Database         | SQL Server + Entity Framework  |
| Auth & Security  | ASP.NET Identity               |
| DevOps           | GitHub Actions (CI/CD Ready)   |

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).  
You are free to use, modify, and distribute this software with proper attribution.

---

## 📁 Project Structure

```bash
Full_Stack_Integration_Microsoft_Project_2025/
├── Client/               # Blazor front-end
├── Server/               # ASP.NET Core back-end
├── Shared/               # Shared models and DTOs
├── Database/             # EF Core migrations and seed data
├── README.md             # Project documentation
├── LICENSE               # MIT License
```

---

## ⚙️ Project Setup

To run the project locally:

1. **Clone the repository**
   ```bash
   git clone https://github.com/frankTheCodeBoy/Full_Stack_Integration_Microsoft_Project_2025.git
   ```

2. **Navigate to the solution folder**
   ```bash
   cd Full_Stack_Integration_Microsoft_Project_2025
   ```

3. **Restore dependencies**
   ```bash
   dotnet restore
   ```

4. **Apply EF Core migrations**
   ```bash
   dotnet ef database update --project Server
   ```

5. **Run the application**
   ```bash
   dotnet run --project Server
   ```

6. Open your browser and navigate to `https://localhost:5001`

---

## 🤝 Collaboration

Contributions are welcome! This project was developed using a modern, collaborative workflow powered by:

- **Git & GitHub** – Version control, branching, and pull requests  
- **Visual Studio & VS Code** – Development and debugging environments  
- **Microsoft Copilot** – AI-assisted coding, refactoring, and documentation  
- **GitHub Actions** – CI/CD pipeline setup and automated testing  
- **Entity Framework Core CLI** – Database migrations and schema management  
- **.NET CLI** – Project scaffolding, builds, and runtime execution

To collaborate:

1. Fork the repository  
2. Create a new branch (`git checkout -b feature-name`)  
3. Commit your changes (`git commit -m "Add feature"`)  
4. Push to your branch (`git push origin feature-name`)  
5. Open a pull request

Please ensure your code aligns with the existing architecture and includes relevant documentation or comments.

---

## 🙋‍♂️ Author

**Francis Olum**  
Microsoft Certified Full-Stack Developer  
📫 [GitHub Profile](https://github.com/frankTheCodeBoy)

---

## 💬 Feedback & Contributions

Feel free to fork, star ⭐, or open issues. Contributions are welcome!

