# CleanArchMvc
Aplicação ASP .NET Core MVC com produtos e categorias que podem ser usados para catálogo de vendas.  Projeto faz parte do curso de Clean Architecture. Prof  Macoratti.
## Camada Domain - obj e recursos usados:

Criação de domínio não anêmico, isolando o domínio do mundo externo de forma que ele seja independente
de todas as outras camadas do projeto e garantir que as entidades sejam sempre válidas.

### Recursos:
- Classe `sealed`;
- Setters `private`;
- Validação do modelo;
- Interfaces para o repositório;
- Testes unitários para o projeto `Domain`;
