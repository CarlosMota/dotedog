# dotedog

Projeto da matéria MVP da Pós da UEA de Engenharia de Software

## Configuração da API

Verificar a versão que está, a API vai rodar na API 6.0.402

```bash
dotnet --version
```

Crie um arquivo .env

```bash
POSTGRES_DB=postgres
POSTGRES_USER= #Crie um usuário
POSTGRES_PASSWORD= #Crie uma senha
```

Acesse o powershell e use o comando para rodar o docker com a imagem do postgres:12

```bash
docker-compose up -d
```
