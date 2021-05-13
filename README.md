# Rent
WebApi em C# que realiza um CRUD de endereços no SQLServer consumindo recursos da API do ViaCEP 

# Banco de Dados:
SQLServer

# Como executar o projeto:
* Clone o repositório https://github.com/joaogbsilva/rent.git localmente
* Abra o projeto e vá até o arquivo "appsettings.json" e ajuste o conteúdo da "ConnectionStrings"
* Altere os parâmetros "Server" e se necessário altere também os parâmetros de conexão, como "User ID" e "Password"
* Em seguida, verifique se a porta 44319 está disponível pois nossa aplicação web irá utilizá-la
* Verifique se o serviço do SQLServer está ativo
* Com o projeto aberto no VisualStudio, abra o terminal e execute o comando a seguir para criar o banco de dados:
dotnet ef --startup-project ../RentWebMvc database update
* Execute o comando:
dotnet run
* Execute o comando:
npm install
* Execute o comando:
ng serve

# Acessando a aplicação web
* Acesse: http://localhost:44319
* Clique no botão "Novo Imóvel"
* No campo CEP, basta digitar o CEP desejado que ao trocar de campo, automaticamente os outros campos serão preenchidos com os dados retornados da API ViaCep
* Após o endereço inserido, será possível Editar, Visualizar e Excluir 
