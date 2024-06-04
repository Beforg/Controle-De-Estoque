# Controle de Estoque

Aplicativo Windows Forms feito em C# no Visual Studio 2022, utilizando o SQL Server 2019 LocalDB.

[Link para download](https://drive.google.com/file/d/1_ouAH-1JQ1wa3WEeztHgvYyv6HkxjYFn/view?usp=drive_link)

![](https://github.com/Beforg/assets/blob/main/cde-csharp/inicial.png?raw=true)

## Sobre:

Projeto real desenvolvido para atender o controle de estoque dos itens do Almoxarifado, tendo a aplicação funções para Cadastrar, Editar, Remover, Buscar, dar Entrada e Saída de produtos.

### Estrutura do Projeto:

`BibliotecaEstoque`: Biblioteca de Classes onde se encontra o Banco de dados¹ e modelos da aplicação.<br>
`Controle de Estoque`: Solução principal do projeto, onde estão os Formulários e Controle de Usuário.<br>
`Controle de Estoque.Resources`: Arquivos resources do projeto, como imagens ou icones;<br>
`Controle de Estoque.Utils`: códigos de métodos úteis para manipular a aplicação e validações;<br>
`Controle de Estoque.View`: Arquivos de Formulários e Controle de usuários;<br>

¹Banco de dados do release fica dentro do diretório onde se encontra o .exe do projeto.

## Funcionalidades:

### Cadastro de Produtos:

Podemos efetuar o cadastro de produtos, inserindo as informações obrigatórias: Código (Primary Key), Marca e Modelo, a Quantidade Inicial e Descrição ficam opcionais.

![](https://github.com/Beforg/assets/blob/main/cde-csharp/cadastro.png?raw=true)

### Listagem de todos os Produtos:

Podemos buscar no sistema todos os produtos cadastrados, apresentando as informações de cada produto na tela:

![](https://github.com/Beforg/assets/blob/main/cde-csharp/buscatodos.png)

### Alterar Produtos:

Podemos editar qualquer produto, trocando a Marca, Modelo ou Descrição, a Quantidade pode ser arrumada na aba de *Controle* dando **Entrada ou Saída** de produtos.

![](https://github.com/Beforg/assets/blob/main/cde-csharp/editar.png?raw=true)

### Remover Produtos:

Podemos efetuar a exclusão de Produtos na aba *Remover*:

![](https://github.com/Beforg/assets/blob/main/cde-csharp/remover.png)

### Entrada e Saída de Produtos:

Podemos incrementar ou diminuir os itens do estoque de acorda com a necessidade, sendo inserido o Código do produto e o Valor de Entrada/Saída desejado. As lógicas de Validações ficam na classe `Validacao.cs`

![](https://github.com/Beforg/assets/blob/main/cde-csharp/entrada.png)
![](https://github.com/Beforg/assets/blob/main/cde-csharp/saida.png)

### Busca individual:

Podemos também buscar itens individualmente inserindo o Código do item, o retorno será as informações do Produto.

![](https://github.com/Beforg/assets/blob/main/cde-csharp/buscaindividual.png?raw=true)

## Considerações Finais:

Projeto desenvolvido em C#, feito com intuito de atender as necessidades do Estoque do Almoxarifado de uma Empresa. Se quiser clonar o repositório na sua máquina, troque a string de conexão do Database para o caminho do seu computador onde está localizado a BibliotecaEstoque\Database\database.mdf.<br>
Lembrando que será necessário e, de preferência, mudar o caminho da conexão para dentro da pasta onde se encontra o executável quando for fazer o Release do projeto.

### 2024 Bruno Forgiarini | @Beforg
