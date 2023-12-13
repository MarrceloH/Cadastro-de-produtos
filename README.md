# Cadastro-de-produtos
Este projeto é um simples programa de estoque de produtos. Ele permite ao usuário adicionar produtos, remover produtos e consultar o estoque atual. O estoque é armazenado em um dicionário, onde a chave é o código do produto e o valor é um objeto Produto.
# Linguagem-utilizada
O código é escrito em C#, que é uma linguagem de programação de tipagem estática desenvolvida pela Microsoft como parte da plataforma .NET.
# o que pode ser feito no código:

Para começar a usar o programa, o usuário deve digitar o código do produto e seguir as instruções fornecidas pelo programa.



1.	Adicionar Produto: Este recurso permite ao usuário adicionar um novo produto ao estoque. Para isso, o usuário deve fornecer o código do produto, o nome, a categoria, o preço e a quantidade a ser adicionada. Se o produto já existir no estoque, o programa exibirá uma mensagem dizendo que o produto já existe . Caso contrário, o produto será adicionado ao estoque e uma mensagem de sucesso será exibida. 

"![AdicionarProduto](https://github.com/MarrceloH/Cadastro-de-produtos/assets/148079101/eb9a3efd-9b22-4323-969f-e9644fea0aad)

2.	Remover Produto: Este recurso permite ao usuário remover um produto do estoque. Para isso, o usuário deve fornecer o código do produto e a quantidade a ser removida. Se a quantidade fornecida for maior do que a quantidade atual do produto, o programa exibirá uma mensagem dizendo quantidade insuficiente em estoque ou se o código digitado estiver errado uma mensagem dizendo produto não encontrado será exibida . Caso contrário, a quantidade especificada será removida do estoque e uma mensagem de sucesso será exibida.

![RemoverProduto](https://github.com/MarrceloH/Cadastro-de-produtos/assets/148079101/67f653ae-e71a-4cbf-a0fc-b3d83ab63fe8)

3.	Consultar Estoque: Este recurso permite ao usuário visualizar todos os produtos presentes no estoque. O programa exibirá uma lista detalhada de todos os produtos, incluindo o código, o nome, a categoria , o preço e a quantidade em estoque.
  
![consultarEstoque](https://github.com/MarrceloH/Cadastro-de-produtos/assets/148079101/40efb6d9-c097-4aca-89b7-86f7746da0fd)

4.	Sair: Este recurso permite ao usuário encerrar a execução do programa. Quando escolhido, o programa exibirá uma mensagem de obrigado e encerrará.

![Sair](https://github.com/MarrceloH/Cadastro-de-produtos/assets/148079101/486c9108-8fe1-494d-a8ba-48eb0ad1e12f)

Caso o usuário digite uma opção inválida, o programa exibirá uma mensagem de erro e o usuário terá a oportunidade de tentar novamente.
Ao longo do programa, o dicionário de estoque é atualizado a cada ação realizada pelo usuário. Portanto, as informações do estoque são sempre atualizadas e consistentes.

