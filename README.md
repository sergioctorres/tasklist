# TaskList - CRUD

## Instalações:
- Docker Desktop: https://www.docker.com/products/docker-desktop/
- Postman: https://www.postman.com/downloads/

## Executando o Projeto:
- No path *src*, execute o seguinte comando no PowerShell:

```
docker-compose up
```

- Esse comando irá iniciar a parte de Infra (Banco de Dados PostgreSQL), o projeto de Migrations e a API via containers no Docker;

> **NOTA:** Após finalização da utilização da aplicação é necessário encerrar os containers do Docker

## Request para API:

- Existe um arquivo de Collection do Postman na pasta postman na raíz do projeto, e ele pode ser importado para a aplicação do Postman para realizar as requisições:

    - Users:
        - GetAll

    - Tasks:
        - GetAll
        - GetById
        - Create
        - Update
        - Start
        - End

> **NOTA:** Sugestão de ordenação das requisições da Task:
</br>
1 - Create
</br>
2 - GetById
</br>
3 - Update
</br>
4 - GetById
</br>
5 - Start
</br>
6 - GetById
</br>
7 - End
</br>
8 - GetById
</br>
9 - GetAll
</br>
10 - Delete
</br>
11 - GetAll

</br>
</br>

> **NOTA:** Endereço do Swagger da aplicação após execução: http://localhost:8080/swagger/index.html

## Roadmap:

- Criação de scripts para criação e encerramento dos containers;
- Testes unitários com XUnit;
- Implementação do FluentValidation para validações, removendo Exceptions relacionadas à regra de negócio nas Services;
- Middleware para tratamento de Exceptions, pois exibir a Exception para o usuário pode trazer informações sobre a Infra, então é um item relacionado à Segurança;
- Implementação de Cache distribuído (pensando em escalabilidade) para as consultas mais comuns, e com a possibilidade de invalidar caches caso novos registros tenham sido inseridos ou registros anteriores tenham sido alterados;
- Frontend em Angular 17;
- Implementação de Autenticação;
- Regras de negócio:
    - Atribuição de Tarefa ao Usuário;
    - Consulta de Tarefas por Usuário;
    - Criação de inserção de Time Log relacionado à Tarefa;
    - Prazo máximo para a Tarefa;
    - Notificações, como por exemplo: Prazo máximo se aproximando;
- Deploy na Cloud;