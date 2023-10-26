# WAD_CE129_CE122_NET_MVC

# Digital Classroom Management System

Welcome to the Digital Classroom Management System, a web application built using .NET Core MVC. This project is created and maintained by Vraj Shah (CE129) and Jai Sarang (CE122).

## Project Description

The Digital Classroom Management System is a platform that allows teachers to create virtual classrooms, add students, and upload study materials in various formats like videos and PDFs. Students can access these classrooms, view the study materials, and download them for offline use.

## Features

- **User Roles:**
  - **Teacher:** Teachers can create classrooms, add students, and upload study materials.
  - **Student:** Students can access classrooms and download study materials.

- **Classroom Management:**
  - Teachers can create and manage multiple classrooms.
  - Add, edit, or remove students from their classrooms.
  - Upload and manage study materials in different formats.

- **Study Materials:**
  - Support for uploading and organizing study materials such as videos and PDFs.
  - Download materials for offline access.

## Technologies Used

- **Frontend:**
  - HTML, CSS, JavaScript
  - Razor Views

- **Backend:**
  - .NET Core MVC
  - C# for server-side logic



## Getting Started

To get started with the Digital Classroom Management System on your local machine, follow these steps:

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/your-repo-url.git
   cd DigitalClassroom
   ```

2. **Database Configuration:**
   - Set up your database and connection strings. Make sure to update the connection string in the `appsettings.json` file.

3. **Run Migrations:**
   ```bash
   dotnet ef database update
   ```

4. **Build and Run:**
   ```bash
   dotnet build
   dotnet run
   ```

5. **Access the Application:**
   Open your web browser and navigate to `http://localhost:5000` (or the port you specified).

## How to Use

1. **Teacher's Perspective:**
   - Log in as a teacher.
   - Create a classroom.
   - Add students to the classroom.
   - Upload study materials (videos, PDFs).

2. **Student's Perspective:**
   - Log in as a student.
   - Access classrooms created by teachers.
   - View and download study materials.

## Contributing

We welcome contributions to this project. If you have any ideas for improvement or want to report issues, please open an [issue](https://github.com/your-repo-url/issues) or submit a [pull request](https://github.com/your-repo-url/pulls).

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

If you have any questions or need assistance, feel free to contact the project maintainers:

- Vraj Shah (CE129): [vrajs2103@gmail.com](mailto:vrajshah@example.com)
- Jai Sarang (CE122): [jaisarang5000@gmail.com](mailto:jaisarang@example.com)

Thank you for using the Digital Classroom Management System! We hope it enhances your teaching and learning experience.
