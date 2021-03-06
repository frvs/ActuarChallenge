# Actuar Challenge
# https://actuar-api.herokuapp.com/swagger/index.html

## Notas
- Para usar o SqlServer, modifique em Startup.cs.
```cs
services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));
/// services.AddDbContext<DataContext>(options => options.UseInMemoryDatabase("c1"));
```
- Para rodar em Docker, use o [Dockerfile](./src/Actuar/Api/Dockerfile).
## Endpoints
```
GET api/v1/products  
GET api/v1/products/{id: string}  
GET api/v1/products/{date: datetime}  
POST api/v1/products {products: product[]}  
DELETE api/v1/products {products: product[]}
```
## Requisitos
<details>
<summary>Ver mais</summary>  
    
#### Fazer um sistema de controle de estoque.    
- Dar entrada em um ou mais produtos  
- Dar saida em um ou mais produtos  
- Saber estoque atual de todos os produtos  
- Saber total em estoque por produto 
- Saber o estoque de um momento especifico  
#### Especificações 
- Deve ser implementado em .Net ou .Net Core
- Deve ter conexão com SQL Server ou MongoDB
- Não é necessario criar o Front
#### Diferencial
- Solid, DRY, KISS
- Clean Code
- DDD, TDD
- Docker
- Event-driven
</details>
