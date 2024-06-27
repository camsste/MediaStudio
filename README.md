# Gravadora de Música e Vídeos - MediaStudio

Este repositório contém um projeto ASP.NET Core que implementa uma API RESTful para gerenciar álbuns de música e vídeos de uma gravadora. Utiliza Swagger para documentação da API e não requer banco de dados para operar, sendo uma implementação simplificada.

## Requisitos

- [.NET Core SDK](https://dotnet.microsoft.com/download) - Versão 3.1 ou superior
- [Visual Studio Code](https://code.visualstudio.com/) ou [Visual Studio](https://visualstudio.microsoft.com/)

## Configuração e Uso

1. **Clonar o Repositório:**

   ```bash
   git clone https://github.com/seu-usuario/seu-repositorio.git
   cd seu-repositorio

2. **Executar a Aplicação:**
Abra o terminal na pasta raiz do projeto e execute:
   
     ```bash
     dotnet run --project MediaStudio

## Como usar

1. **Criando e Atualizando Registros:**

Para criar novos vídeos ou álbuns, faça uma requisição POST para /api/video ou /api/album com os dados no corpo da requisição.
Para atualizar um vídeo ou álbum existente, faça uma requisição PUT para /api/video/{id} ou /api/album/{id} com os novos dados no corpo da requisição e o id do vídeo ou álbum a ser atualizado na URL.


2. **Listando Registros:**

Para listar todos os vídeos ou álbuns, faça uma requisição GET para /api/video ou /api/album.
Para obter um vídeo ou álbum específico, faça uma requisição GET para /api/video/{id} ou /api/album/{id} com o id correspondente na URL.


3. **Removendo Registros:**

Para excluir um vídeo ou álbum, faça uma requisição DELETE para /api/video/{id} ou /api/album/{id} com o id do vídeo ou álbum a ser removido na URL.
    
## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues relatando problemas ou sugestões, e pull requests com melhorias.

## Licença

Este projeto está licenciado sob a MIT License.
