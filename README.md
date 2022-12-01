### 🪢 API Folder


- It is the interface where we make definitions within the framework of certain rules in order to open the service or data we have to the outside world and make it available to other applications-platforms.

#


### 🌐 DOMAIN Folder

- **Entities** and **Repositories** used in the web project are located here.

![](https://learn.microsoft.com/tr-tr/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/media/net-core-microservice-domain-model/ordering-microservice-container.png)
>Microsoft example of usage is in the photo above.

#

### 📚 INFRASTRUCTURE Folder

- The structure that will include the **ORM** structure and the **database-related associations**.
- The **Unit of Work** structure specific to this project is also located here.

>This project, communication with the database is done using **CodeFirst**.

#

### 🖥️ PRESENTATION Folder

- This structure has been prepared for the design of the screen that the client will see.
- It is a UI layer. 
- The relationship with the DTO and the VM is used here in the places belonging to the relevant structure.

#

### 🚀 NUGET Packages required for development

`Only Importants`

- Autofac
- AutoMapper
- FluentValidation
- MailKit
- Microsoft.AspNetCore.Http.Abstractions
- Newtonsoft.Json
- SixLabors.ImageSharp
- SixLabors.ImageSharp.Web
- AutoMapper.Extensions.Microsoft.DependencyInjection
- FluentValidation.AspNetCore
- Microsoft.AspNetCore.Authentication.JwtBearer
- Microsoft.AspNetCore.Authentication.OpenIdConnect
- SwashBuckle.AspNetCore

#





You can find detailed information about architectural configuration https://learn.microsoft.com/en-us/dotnet/architecture/microservices/ here.
