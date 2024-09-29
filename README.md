# Consume NASA InSight rover Weather Data API

This is a DotNet Core Web API Application. In this repo we consume the rest api exposed by NASA on a daily basis, store the weather data in the database on a daily basis.


# Learning areas

- How to consume external REST API in a C# Web API project?
- How to read the JSON response as a stream?
- How to serialize and deserialize JSON data in Web API Project?
- How to read secrets from azure Key Vault?
- How to create named HTTPClient and consume the same via dependency injection in the controller? This way you can create multiple HTTPClients for external integration and consume the same via dependency injection?
- How to perform CRUD operations via EFCore?

## To Do:
- Host as a background process on azure
- Host the API on azure
- Host the Database in Azure SQL
- Create a Web/Modile client to Consume the data emitted by API (using Blazor WASM)
