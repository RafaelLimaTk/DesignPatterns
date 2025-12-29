# 🎯 Design Patterns GoF - Repository

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Design Patterns](https://img.shields.io/badge/Design_Patterns-GoF-blue?style=for-the-badge)

Este repositório é uma biblioteca prática e organizada de **Design Patterns (Padrões de Projeto)** baseada no livro clássico do **Gang of Four (GoF)**. O objetivo é fornecer implementações claras e documentadas em C# para facilitar o aprendizado e a aplicação desses conceitos em projetos reais.

## 🚀 O que são Design Patterns?

Design Patterns são soluções reutilizáveis para problemas comuns que ocorrem durante o desenvolvimento de software. Eles não são pedaços de código prontos, mas sim modelos (templates) de como resolver um problema em diversas situações. A utilização desses padrões promove:
- **Manutenibilidade**: Código mais fácil de entender e modificar.
- **Reutilização**: Soluções testadas e aprovadas.
- **Padronização**: Uma linguagem comum entre desenvolvedores.

---

## 🏗️ Padrões Implementados

Abaixo estão os padrões GoF atualmente implementados neste repositório. Cada descrição foi extraída da definição original do livro *Design Patterns: Elements of Reusable Object-Oriented Software*.

### 💎 Criacionais (Creational)
Os padrões criacionais focam no processo de criação de objetos, abstraindo a lógica de instanciamento.

| Padrão | Descrição Original (GoF) | Código Fonte |
| :--- | :--- | :--- |
| **Singleton** | Garante que uma classe tenha apenas uma instância e fornece um ponto global de acesso a ela. | [Ver Pasta](./A%20-%20Creational/1%20-%20Singleton/) |
| **Factory Method** | Define uma interface para criar um objeto, mas deixa as subclasses decidirem qual classe instanciar. O Factory Method permite que uma classe adie a instanciação para subclasses. | [Ver Pasta](./A%20-%20Creational/2%20-%20Factory%20Method/) |
| **Abstract Factory** | Fornece uma interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas. | [Ver Pasta](./A%20-%20Creational/3%20-%20Abstract%20Factory/) |
| **Builder** | Separa a construção de um objeto complexo da sua representação, de modo que o mesmo processo de construção possa criar diferentes representações. | [Ver Pasta](./A%20-%20Creational/4%20-%20Builder/) |
| **Prototype** | Especifica os tipos de objetos a serem criados usando uma instância prototípica e cria novos objetos copiando este protótipo. | [Ver Pasta](./A%20-%20Creational/5%20-%20Prototype/) |

### 🛠️ Estruturais (Structural)
Os padrões estruturais lidam com a composição de classes ou objetos para formar estruturas maiores e mais eficientes.

| Padrão | Descrição Original (GoF) | Código Fonte |
| :--- | :--- | :--- |
| **Adapter** | Converte a interface de uma classe em outra interface que os clientes esperam. O Adapter permite que classes trabalhem juntas, o que de outra forma seria impossível devido a interfaces incompatíveis. | [Ver Pasta](./B%20-%20Structural/6%20-%20Adapter/) |
| **Bridge** | Desacopla uma abstração de sua implementação, de modo que las duas possam variar independentemente. | [Ver Pasta](./B%20-%20Structural/7%20-%20Bridge/) |
| **Decorator** | Dinamicamente adiciona responsabilidades extras a um objeto. Os Decorators fornecem uma alternativa flexível à herança para estender funcionalidades. | [Ver Pasta](./B%20-%20Structural/8%20-%20Decorator/) |
| **Composite** | Compõe objetos em estruturas de árvore para representar hierarquias parte-todo. O Composite permite que os clientes tratem objetos individuais e composições de objetos de maneira uniforme. | [Ver Pasta](./B%20-%20Structural/9%20-%20Composite/) |
| **Facade** | Fornece uma interface unificada para um conjunto de interfaces em um subsistema. O Facade define uma interface de nível mais alto que torna o subsistema mais fácil de usar. | [Ver Pasta](./B%20-%20Structural/10%20-%20Facade/) |

---

## 🛠️ Tecnologias e Clean Code
As implementações seguem os princípios:
- **SOLID Principles**
- **C# Moderno**
- **Clean Code**

## 📂 Como Navegar
1. As pastas são prefixadas por categoria (A - Creational, B - Structural).
2. Cada pasta de padrão contém um projeto C# independente com o exemplo prático.
3. Utilize o arquivo `.slnx` para abrir todos os projetos em sua IDE preferida.

---

*Estudo e referências baseados no livro de Erich Gamma, Richard Helm, Ralph Johnson e John Vlissides.*

---
**Keywords SEO:** Design Patterns, Padrões de Projeto, GoF, Gang of Four, C#, .NET, Software Architecture, Clean Code, SOLID, Singleton, Factory Method, Abstract Factory, Builder, Prototype, Adapter, Bridge, Decorator, Composite, Facade.