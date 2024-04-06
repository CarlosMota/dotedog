# dotedog

Projeto da matéria MVP da Pós da UEA de Engenharia de Software

## Criação do banco de dados

Crie um arquivo .env

```bash
POSTGRES_DB=postgres
POSTGRES_USER= #Crie um usuário
POSTGRES_PASSWORD= #Crie uma senha
POSTGRES_HOST= #Se for usar o docker usa localhost
POSTGRES_PORT= #Porta do postgres geralmente 5432
POSTGRES_DB_SCHEMA= #Banco de dados criado no schema
CONNECTION_STRING=Host=${POSTGRES_HOST};Port=${POSTGRES_PORT};Database=${POSTGRES_DB_SCHEMA};Username=${POSTGRES_USER};Password=${POSTGRES_PASSWORD};

```

Acesse o powershell e use o comando para rodar o docker com a imagem do postgres:12

```bash
docker-compose up -d
```

## Configuração da API

Verificar a versão que está, a API vai rodar na API 6.0.402

```bash
dotnet --version
```

Execute o comando para instalar os pacotes nugets

```bash
dotnet restore
```
