# Sistema de Votação Eletrónica (Cliente gRPC)

> **Unidade Curricular:** Integração de Sistemas  

Este projeto consiste numa aplicação web desenvolvida em **Blazor Server (.NET 9)** que atua como cliente para um sistema de votação eletrónica remoto via **gRPC**. A aplicação permite simular o fluxo completo de um eleitor: autenticação, obtenção de credencial, votação anónima e consulta de resultados.

---

## Tecnologias Utilizadas

* **Framework:** .NET 9.0 (Blazor Web App / Server Interactive)
* **Comunicação:** gRPC (Google Remote Procedure Call)
* **Protocolo:** HTTP/2 sobre TLS (HTTPS)
* **Linguagem:** C#

---

## Funcionalidades

A aplicação implementa os seguintes Casos de Uso:

1.  **Obter Credencial (Registo):** Comunica com a *Autoridade de Registo* para validar o CC e obter um token de voto.
2.  **Listar Candidatos:** Obtém a lista dinâmica de candidatos a partir da *Autoridade de Votação*.
3.  **Votar:** Submete o voto utilizando a credencial anónima.
4.  **Consultar Resultados:** Apresenta a contagem de votos em tempo real.
5.  **Health Check:** Verificação automática do estado da conexão ao servidor na Home Page.

---

## Pré-requisitos

Para executar este projeto, necessita de ter instalado:

* [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
* Git

---

## Instalação e Execução

Siga os passos abaixo para clonar e correr a aplicação no seu computador (Windows, macOS ou Linux).

### 1. Clonar o Repositório
Abra o terminal e execute:

```bash
git clone https://github.com/ruipsl95/VotingWebApp/
cd VotingWebApp
```

### 2. Compilar e Executar
Dentro da pasta do projeto (VotingWebApp), execute:

```bash
dotnet build
dotnet run
```
### 3. Aceder à Aplicação
Após o comando anterior, o terminal indicará o endereço local. Abra o browser e aceda a:
http://localhost:5108 (ou a porta indicada no terminal)
