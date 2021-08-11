# API - Cadastro de Pessoas (CRUD)
#### Status: Concluído.
Projeto de uma API para cadastro de pessoas, incluindo nome, sobrenome, idade e profissão, no qual é possível adicionar, alterar, excluir e consultar os dados que serão manipulados e consumidos no [Projeto de Front-End com Angular](https://github.com/juliocesargama/Angular-CRUD).

## Tecnologias:
- .Net Core (C#);
- [ElephantSQl (Postgres)](https://www.elephantsql.com/) para a persistência dos dados (Vide Ref.);
- Azure Web Application, para deploy da API na nuvem.

## Características:
- Padrão MVC;
- Entity Framework;
- Migrations;
- Npgsql.

## Instruções para a instalação:
Não será necessária instalação, o projeto em funcionamento encontra-se neste [Link](https://api-crud-jcgama.azurewebsites.net/api/persons).


## Referências:
Projeto realizado a partir das aulas do [Thiago Paiva Medeiros](https://github.com/thiagopaivamed) no Youtube, pelo canal [Programação Binária](https://youtube.com/playlist?list=PLTESsx8-vfPnQ-s4jM-jGrYQMOVg7t1u6).

O projeto original utiliza SQL Server, porém o mesmo só se encontra disponível em Ambiente Windows ou servidores enterprise Linux. Para dar continuidade no projeto, foi feita uma adaptação para PostgreSQL com algumas partes do código-fonte encontrado neste [Medium](https://medium.com/@RobertKhou/getting-started-with-entity-framework-core-postgresql-c6fa09681624). 
