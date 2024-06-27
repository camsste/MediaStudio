# MediaStudio
Gravadora de Música e Vídeos - API RESTful com ASP.NET Core
Este repositório contém um projeto ASP.NET Core que implementa uma API RESTful para gerenciar álbuns de música e vídeos de uma gravadora. Utiliza Swagger para documentação da API e não requer banco de dados para operar, sendo uma implementação simplificada.

Estrutura do Projeto
O projeto está estruturado da seguinte forma:

bash
Copiar código
.
├── MediaStudio/
│   ├── Controllers/         # Controladores da API para álbuns e vídeos
│   ├── Models/              # Definições dos modelos Album e Video
│   ├── Properties/          # Configurações de propriedades do projeto
│   ├── wwwroot/             # Pasta raiz do servidor web (não usada neste projeto)
│   ├── appsettings.json     # Configurações da aplicação
│   ├── Program.cs           # Ponto de entrada da aplicação
│   ├── Startup.cs           # Configuração inicial da aplicação
├── .gitignore               # Arquivos e pastas ignorados pelo controle de versão Git
├── README.md                # Este arquivo, com instruções para o repositório
├── MediaStudio.sln          # Solução do Visual Studio para o projeto
Requisitos
.NET Core SDK - Versão 3.1 ou superior
Visual Studio Code ou Visual Studio
Configuração e Uso
Clonar o Repositório:

bash
Copiar código
git clone https://github.com/seu-usuario/seu-repositorio.git
cd seu-repositorio
Executar a Aplicação:

Abra o terminal na pasta raiz do projeto e execute:

bash
Copiar código
dotnet run --project MediaStudio
Acesse a API pelo navegador ou ferramenta como Postman:

Swagger UI - Documentação interativa da API.
Documentação da API:

Acesse o Swagger em http://localhost:5200/swagger/index.html para explorar os endpoints disponíveis, seus parâmetros e respostas esperadas.
Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues relatando problemas ou sugestões, e pull requests com melhorias.

Licença
Este projeto está licenciado sob a MIT License.
