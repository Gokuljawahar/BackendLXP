

# LXP

## LXP Backend Code

### Project Description
LXP is a Learning Experience Platform (LXP) designed to enhance the learning journey by providing personalized and engaging learning experiences. This backend codebase supports the core functionalities of the platform.

### Prerequisites
Before you begin, ensure you have met the following requirements:
- **.NET SDK**: Make sure you have the .NET SDK installed. You can download it from [here](https://dotnet.microsoft.com/download).

### Installation

#### Clone the Repository
```bash
git clone https://github.com/Gokuljawahar/BackendLXP.git
```

#### Navigate to the Project Directory
```bash
cd BackendLXP
```

#### Build the Project
Navigate to the project directory and build the project:
```bash
dotnet build
```

#### Navigate to the API Directory
```bash
cd src/LXP.API
```

#### Run the Application
```bash
dotnet watch
```

### Database Setup
Before running the project, you need to set up the database:

1. **Open MySQL**: Ensure you have MySQL installed and running.
2. **Execute SQL Script**: Navigate to the directory containing the SQL script and execute it to set up the database.
   ```bash
   cd D:\Backend\script
   mysql -u root -p LXP < LXP.sql
   ```

### Usage
Once the application is running, you can access the API endpoints to interact with the LXP backend.

### Documentation
To get the information about the code documentation in the browser, use the following command:
```bash
docfx D:\Backend\docfx.json --serve
```

