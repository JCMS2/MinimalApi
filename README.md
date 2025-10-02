Minimal API - Seu Gerenciador de Frota Pessoal 🚗💨
Olá! Seja bem-vindo ao projeto! 👋
Esta é uma API construída com ASP.NET Core Minimal APIs, feita para ser rápida e descomplicada. Ela nasceu para resolver um problema simples: como gerenciar administradores e um pequeno cadastro de veículos de forma segura e eficiente, usando tecnologia de ponta (mas sem complicação!).

É o projeto perfeito para quem quer ver o JWT (JSON Web Token) e o Entity Framework Core em ação em um ambiente Minimal API.

🚀 O que move este projeto?
O coração desta API é a simplicidade, mas a segurança é levada a sério.

Segurança em Primeiro Lugar (JWT) 🔐
Esqueça as senhas que viajam por aí! Usamos JWT para garantir que apenas pessoas autorizadas (nossos Administradores e Editores) consigam acessar, criar, ou modificar dados.

Login: Você entra com seu e-mail e senha.

Token: A API te devolve um "crachá digital" (o Token) válido por 24 horas.

Acesso: Você apresenta esse Token em cada requisição para provar quem você é e o que pode fazer.

Quem pode fazer o quê? (Perfis de Acesso) 🦸
Temos dois "cargos" bem definidos:

Administrador (Adm): É o Super-usuário! Pode gerenciar TUDO (outros administradores e veículos).

Editor (Editor): O funcionário dedicado. Pode CRIAR, LER e BUSCAR veículos, mas não pode editar, excluir ou mexer nos administradores.

Nossas Credenciais de Teste (Usuário Padrão)
Para você começar a brincadeira agora mesmo, use este usuário:

Campo	Valor
Email	adm@teste.com
Senha	123456
Perfil	Adm

🛠️ Por baixo do capô (Tecnologias)
ASP.NET Core Minimal APIs: Menos código, mais resultado!

Entity Framework Core (EF Core): Nosso tradutor de C# para banco de dados.

MySQL: Nosso armazém de dados, robusto e confiável.

Swagger: O Playground da API! Lá você pode testar todos os endpoints de forma interativa.

🛣️ Guia Rápido de Rotas (Endpoints)
Todas as rotas são acessíveis e documentadas no /swagger da aplicação. Mas aqui está um resumo do que você pode fazer depois de logar!

1. Administradores (/admonistradores)
Ação	Rota	Quem Pode?	Para que Serve?
Logar	POST /admonistradores/login	TODOS	Pega seu Token de acesso!
Listar	GET /admonistradores	Adm	Vê todos os colegas administradores.
Criar	POST /admonistradores	Adm	Cadastra um novo administrador/editor.

2. Veículos (/veiculos)
Ação	Rota	Quem Pode?	Para que Serve?
Criar	POST /veiculos	Adm, Editor	Adiciona um veículo novo à frota.
Listar	GET /veiculos	Qualquer um logado	Vê toda a frota (com paginação).
Buscar	GET /veiculos/{id}	Adm, Editor	Procura um veículo específico.
Atualizar	PUT /veiculos/{id}	Adm	Corrige dados de um veículo.
Apagar	DELETE /veiculos/{id}	Adm	Remove o veículo da frota.

🖥️ Como colocar para rodar?
Ajuste a Configuração: Dê uma olhada no seu arquivo appsettings.json.

Confirme se a ConnectionStrings:mysql está apontando para o seu banco de dados MySQL (o nome padrão esperado é MinimalApi e a senha root).

Crie as Tabelas: Use o Entity Framework Core para rodar as migrações:

Bash

# Se você estiver no diretório principal do projeto
dotnet ef database update
Ligue o Servidor:

Bash

dotnet run
Pronto! Sua API estará rodando. Acesse a rota inicial para a mensagem de boas-vindas e o link para o Swagger!
