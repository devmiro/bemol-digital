Feature: Login
    Scenario: Realizar o login no sistema
Given Eu abro o aplicativo
When Eu escrevo "Joao@gmail.com" no campo "user e-mail"
    And Eu escrevo "1234" no campo "password"
    And Eu aperto o botão "login"
Then Eu deveria ver a página "Quadrinhos"
