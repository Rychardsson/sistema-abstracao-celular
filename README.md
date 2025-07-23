# 📱 Projeto: Sistema de Gerenciamento de Smartphones com POO em .NET

Este projeto propõe a modelagem de um sistema orientado a objetos para representar diferentes tipos de smartphones. A ideia central é aplicar os conceitos de abstração, herança e polimorfismo, permitindo que celulares de diferentes marcas (como Nokia e iPhone) compartilhem comportamentos comuns, mas com implementações específicas.

## 📋 Descrição

Você deve modelar um sistema que representa diferentes tipos de smartphones, utilizando herança, abstração e polimorfismo.

## 🆕 Melhorias Implementadas

### ✨ Funcionalidades Adicionais

- **Validação de entrada**: Todas as propriedades possuem validação
- **Lista de aplicativos**: Cada smartphone mantém uma lista de apps instalados
- **Funcionalidades específicas**: Nokia com jogo Snake, iPhone com Siri e App Store
- **Interface ISmartphoneFeatures**: Define contrato comum para funcionalidades
- **Encapsulamento**: Propriedades protegidas com getters/setters adequados
- **Métodos virtuais**: Permitem personalização nas classes filhas
- **Tratamento de exceções**: Validações robustas e mensagens claras

### 🏗️ Arquitetura Melhorada

- **Abstração**: Classe base Smartphone com métodos abstratos e virtuais
- **Herança**: Nokia e iPhone herdam comportamentos da classe base
- **Polimorfismo**: Implementações específicas para cada marca
- **Encapsulamento**: Dados protegidos com acesso controlado
- **Interface**: ISmartphoneFeatures define contratos comuns

### � Melhorias Técnicas

- **Atualizado para .NET 8.0**
- **Nullable reference types habilitado**
- **Warnings tratados como errors**
- **Documentação XML nos métodos**
- **Nomes descritivos e convenções C#**

## 📦 Estrutura

- `Smartphone.cs` - Classe abstrata base com validações e métodos virtuais
- `Nokia.cs` - Classe Nokia com jogo Snake e funcionalidades específicas
- `Iphone.cs` - Classe iPhone com App Store e Siri
- `ISmartphoneFeatures.cs` - Interface definindo funcionalidades comuns
- `Program.cs` - Classe principal com demonstração completa

## 🚀 Como executar

1. Certifique-se de ter o .NET 8.0 ou superior instalado
2. Clone ou baixe este repositório
3. Execute no terminal:

```bash
dotnet run
```

## ✅ Saída esperada

```
📱 SISTEMA DE GERENCIAMENTO DE SMARTPHONES 📱
==================================================

🔶 TESTANDO NOKIA 🔶
📱 Informações do Smartphone:
   Modelo: Nokia 3310
   Número: 11987654321
   IMEI: 111111111111111
   Memória: 64GB

🔊 Nokia Nokia 3310 ligando com som clássico...
🎵 Nokia Nokia 3310 recebendo ligação com toque Nokia Tune...
📦 Instalando Snake no Nokia Nokia 3310.
✅ Snake instalado com sucesso!
📦 Instalando Calculadora no Nokia Nokia 3310.
✅ Calculadora instalado com sucesso!
📴 Desligando Nokia 3310...

🐍 Iniciando o clássico jogo Snake no Nokia!
📱 Aplicativos instalados no Nokia Nokia 3310:
   • Snake
   • Galeria
   • Contatos
   • Calculadora

==================================================

🔷 TESTANDO IPHONE 🔷
📱 Informações do Smartphone:
   Modelo: iPhone 14 Pro
   Número: 11912345678
   IMEI: 222222222222222
   Memória: 256GB

📱 iPhone iPhone 14 Pro ligando com Face ID/Touch ID...
🎵 iPhone iPhone 14 Pro recebendo ligação com toque personalizado...
📱 Conectando à App Store...
📥 Baixando Instagram para iPhone iPhone 14 Pro...
✅ Instagram instalado com sucesso da App Store!
... e muito mais!
```

## 🛠️ Conceitos Aplicados

- **Abstração**: Classe Smartphone define interface comum
- **Herança**: Nokia e iPhone estendem Smartphone
- **Polimorfismo**: Métodos sobrescritos com comportamentos específicos
- **Encapsulamento**: Propriedades protegidas e validadas
- **Interface**: ISmartphoneFeatures define contratos
- **Validação**: Entrada robusta em todas as operações
- **Tratamento de exceções**: Códigos defensivos

---
