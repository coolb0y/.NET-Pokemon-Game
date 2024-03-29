# .NET Pokemon Game

- To run this program, you should have SQL installed and running.
- Now we need to seed the SQL table, so run these commands in PowerShell:

```powershell
dotnet ef migrations add InitialCreate
dotnet ef database update
```
- the above command will see the table. 
- Now we can run our code.