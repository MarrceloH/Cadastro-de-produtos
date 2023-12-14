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

# Funções e Métodos por Categoria:

1. Entrada/Saída (Console):
Console.WriteLine():

Descrição: Exibe mensagens no console.
Utilização: Mensagens informativas, cabeçalhos do menu, feedback para o usuário.
Console.ReadLine():

Descrição: Lê a entrada do usuário do console.
Utilização: Obtém a opção do usuário, códigos de produtos, quantidades, etc.
Console.Write():

Descrição: Exibe uma mensagem no console sem quebra de linha.
Utilização: Solicitação de escolha de opção do usuário.
Console.Clear():

Descrição: Limpa o console.
Utilização: Melhora a apresentação visual, limpando o console antes de exibir novas informações.

2. Manipulação de Dados:

Dictionary<string, Produto>:

Descrição: Estrutura de dados para armazenar produtos no estoque.
Utilização: Armazena os produtos, onde o código do produto é a chave.
AdicionarProduto():

Descrição: Adiciona um novo produto ao estoque.
Utilização: Solicita informações do produto ao usuário e adiciona ao dicionário.
RemoverProduto():

Descrição: Remove uma quantidade específica de um produto do estoque.
Utilização: Solicita o código do produto e a quantidade a ser removida ao usuário.
ConsultarEstoque():

Descrição: Exibe as informações de todos os produtos no estoque.
Utilização: Itera sobre o dicionário e exibe os detalhes de cada produto.

3. Controle de Fluxo (Loop e Switch):

Main():
Descrição: Função principal do programa, contém um loop infinito para manter o menu ativo.
Utilização: Gerencia as opções do usuário e chama as funções correspondentes.

4. Feedback ao Usuário:

Console.WriteLine("Saindo do programa. Obrigado!"):

Descrição: Mensagem de despedida ao usuário.
Utilização: Informa ao usuário que o programa está sendo encerrado.
Console.WriteLine("Opção inválida. Tente novamente."):

Descrição: Mensagem de erro para opção inválida.
Utilização: Feedback ao usuário quando uma opção inválida é inserida.

5. Validação:

if (estoque.ContainsKey(codigo)):

Descrição: Verifica se um produto com o código especificado já está no estoque.
Utilização: Evita adicionar produtos duplicados.
if (quantidade <= estoque[codigo].Quantidade):

Descrição: Verifica se há quantidade suficiente em estoque antes de remover.
Utilização: Garante que não seja removida uma quantidade maior do que a disponível.

6. Modularização:

AdicionarProduto():

Descrição: Função separada para adicionar um novo produto, promovendo modularidade.
Utilização: Adiciona um produto ao estoque.
RemoverProduto():

Descrição: Função separada para remover um produto, promovendo modularidade.
Utilização: Remove uma quantidade específica de um produto do estoque.
ConsultarEstoque():

Descrição: Função separada para consultar o estoque, promovendo modularidade.
Utilização: Exibe as informações de todos os produtos no estoque.

7. Exceções:

int.Parse(Console.ReadLine()):

Descrição: Converte a entrada do usuário para um inteiro.
Utilização: Converte a quantidade e códigos do produto inseridos pelo usuário.
double.Parse(Console.ReadLine()):

Descrição: Converte a entrada do usuário para um número decimal.
Utilização: Converte o preço do produto inserido pelo usuário.
Essas categorias ajudam a entender o propósito e a função de cada parte do código, proporcionando uma visão mais clara da estrutura do programa.
