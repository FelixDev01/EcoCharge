# ⚡ EcoCharge API

[![.NET](https://img.shields.io/badge/.NET-10.0-512bd4)](https://dotnet.microsoft.com/)
[![Architecture](https://img.shields.io/badge/Architecture-Clean_Architecture-blue)](#)
[![Design](https://img.shields.io/badge/Design-DDD-green)](#)

A **EcoCharge API** é um sistema de gestão de estações de recarga para veículos elétricos, desenvolvido com foco em escalabilidade, manutenibilidade e padrões de projeto modernos. O projeto simula o ciclo de vida de uma recarga, desde o cadastro da estação até o gerenciamento da potência.

## 🚀 Status do Projeto: Work in Progress (WIP)
Atualmente, a base arquitetural está consolidada, com os fluxos principais de cadastro e consulta de estações operacionais via Swagger.

---

## 🏗️ Arquitetura e Tecnologias

O projeto foi construído seguindo os princípios da **Clean Architecture** e **DDD**, dividido nas seguintes camadas:

- **Domain**: Onde residem as Entidades (EstacaoRecarga), Regras de Negócio e Exceptions de Domínio. Livre de dependências externas.
- **Application**: Orquestra os fluxos da aplicação através de Services e DTOs, garantindo o desacoplamento.
- **Infrastructure**: Implementação da persistência de dados utilizando **Entity Framework Core**.
    - **Fluent API**: Utilizado para o mapeamento das entidades, mantendo o domínio limpo de atributos de infraestrutura.
    - **Repository Pattern & Unit of Work**: Gerenciamento atômico de transações.
- **API**: Porta de entrada ASP.NET Core configurada com Injeção de Dependência nativa e documentação via **Swagger/OpenAPI**.

---

## 🛠️ Tecnologias Utilizadas

- **C# / .NET 10**
- **Entity Framework Core (In-Memory)**
- **Swagger UI**
- **Fluent API** para mapeamento de banco de dados.

---

## 🚦 Como rodar o projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/FelixDev01/EcoCharge-API.git
   ```

2. Entre na pasta do projeto API:
   ```bash
   cd EcoCharge/API
   ```

3. Execute a aplicação:
   ```bash
   dotnet run
   ```

4. Acesse a documentação interativa:
   ```bash
   https://localhost:5000/swagger
   ```
   
