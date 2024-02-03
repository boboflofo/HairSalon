# HairSalon

#### By Jonathan Song

#### Program that takes input to create Stylist and Clients to view and manage

## Technologies Used

* C#
* VScode
* Entity Framework Core
* SQL
* ASP.NET

## Description
Program that asks users to add stylists, and within specific stylists, allow for users to tie clients to that client. Users will be able to view all stylists and their clients, as well as navigate through all the different clients.


## Setup/Installation Requirements

* Navigate to the repository of the named project through this [link](https://github.com/boboflofo/SunshineBakery.git)
* Ensure that the .NET SDK is installed to the latest version [link](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
* Ensure that MySQL is installed to the latest version [link](https://www.mysql.com/)
* Ensure that MySQL workbench is installed to the latest version [link](https://www.mysql.com/products/workbench/)
* On the top right of the screen, navigate to the **fork** button and fork the repository
* For proper database connection, ensure that a MySQL server is running using command **mysql -u(userid) -p(password)**
* Open MySQL workbench and enter the MySQL instance
* In the workbench, navigate to *Navigation > Administration* and *Data Import/Restore*
* Under *Import options* choose *Import from Self-Contained File*
* Choose the file attached to this repository
* Under *Default Schema to be Imported To* click *New* and input the database name and **_test**
* Under *Import Progress* click *Start Import* to import database
* Open a code editor such as VScode and in the terminal **git clone** the project for editing capabilities
* Install dependencies for local project under the Bakery folder using command **dotnet restore**
* Under the projectname folder, create a **appsettings.json** file and add 
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
* Create a **.gitignore** file and add **obj, bin, and appsettings.json** to ensure personal data is not imported to github
* Finally, run the project using command **dotnet run**


## Known Bugs
n/a

## License
MIT License

Copyright (c) [2023] [Jonathan Song]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.