Feature: Cadastro
    Scenario: Realizar o cadastro no sistema
Given Eu inicio o processo de cadastro
When Eu escrevo "Joao@gmail.com" no campo "user e-mail"
    And Eu escrevo "1234" no campo "password"
    And Eu repito "1234" no campo "password"
    And Eu aperto o botão "Cadastrar"
Then Eu deveria ver a página inícial
