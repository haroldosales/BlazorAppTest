# BlazorAppTest

Uma aplicação padrão do template Blazor, com algumas funcionalidades adicionais para prática.
Inclui exemplos de uso do Playwright no ecossistema Microsoft, executando tudo em uma plataforma Linux.
## Funcionalidades

- Aplicação Blazor padrão com componentes interativos.
- Exemplos práticos de funcionalidades adicionais para desenvolvimento.
- Integração com Playwright para testes end-to-end no ecossistema Microsoft.
- Compatibilidade total com plataforma Linux.

## Pré-requisitos

- .NET 6 ou superior
- Node.js (para Playwright)
- Sistema operacional Linux

## Instalação

1. Clone o repositório:
    ```
    git clone https://github.com/hatroldo/BlazorAppTest.git
    cd BlazorAppTest
    ```

2. Restaure as dependências:
    ```
    dotnet restore
    ```

3. Instale as dependências do Playwright:
    ```
    npx playwright install
    ```

## Uso

Para executar a aplicação:
```
dotnet run
```

Acesse em `https://localhost:5001` (ou a porta configurada).

## Testes

Execute os testes com Playwright:
```
npx playwright test
```

## Contribuição

Contribuições são bem-vindas! Abra uma issue ou pull request.

## Licença

Este projeto está sob a licença MIT.