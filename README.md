## Sobre o Projeto

Neste projeto, criei uma API que realiza operações CRUD (Create, Read, Update, Delete) para agendamento de tarefas, conectada a um banco de dados SQL Server. A API permite:

- **Cadastrar Tarefas:** Adicionar novas tarefas ao banco de dados.
- **Atualizar Tarefas:** Editar as informações de tarefas já existentes.
- **Excluir Tarefas:** Remover tarefas do banco de dados.
- **Visualizar Tarefas:** Listar todas as tarefas cadastradas.

## Tecnologias Utilizadas

- **ASP.NET Core:** Framework utilizado para desenvolver a API.
- **SQL Server:** Banco de dados utilizado para armazenar os dados das tarefas.
- **Entity Framework Core:** ORM ( Object-Relational Mapping ) utilizado para facilitar a interação com o banco de dados.
- **Swagger:** Ferramenta utilizada para documentação e testes da API.

## Funcionalidades

1. **Cadastro de Tarefas:**
   - Endpoint para adicionar novas tarefas.
   - Validação de dados no lado do servidor.

2. **Atualização de Tarefas:**
   - Endpoint para editar informações das tarefas existentes.
   - Validação de dados no lado do servidor.

3. **Exclusão de Tarefas:**
   - Endpoint para remover tarefas do banco de dados.
   - Confirmação de exclusão para evitar remoções acidentais.

4. **Listagem de Tarefas:**
   - Endpoint para visualizar todas as tarefas cadastradas.
