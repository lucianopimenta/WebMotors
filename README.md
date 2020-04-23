# WebMotors
No projeto de teste foi usado o EntityFrameworkCore.

Para criar o banco, siga os seguintes passos:

1. Selecione o projeto API como o projeto inicial (Set as StartUp Project)

2. Abra o Console do Package Manager (menu Tools > NuGet Package Manager > Package Manager Console)
  Em Default project, selecione o projeto Data
  Digite o comando: update-database

3. Caso já exista um banco com a respectiva tabela do teste, basta apontar o banco no arquivo appsettings.json, seção ConnectionStrings

Na pasta POstMan, o CRUD do teste no formato do PostMan (para chamar os EndPoints)


Versões das ferramentas
- Visual Studio 2019 Community 16.4.6
- SQL Server Express 2014 12.0
