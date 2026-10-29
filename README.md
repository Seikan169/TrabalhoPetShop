# PetShop Mundo Animal 🐾

Sistema de gerenciamento de pet shop composto por uma API REST e duas aplicações desktop Windows Forms. O projeto centraliza o cadastro de clientes e animais, a consulta de serviços, o agendamento de atendimentos e o acompanhamento administrativo, reduzindo o controle manual de pedidos e informações do negócio.

## 🚀 Features principais

- **Cadastro e acesso por perfil:** cadastro de clientes com endereço, validação de dados no formulário e login com redirecionamento para as áreas de cliente, funcionário ou administrador.
- **Consulta de endereço por CEP:** preenchimento de endereço usando o serviço público ViaCEP.
- **Gestão de pets:** cadastro, listagem, edição e exclusão dos animais vinculados ao cliente.
- **Serviços do pet shop:** listagem e pesquisa dos serviços cadastrados, com descrição, preço e tempo estimado.
- **Agendamento de pedidos:** seleção do pet, inclusão de serviços em um carrinho, escolha de data/horário e envio do pedido à API. Novos pedidos são criados com status pendente.
- **Formas de pagamento na interface:** Pix, dinheiro, débito e crédito. A tela Pix gera QR Code e código copia e cola, mas a confirmação exibida é simulada; não há integração com gateway ou instituição financeira.
- **Painel do funcionário:** visualização da fila de atendimentos por status (pendente, em andamento, concluído ou cancelado) e atualização do status com identificação do funcionário.
- **Painel administrativo:** cadastro de funcionários e administradores, consulta de clientes e funcionários, histórico geral de agendamentos, indicadores financeiros e gráfico de status dos pedidos.
- **Relatório gerencial:** exportação de relatório financeiro e de serviços para planilha Excel.
- **API REST:** endpoints para autenticação/cadastro, pets, serviços e pedidos, com documentação Swagger disponível durante a execução da API.

## 🛠 Tecnologias Utilizadas

- **C# e .NET 9**.
- **ASP.NET Core Web API** para a API REST.
- **Windows Forms** para as interfaces desktop — os projetos de interface têm como alvo `net9.0-windows`.
- **MySQL 8.0.36** como banco de dados, acessado por **Entity Framework Core 9** e **Pomelo.EntityFrameworkCore.MySql**.
- **BCrypt.Net-Next** para hash de senhas.
- **Newtonsoft.Json** para serialização e consumo de respostas HTTP.
- **QRCoder** para geração de QR Codes Pix na interface.
- **ClosedXML** para geração de planilhas Excel.
- **WinForms.DataVisualization** para gráficos no painel administrativo.
- **Swagger / Swashbuckle** para explorar a API.
- **ViaCEP** para consulta de endereço por CEP.

As dependências NuGet são declaradas nos arquivos `.csproj` e restauradas com o .NET CLI ou Visual Studio.

## 📋 Pré-requisitos

- **Windows 10 ou 11** para executar as aplicações Windows Forms.
- **SDK do .NET 9** instalado. Confira com `dotnet --list-sdks`.
- **Visual Studio** com as cargas de trabalho **Desenvolvimento para desktop com .NET** e **ASP.NET e desenvolvimento Web**, ou editor e .NET CLI equivalentes.
- **Git** para clonar o repositório.
- **MySQL Server 8.0.36** (ou versão compatível) e um banco com o schema esperado pela aplicação.
- Acesso à internet para restaurar pacotes NuGet e, quando utilizado, consultar o ViaCEP ou a API publicada.

> **Importante:** o repositório não contém migrations do Entity Framework nem um script SQL de criação do schema. A API também não cria automaticamente as tabelas. Antes de executar a API localmente, providencie um banco com as tabelas e colunas compatíveis com as entidades em `Mysql.PetShop/Models`.

## 🔧 Instalação e Execução

### 1. Clone o repositório

```powershell
git clone https://github.com/Seikan169/TrabalhoPetShop.git
cd TrabalhoPetShop
```

### 2. Restaure as dependências

```powershell
dotnet --list-sdks
dotnet restore .\TrabalhoPetShop.slnx
```

### 3. Configure o banco de dados

Crie/provisione o banco MySQL e o schema compatível com as entidades da API. Em seguida, defina a connection string apenas no ambiente local. O exemplo abaixo vale para a sessão atual do PowerShell; substitua usuário e senha pelos valores do seu MySQL:

```powershell
$env:ConnectionStrings__DefaultConnection = "Server=localhost;Port=3306;Database=PetShop;User ID=petshop;Password=SUA_SENHA;"
```

Não coloque credenciais no README, no código-fonte ou em arquivos versionados. O arquivo `Mysql.PetShop/appsettings.Development.json` contém configuração de conexão rastreada pelo repositório; antes de publicar ou reutilizar essas credenciais, remova-as do controle de versão e faça a rotação da senha. A variável de ambiente acima substitui a configuração `ConnectionStrings:DefaultConnection` no processo da API.

### 4. Inicie a API

O perfil `http` configurado no projeto executa a API em `http://localhost:5280`:

```powershell
dotnet run --project .\Mysql.PetShop\Mysql.PetShop.csproj --launch-profile http
```

Com a API em execução, acesse o Swagger em [http://localhost:5280/swagger](http://localhost:5280/swagger). Mantenha esse terminal aberto enquanto usar a API.

### 5. Execute a aplicação desktop

Em outro terminal, inicie o projeto que contém o fluxo de login e abre as telas de cliente, funcionário e administrador:

```powershell
dotnet run --project .\Shop.TelaFuncionarios\Shop.TelaFuncionarios.csproj
```

Também é possível abrir `TrabalhoPetShop.slnx` no Visual Studio, definir `Shop.TelaFuncionarios` como projeto de inicialização para a interface e iniciar `Mysql.PetShop` separadamente como API. É necessário ter um usuário cadastrado no banco para entrar; a tela inicial oferece cadastro de cliente.

> **Execução totalmente local:** os clientes WinForms usam endereços de API definidos diretamente no código e, por padrão, apontam para a API hospedada. Para usar a instância local, atualize a URL base em `Tela.Cliente/ApiService.cs` e em `Shop.TelaFuncionarios/TelaPrincipalADM.cs` para `http://localhost:5280` (preserve a barra final no endereço usado pelo painel administrativo). Acesse a interface somente depois de iniciar a API.

## 📁 Estrutura do Projeto

```text
TrabalhoPetShop/
├── TrabalhoPetShop.slnx
├── Mysql.PetShop/
│   ├── Controllers/       # Rotas de autenticação, pets, serviços e pedidos
│   ├── Data/              # Contexto do Entity Framework Core
│   ├── Models/            # Entidades e DTOs da API
│   ├── Properties/        # Perfis de execução
│   ├── Program.cs         # Configuração e inicialização da API
│   └── appsettings*.json  # Configurações da API
├── Tela.Cliente/
│   ├── Resources/         # Recursos visuais
│   ├── ApiService.cs      # Comunicação HTTP com a API e ViaCEP
│   ├── Tela_Cliente.cs    # Área do cliente, pets e agendamentos
│   ├── TelaPagamento.cs   # Seleção da forma de pagamento
│   └── GeradorPix.cs      # Montagem do payload e QR Code Pix
└── Shop.TelaFuncionarios/
	├── Properties/        # Recursos e perfis de execução
	├── Resources/         # Recursos visuais
	├── Program.cs         # Inicialização do fluxo de login
	├── TelaLogin.cs       # Login e direcionamento conforme o perfil
	├── TelaFuncionariocs.cs # Fila e atualização de atendimentos
	└── TelaPrincipalADM.cs # Dashboard, gestão e relatórios administrativos
```

### Projetos da solução

- **`Mysql.PetShop`** — API ASP.NET Core, controllers, entidades, contexto EF Core e conexão com MySQL.
- **`Tela.Cliente`** — telas e recursos para cadastro e atendimento ao cliente, além do serviço de integração HTTP usado pelas interfaces.
- **`Shop.TelaFuncionarios`** — executável Windows Forms com login, telas de funcionário e painel administrativo; também referencia os projetos de API e cliente.

## 🤝 Como contribuir

1. Faça um fork deste repositório no GitHub.
2. Crie uma branch para sua alteração:

   ```powershell
   git checkout -b feat/minha-alteracao
   ```

3. Faça as alterações e valide a compilação:

   ```powershell
   dotnet build .\TrabalhoPetShop.slnx
   ```

4. Envie os commits para seu fork e abra um Pull Request para a branch principal deste repositório. Descreva o problema resolvido, as mudanças realizadas e como foram verificadas.
5. Não inclua senhas, connection strings reais, dados pessoais ou outros segredos nos commits.

## 📝 Licença

**Placeholder:** este projeto pretende utilizar a licença **MIT**. Adicione um arquivo `LICENSE` com o texto da licença e os dados do titular antes de considerar a licença formalmente definida.
