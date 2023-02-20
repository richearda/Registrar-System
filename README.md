# School Registrar System
A web base application for School Registrar.

# Technologies Used
Frontend
- HTML
- CSS/Bootstrap
- JavaScript/jQuery

Backend
- C#.NET 
- MS SQL Server 
- Entity Framework (EF) Core 
- jQuery Ajax



# Screenshots
 Admin | Assistant
----|------
[![Admin Main!](https://i.imgur.com/aMTPnBf.png "Admin Main" )](https://i.imgur.com/aMTPnBf.png) | [![Assistant Main!](https://i.imgur.com/6k8jliT.png "Assistant Main")](https://i.imgur.com/6k8jliT.png)
[![Manage System User!](https://i.imgur.com/ZZn6URp.png "Manage System User")](https://i.imgur.com/ZZn6URp.png) | [![Enroll Student](https://i.imgur.com/VB22V7o.png "Enroll Student")](https://i.imgur.com/VB22V7o.png)
[![Remove subject!](https://i.imgur.com/rVZ8HsN.png "Remove a subject from a block")](https://i.imgur.com/rVZ8HsN.png) | [![Print Masterlist](https://i.imgur.com/DDrCZGs.png "Print Masterlist")](https://i.imgur.com/DDrCZGs.png)

# Run the app on a local machine.
1. Download the project source code.
2. Extract the project folder on your desktop or anywhere you like on your local machine.
3. Open the project folder, you will find two different folders inside the project's folder, the **RegSys-API** and **RegSys-UI**.
4. Open the **RegSys-API** folder, you can find two different folders inside the RegSys-API’s folder, the **Database Backup**, and another **RegSys-API**.
5. Open the Database Backup folder and copy the backup database file.
6. Navigate to **C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\Backup** or **C:\Program Files (x86)\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\Backup** if you have installed a 32-bit version of MS SQL Management Studio.
7. Paste the database file and open your MS SQL Management Studio.
8. Restore the database by locating it in the folder link in step number 6.
9. Once you have successfully restored the database, open the RegSys-API solution in the RegSys-API folder.
10. Change the connection string in the **appsettings.json** and **appsettings.Development.json**
11. Once you have already changed the connection string, launch the API to test.
12. Once everything is working fine, open the RegSys-UI folder and open the project solution.
13. Navigate to **wwwroot** and inside the **js** folder, open the **site.js** file.
14. Inside the **site.js** file, you can find a global variable name **API_URL**, this is the API URL that the UI will be used to call the endpoints using AJAX, you need to change it as exactly as the link of the API that you launch/run in your local machine, or else the UI cannot connect to the database.
15. Once you have changed the API_URL link, launch the project solution and try to log in with the account details below:
### For Admin ###
**Username:** usernameadmin | **Password:** passwordadmin
### For Assistant ###
**Username:** userassistant | **Password:** passwordassistant

## Note ##

If you encountered an error, it might be because you have not followed the instructions carefully or missed some steps. Try to review the steps again.

