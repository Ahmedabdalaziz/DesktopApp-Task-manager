# Task Manager Project

## Overview
This project is a Task Manager application developed in C#. It features functionalities for both regular users and administrators, facilitating efficient task management and oversight.

## Table of Contents
- [Project Structure](#project-structure)
- [Technologies Used](#technologies-used)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Features](#features)
- [User Guide](#user-guide)
- [Admin Guide](#admin-guide)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Project Structure
```
CS_project/
├── .vs/
├── CS_project/
│   ├── Models/
│   ├── Views/
│   ├── Controllers/
│   ├── Utils/
├── packages/
├── .gitattributes
├── CS_project.sln
└── database.ipynb
```

## Technologies Used
- **C# Language:** Core programming language used for the application.
- **.NET Framework:** Provides the runtime and libraries necessary to build and run the application.
- **Windows Forms:** Used for creating the graphical user interface (GUI).
- **Entity Framework:** An ORM (Object-Relational Mapping) framework for database interactions.
- **SQLite:** A lightweight, disk-based database used for storing user and task data.
- **NuGet:** A package manager for .NET, used to manage project dependencies.
- **Jupyter Notebook:** Used in `database.ipynb` for database management and visualization tasks.

## Prerequisites
- [Visual Studio](https://visualstudio.microsoft.com/)
- [.NET Framework](https://dotnet.microsoft.com/)
- NuGet packages (specified in the `packages` folder)

## Installation
1. **Clone the repository:**
   ```sh
   git clone https://github.com/Ahmedabdalaziz/CS_project.git
   ```
2. **Open the solution:**
   Open `CS_project.sln` in Visual Studio.
3. **Restore NuGet packages:**
   Restore the required packages via the NuGet Package Manager.

## Usage
1. **Build the solution:**
   In Visual Studio, select `Build > Build Solution`.
2. **Run the project:**
   Press `F5` or select `Debug > Start Debugging`.

## Features
- **User Management:** Separate interfaces for regular users and administrators.
- **Task Assignment:** Users can create, edit, and manage tasks.
- **Admin Oversight:** Administrators can oversee all tasks, assign tasks, and manage users.
- **Database Integration:** Task and user data are stored and managed via a database.
- **User Interface:** Intuitive UI for both users and administrators.

## User Guide
- **Create Task:** Users can create new tasks with details such as title, description, and due date.
- **Edit Task:** Users can update task information as needed.
- **View Tasks:** Users can view a list of their tasks.

## Admin Guide
- **Manage Users:** Administrators can add, edit, or remove users.
- **Assign Tasks:** Administrators can assign tasks to users and set deadlines.
- **Monitor Progress:** Administrators can view the status of all tasks and manage them accordingly.

## Contributing
1. Fork the repository.
2. Create your feature branch (`git checkout -b feature/AmazingFeature`).
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`).
4. Push to the branch (`git push origin feature/AmazingFeature`).
5. Open a Pull Request.

## Contact
For questions or feedback, please reach out via [GitHub](https://github.com/Ahmedabdalaziz).
