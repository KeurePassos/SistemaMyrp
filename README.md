**Sistema Myrp**

Descrição

O **Sistema Myrp** é uma aplicação de gestão de vendas desenvolvida em C# usando Windows Forms. O sistema oferece funcionalidades para gerenciar produtos, clientes e vendas, utilizando um banco de dados MySQL para armazenamento dos dados.

Tecnologias Utilizadas

- **Linguagem de Programação**: C#
- **Framework**: .NET Framework (Windows Forms)
- **Banco de Dados**: MySQL
- **IDE**: Visual Studio Professional 2022

Funcionalidades

1. **Cadastro de Produtos**: Adiciona, edita e remove produtos.
2. **Cadastro de Clientes**: Adiciona, edita e remove clientes.
3. **Registro de Vendas**: Registra vendas associando produtos e clientes.
4. **Menu Principal**: Acesso fácil às funcionalidades de cadastro e vendas.

Estrutura do Projeto

- **Menu.cs**: Formulário principal com botões para acessar os cadastros e vendas.
- **nacionalidade.cs**: Lista estática de nacionalidades.
- **cbxCliente.cs**: Gerencia a seleção de clientes em combo boxes.
- **Cad_Cliente.cs**: Representa a estrutura dos dados de um cliente.
- **DatabaseConnection.cs**: Gerencia a conexão com o banco de dados MySQL e executa consultas.
- **Program.cs**: Inicializa e executa o formulário principal.

Configuração do Banco de Dados

1. **Criação do Banco de Dados**:
   - Crie o banco de dados `sistema_myrp` no MySQL.
   - Crie as tabelas `produtos`, `clientes` e `vendas` conforme a estrutura definida.

2. **Configuração da Conexão**:
   - No arquivo `DatabaseConnection.cs`, ajuste a string de conexão com as credenciais do seu banco de dados MySQL.

Execução

1. **Importe o script SQL** no MySQL Workbench para criar o banco de dados e as tabelas.
2. **Abra o projeto** no Visual Studio.
3. **Compile e execute** o projeto. O formulário principal será exibido, permitindo acessar as funcionalidades do sistema.

Contribuições

Contribuições são bem-vindas. Envie um pull request ou abra uma issue com sugestões e melhorias.
