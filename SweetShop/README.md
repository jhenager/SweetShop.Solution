# Pierre's Sweet Shop - 

#### C# and Database project for Epicodus, 08.14.2020

## James Henager

## Description



This project uses C#, MySQL, Entity Framework, Microsoft Identity, and MVC to create a web interface that will allow the user to add treats and assign a number of flavors to them if they have an account and are logged in. The interface will achieve this by utilizing a MySQL database along with Identity authorization.

## Specifications

| Behavior | Input | Output |  
| -------- | ----- | ------ | 
| Create an object called Treat with properties for name and flavors |  |  | 
| Create an object called Flavor with properties for name and treats | | | 
| Allow users to create a new Treat object through a user interface |  |  |
| Allow users to edit a Treat through a user interface |  |  |
| Allow users to delete a Treat through a user interface |  |  |
| Create a database with tables for Treat and Flavor objects using Entity Framework and code first development and database migrations | | | 
| Maintain a many-to-many relationship between Treat and Flavor objects via a joing table | | | 
| Allow users to create a new join relationship between an Treat and a Flavor from the Treat Details page | | | 
| Allow users to create an account and log-in to it | | | 
| Permit access to Create, Edit and Delete routes to logged-in users only | | | 

## Setup/Installation Requirements

**Requirements:**
* [.NET Core SDK 2.2](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer)
* [MySQL Server 8.0.19](https://dev.mysql.com/downloads/file/?id=484919)
* [MySQL Workbench 8.0.19](https://dev.mysql.com/downloads/file/?id=484919)
* Entity Framework

**To use this program:**

1. Open your preferred browser.
2. Navigate to https://github.com/jkbutserious/SweetShop.Solution.git.
3. Click the **Code** button and click **Download ZIP** to clone the repository to your computer.
4. Open the Windows PowerShell console, VS Code Bash terminal, or the MacOS Terminal and use the ``cd [YOUR DOWNLOAD FILEPATH]/SweetShop.Solution/SweetShop`` command to navigate to the SweetShop subdirectory.
5. Use the ``dotnet restore`` command to install the necessary packages on your computer.
6. Use the ``dotnet run`` command to run the program.
7. Use the web interface to add Treats and keep track of Pierre's many flavors.
8. Ensure that the following code is present in your *appsettings.json* file:

    ```
    {
      "ConnectionStrings": {
          "DefaultConnection": "Server=localhost;Port=3306;database=james_henager;uid=root;pwd=epicodus;"
      }
    }
    ```

9. If you have any issues running this program, please reach out to the developer or troubleshoot at your own risk.

To recreate the database using MySQL and Entity Framework Core:

_**Note**: These instructions assume that you have installed and set up your MySQL Server according to Epicodus's guidelines, as well as Entity Framework Core. For more information, see [Installing and Configuring MySQL](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql) and [Configuration for Entity Framework Core](https://www.learnhowtoprogram.com/c-and-net/database-basics-c2449db9-5bd8-4303-af8d-7ed7259f79a7/configuration-for-entity-framework-core)._

1. Open Windows PowerShell, the MacOS Terminal, or your VS Code terminal and use the command ``cd [YOUR DOWNLOAD FILEPATH]/SweetShop.Solution``.
2. Ensure that the Migrations folder is included in your cloned repository.
3. Use the ``dotnet ef database update`` command to apply the latest database migration.
4. Use MySQL Workbench or your preferred terminal to verify the database schema.

**To contribute to this project:**

1. Open your preferred browser.
2. Navigate to https://github.com/jkbutserious/SweetShop.Solution.
3. Log into or sign up for your GitHub account.
4. Click the **Fork** button to copy the repository and all source code.
5. From your forked repository, you can download or clone the repository, by clicking the **Code** button.
  * To clone the repository in Visual Studio Code's terminal, use the command

    ```git clone https://github.com/[YOUR-USER-NAME-HERE]/SweetShop.Solution```
  * To clone the repository in GitHub Desktop, click the **Open in Desktop** option
  * To download the repository, click the **Download ZIP** option, save the archive to your computer, and extract it to the folder of your choice
6. Use your preferred code editor to edit the appropriate model and view files. New classes should be added in the Models subdirectory and should use the ``SweetShop.Models`` namespace. **Note**: the SweetShop.csproj file is a C# project file and should not be edited.
7. Use the ``dotnet ef migrations add [YOUR MIGRATION NAME HERE]`` to add a new database migration. 

    You can also export your database schema from MySQL Workbench by using the **Data Export** option on the **Administration** tab of your database, select the schema you want to export, select the **Dump Structure and Data** option from the dropdown menu, and click the **Start Export** button. Make sure to name the file _james_henager.sql_ and add the file to your repository in the top-level directory.
8. Save any changes you make in your code editor and use your preferred git solution to commit your changes.
9. Push your changes to your forked repository.

#### Additional Setup/Installation Notes:

* No additional code is necessary to view this project.   

## Known Bugs

_No known issues. Please contact me if you have any problems._


## Support and contact details

To report any issues with this page or to contribute to this project, contact James Henager at jameschenager@gmail.com.

## Technologies Used

* C#
* .NET Core 2.2
* MySQL Server 8.0.19
* MySQL Workbench 8.0.19
* Entity Framework
* Microsoft Identity
* MVC
* Visual Studio Code 
* Git and Git BASH 


### License

Copyright © 2020 James Henager

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.