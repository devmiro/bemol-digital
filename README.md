Este projeto detalha processos de BDD utilizando a linguagem Gherkin

Análise do Aplicativo Marvelopédia Versão 0.0.1

Features:

- login
    Scenario:
    - login

- register
    Scenario:
        - register

- checkout
    Scenario:
        - Adicionar produtos
        - Remover produtos
        - Pagamento

Eu escolhi essas funcionalidades e seus fluxos importantes/críticos da aplicação.
O processo de teste de comportamento não levou em conta a experiência do usuário (UX), a interface e padrões de layout (UI), comunicação com a internet (network)

Bugs encontrados

#1 Ao clica no menu "perfil" e depois em "sobre" não fica claro se deveria aparecer informações sobre o perfil do cliente ou do desenvolvedor do aplicativo.

#2 O layout do campo "nome" dos quadrinhos não está centralizado com a imagem

#3 O layout do campo "nome" dos herois não está centralizado com a imagem

#4 O Heroi de nome Ajaxis não possui descrição, nem quadrinhos. Ficando na dúvida se a informação não foi carregada corretamente.

#5 Os Herois que possuem lista de quadrinhos, não fazem referencia ao link para o produto.

#6 Ao escolher um "quadrinho" a quantidade de items "default" está 0 quando deveria ser 1

Outros itens analisados:

Uso de dados do aplicativo
Permissões necessárias
Utilização em segundo plano
Estabilidade do consumo de bateria
Memória do aparelho
Armazenamento utilizado

Gostaria também de ter criado testes automatizados para o aplicativo Android utilizando uiautomator que foi meu trabalho anterior.

### Built With

* .NET Core 5.0
* XUnit
* Selenium

### Prerequisites

This is an example of how to list things you need to use the software and how to install them.
.NET 5.0
```C#
https://dotnet.microsoft.com/download
```
* dotnet
  ```sh
  dotnet run
  ```

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/devmiro/bemol-digital.git
   ```
2. Build and Install Nuget packages
   ```sh
   dotnet build
   ```
3. Run Project
    ```sh
   dotnet run
   ```
4. Run Tests
  ```sh
   dotnet test
   ```

#Postman Collection - ServeRest API

1. Go to Url
  ```sh
   https://web.postman.co/
   ```
2. Import Tests
  ```sh
   import https://github.com/devmiro/bemol-digital/blob/main/BemolQA.Test/ServeAPI.postman_collection.json
   ```

## Participante: 
|name               |email                  |present   |desafio      |
| --------------    | --------------------- | -------- | ----------- |
|Samir Carneiro José|scarneirojose@gmail.com|true      |Bemol Digital|