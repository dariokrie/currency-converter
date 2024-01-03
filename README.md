## Currency Converter Backend Module
- Based on a RESTful web api (ASP.NET MVC)
- SwaggerUI as Interface
- Database access via Entity Framework Core
- Object to Object mapping via AutoMapper
- Written in .NET 8

## Architecture
10 Api (Client Layer)
- CurrencyConverter.Api
	- Controller
		-> Api endpoints are defined here
	- Models
		-> for clean code reasons I created request and response models
	- Profiles
		-> profiles which automapper requires
		
20 Domain
- CurrencyConverter.Domain
	- Models
		-> each entity designed as a domain model
	- Services
		-> business logic
		
30 Data
- CurrencyConverter.Data
	- Entities
		-> database entities which are created with help of entity framework core
	- Repositories
		-> database read/write repositories 
		
## Techstack
- C# .NET8
- MSSQl Server

## Information
Commits and coding history is not tracked on github. The origin of this repository is Azure Devops Repos.