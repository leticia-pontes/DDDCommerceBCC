# DDDCommerceBCC

Este projeto é uma aplicação baseada em **DDD (Domain-Driven Design)**, com as camadas **Presentation**, **Application**, **Domain** e **Infra**.

## Pré-requisitos

Antes de rodar o projeto, certifique-se de ter os seguintes pré-requisitos instalados:

- **.NET 8**.
- **MySQL**.
- **JetBrains Rider** (opcional, mas utilizado para desenvolvimento).

## Estrutura do Projeto

- **Presentation**: Contém a API (camada de apresentação).
- **Application**: Contém a lógica de aplicação (*não foi implementada ainda*).
- **Domain**: Contém as entidades e regras de negócio.
- **Infra**: Contém as implementações de infraestrutura (como o DbContext e acesso ao banco de dados).

## Passos para Executar

### 1. **Clone o Repositório**

Clone o repositório para sua máquina local:

```bash
git clone https://github.com/leticia-pontes/DDDCommerceBCC.git
```

### 2. **Configuração do Arquivo `.env`**

O projeto depende de um arquivo **`.env`** para carregar as configurações do banco de dados e outras variáveis de ambiente.

1. Crie um arquivo `.env` **na raiz do projeto**, fora das pastas `Presentation`, `Application`, `Domain`, `Infra`.

2. No arquivo `.env`, adicione a variável de conexão com o banco de dados:

   ```ini
   DB_CONNECTION_STRING="Server=localhost;Database=ECommerceDB;User=root;Password=123456;"
   ```

   > **Nota**: Altere os valores conforme a configuração do seu banco de dados.

### 3. **Instale as Dependências**

Navegue até a pasta **Presentation** (onde a API está localizada) e execute o comando para restaurar as dependências:

```bash
cd DDDCommerceBCC.Presentation
dotnet restore
```

### 4. **Compile o Projeto**

Compile o projeto para garantir que todas as dependências estejam resolvidas e o código esteja pronto para rodar:

```bash
dotnet build
```

### 5. **Execute a API**

Para rodar a API, execute o seguinte comando:

```bash
dotnet run
```

Isso iniciará a aplicação na URL `https://localhost:5290` (é possível alterar a porta em `DDDCommerceBCC.Presentation.http`, na primeira linha).

### 6. **Testando com Postman ou Swagger**

- Acesse a API pelo **Swagger** em `https://localhost:5290/swagger` (se estiver rodando localmente em desenvolvimento).
- Você também pode testar as rotas da API usando o **Postman** com os endpoints definidos.