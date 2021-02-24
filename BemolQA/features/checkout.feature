Feature: Checkout

    Scenario: Processo de adicionar produtos
Given Eu adiciono itens ao carrinho de compra
When Eu seleciono a quantidade
    And Eu aperto o botão "adicionar"    
Then Eu deveria ver a página "Carrinho"

Scenario: Processo de remover produtos
Given Eu tenho itens no carrinho de compra
When Eu reduzo a quantidade apertando no botão "-"
    And A quantidade de "produto" chegar a 0    
Then Eu deveria ver o produto ser removido do "Carrinho"

Scenario: Processo de pagamento de produtos
Given Eu estou na página "Carrinho" e aperto no botão "Fazer Pagamento"
When Eu completo os campos do "Cartão"
    And Eu aperto o botão "Pagar agora!"    
Then Eu deveria ver o popup "Compra finalizada!"

