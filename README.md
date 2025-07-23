# Projeto: Sistema de Gerenciamento de Smartphones com POO em .NET

Este projeto propõe a modelagem de um sistema orientado a objetos para representar diferentes tipos de smartphones. A ideia central é aplicar os conceitos de abstração, herança e polimorfismo, permitindo que celulares de diferentes marcas (como Nokia e iPhone) compartilhem comportamentos comuns, mas com implementações específicas.

## 📋 Descrição

Você deve modelar um sistema que representa diferentes tipos de smartphones, utilizando herança, abstração e polimorfismo.

## 📦 Estrutura

- `Smartphone.cs` - Classe abstrata base.
- `Nokia.cs` - Classe que herda de Smartphone.
- `Iphone.cs` - Classe que herda de Smartphone.
- `Program.cs` - Classe principal com testes.

## 🚀 Como executar

1. Crie um projeto console com o comando:

```bash
dotnet new console -n DesafioPOO
```

2. Substitua os arquivos gerados pelos arquivos deste repositório.
3. Execute com:

```bash
dotnet run
```

## ✅ Saída esperada

```
Testando o Nokia:
Ligando...
Recebendo ligação...
Instalando Snake no Nokia.

-------------------------

Testando o iPhone:
Ligando...
Recebendo ligação...
Instalando Instagram no iPhone.
```

---
