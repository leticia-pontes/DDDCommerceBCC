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


## Testando a API com o Postman

Para facilitar os testes da API, siga as instruções abaixo para importar a coleção no Postman e começar a testar os endpoints da API.

### Passos para Importação da Coleção:

1. **Baixe o arquivo da coleção**:
   O arquivo `DDDCommerceBCC.postman_collection.json` está localizado na raiz do repositório.

2. **Abra o Postman**

3. **Importe a coleção**:
   - No Postman, clique no botão **"Import"** no canto superior esquerdo.
   - Selecione a opção **"Upload Files"** e escolha o arquivo `DDDCommerceBCC.postman_collection.json` que você baixou.

4. **Execute os testes**:
   Após a importação, você verá a coleção com todos os endpoints da API. Agora você pode testar os métodos GET, POST, PUT e DELETE para garantir que a API esteja funcionando conforme esperado.

### Nota:
Certifique-se de que a API esteja em execução antes de executar os testes no Postman.
- Se você alterou a porta de execução da API no arquivo `appsettings.json` ou em outro arquivo de configuração (como `DDDCommerceBCC.Presentation.http`), **atualize as URLs no arquivo Postman** para refletir a nova porta.
- Caso esteja usando um ambiente de produção ou outro ambiente remoto, ajuste as variáveis de ambiente no Postman para garantir que as requisições sejam feitas para o endpoint correto.

