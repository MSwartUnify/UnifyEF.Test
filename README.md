# Unify Entity Framework Test Project

## Entity Framework Core

It is an Object/Relational Mapping (O/RM) framework that gives developers an automated mechanism for accessing & storing data in a database. Like the lightweight ORM Dapper we're using in most of our projects.

EF Core supports two development approaches 1) Code-First 2) Database-First.

***Code-First***  - uses migrations with the entity and configuration classes you provided, these are auto generated files when migrations are enabled in your code. 

***Database-First***  - is very similar to as code first, you will still need to create entity classes and configurations, but this is based on your existing database and migrations will be disabled.




Steps to follow:

1. Instal the NuGet packages
	
	- Entity Framework Core and 
	- Microsoft.EntityFrameworkCore.SqlServer or PostgresSql or whatever database system your using

2. Add the `DbContext` - An instance of `DbContext` represents a session with the database which can be used to query and save instances of your entities to a database.
    
    - To use `DbContext` in our application, we need to create the class that derives from `DbContext`, also known as context class. This context class typically includes [DbSet<TEntity>].
    
    - The `OnModelCreating()` method allows us to configure the model using `ModelBuilder` and use Entity Framework Fluent API. Entity Framework Fluent API is used to configure domain classes to override conventions.
    
    - Add the `ApplyConfigurationsFromAssembly` method to the builder. This will apply all the configuration classes using the interface IEntityTypeConfiguration<TEntity>.

3. Add entity models and configurations classes - These entity models and configuration classes will be using Fluent API.

4. Using Fluent API with the following:
	
	- **Model Configuration**: Configures an EF model to database mappings, for example - HasDefaultSchema() to change use a specific schema.
	
	- **Entity Configuration**: Configures entity to table and relationships mapping, for example - HasKey() sets the primary key.
	
	- **Property Configuration**: Configures property to column mapping, for example - HasMaxLength() sets the max length.

5. Configuring Relationships - Relationships are associations between tables that are created using join statements to retrieve data. This project has a one-to-many relationship example using Fluent API.
