# Blog Application with ASP.NET Core 7.0 🚀

Welcome to the Blog Application! This project is built using ASP.NET Core 7.0, providing a robust and scalable platform for creating and managing blog posts.

## Table of Contents 📑
- [Features](#features-✨)
- [Getting Started](#getting-started-🚀)
- [Prerequisites](#prerequisites-🛠️)
- [Installation](#installation-🔧)
- [Usage](#usage-📝)
- [Screenshots](#screenshots-📸)
- [Contributing](#contributing-🤝)
- [License](#license-📄)

## Features ✨
- **Create, Read, Update, Delete (CRUD)** operations for blog posts.
- **User Authentication and Authorization** using ASP.NET Core Identity.
- **Role-based access control** for admin and regular users.
- **Tagging system** for organizing posts.
- **Rich text editing** with TinyMCE.
- **Responsive design** using Bootstrap.

## Getting Started 🚀
Follow these instructions to get a copy of the project up and running on your local machine for development and testing purposes.

## Prerequisites 🛠️
- [.NET SDK 7.0](https://dotnet.microsoft.com/download/dotnet/7.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)


## Screenshots 📸
![main](https://github.com/user-attachments/assets/afb70868-4564-4a67-84c3-4a29691d4504)
![detail2](https://github.com/user-attachments/assets/2801a738-790b-4bb6-9a01-697056dc7237)
![comentsect3](https://github.com/user-attachments/assets/1f4ed4da-45a3-4c45-abc2-1892ab78196e)
![postpanel4](https://github.com/user-attachments/assets/95ec8665-2f15-4567-9ab4-c8d03e7d4a46)
![editpage5](https://github.com/user-attachments/assets/c7cca466-b90b-4e8f-a0d4-6ea0862ccf97)
![userdetail6](https://github.com/user-attachments/assets/841f4b55-7d73-4b0c-8160-9a66205b2766)

## Installation 🔧
1. **Clone the repository:**
    ```sh
    git clone https://github.com/kubicix/Blog-Application-with-ASP.NET-CORE-7.0.git
    cd Blog-Application-with-ASP.NET-CORE-7.0
    ```

2. **Configure the database connection:**
    Update the `appsettings.json` file with your SQL Server connection string.
    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;"
    }
    ```

3. **Apply migrations and update the database:**
    ```sh
    dotnet ef database update
    ```

4. **Run the application:**
    ```sh
    dotnet run
    ```

## Usage 📝
1. **Register or log in** to the application.
2. **Create a new post** by navigating to the "Create Post" section.
3. **Edit or delete posts** by navigating to the post management section (admin only).
4. **Tag posts** to organize them better.
5. **View all posts** in the main blog feed.

## Contributing 🤝
Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License 📄
Distributed under the MIT License. See `LICENSE` for more information.

---

Thank you for checking out this project! If you have any questions or feedback, feel free to reach out.
