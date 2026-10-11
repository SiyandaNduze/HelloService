# HelloService

A small .NET 8 solution demonstrating HTTP communication between an ASP.NET Core Web API and a separate console caller, with Docker configuration for running the services together.

## Projects
- **HelloService** — ASP.NET Core Web API with controller routes and Swagger/OpenAPI in Development.
- **CallerService** — console application that sends an HTTP request to `http://helloservice:8080/`, using the Docker Compose service hostname.

## Tech stack
C# · .NET 8 · ASP.NET Core Web API · HttpClient · Docker Compose · Swagger/OpenAPI

## Prerequisites
- .NET 8 SDK
- Docker Desktop with Docker Compose for containerized execution

## Run locally
```bash
dotnet restore HelloService.sln
dotnet build HelloService.sln
dotnet run --project HelloService/HelloService.csproj
```

The API includes a controller-based WeatherForecast example. In the Development environment, use the Swagger UI URL printed by the application.

## Run with Docker Compose
From the repository root:

```bash
docker compose up --build
```

The caller expects the API to be reachable as `helloservice:8080` inside the Compose network. If you change service names or ports, update the caller and Compose configuration together.

## What it demonstrates
- Separating an API from a client process.
- Making HTTP requests with `HttpClient`.
- Running .NET services in containers.
- Exploring endpoints through Swagger during development.

This is a sample project. Consider adding request timeouts, resilient retries, structured logging, and automated tests before production use.
