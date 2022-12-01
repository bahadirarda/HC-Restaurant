🪢 API Folder
---

It is the interface where we make definitions within the framework of certain rules in order to open the service or data we have to the outside world and make it available to other applications-platforms.

🌐 DOMAIN Folder
---

**Entities** and **Repositories** used in the web project are located here.

![](https://learn.microsoft.com/tr-tr/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/media/net-core-microservice-domain-model/ordering-microservice-container.png)
>Microsoft example of usage is in the photo above.

This project, communication with the database is done using **CodeFirst**.

📚 INFRASTRUCTURE Folder
---

The structure that will include the **ORM** structure and the **database-related associations**.
The **Unit of Work **structure specific to this project is also located here.
