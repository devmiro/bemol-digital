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

