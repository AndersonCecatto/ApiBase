# ApiBase
Api Base com cadastro de produtos e categorias

* Neste projeto foi utilizado o DDD como metodologia de desing da aplicação, dividindo em camadas.
* FluentValidation para validar os campos antes de executar os controllers.
* Utilizado o pattern Repository.
* Utilizado o Banco PostgreSql.

---- Script Criação das Tabelas Banco ----

create table "Produto" (
	"Id" INT GENERATED ALWAYS AS IDENTITY,
	"Categoria_Id" int2 null,
	"Descricao" varchar(250) not null,
	"Preco" money,
	"Situacao" bool not null,
	primary key ("Id"),
	constraint fk_categoria foreign key("Categoria_Id") references "Categoria"("Id")
)

create table "Categoria" (
	"Id" INT GENERATED ALWAYS AS IDENTITY,
	"Descricao" varchar(250) not null,
	"Situacao" bool not null,
	primary key ("Id")
)

-----------------------------------------------

* Para utilização da Api será necessário alterar a string de conexão da sua base no caminho appsettings.json -> ConnectionStrings.
