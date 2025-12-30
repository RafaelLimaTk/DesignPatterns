# Design Patterns GoF - Documentação Técnica

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Design Patterns](https://img.shields.io/badge/Design_Patterns-GoF-blue?style=for-the-badge)

Este repositório contém uma biblioteca prática e organizada de **Design Patterns (Padrões de Projeto)** baseada no livro clássico do **Gang of Four (GoF)**. O objetivo é fornecer implementações claras e documentadas em C# para facilitar o aprendizado e a aplicação desses conceitos em arquitetura de software.

## Definição de Design Patterns

Design Patterns são soluções reutilizáveis para problemas recorrentes que surgem durante o desenvolvimento de software. Diferente de bibliotecas ou frameworks, eles são modelos conceituais que orientam a resolução de problemas estruturais e comportamentais em sistemas orientados a objetos.

A implementação desses padrões visa:
- Facilitar a manutenibilidade e escalabilidade do código.
- Promover a reutilização de soluções testadas.
- Padronizar a comunicação técnica entre desenvolvedores.

---

## Catálogo de Padrões Implementados

Abaixo estão os padrões GoF atualmente presentes neste repositório. As descrições seguem as definições originais da obra *Design Patterns: Elements of Reusable Object-Oriented Software*.

### Creational (Criacionais)
Estes padrões abstraem o processo de instanciação, tornando o sistema independente de como seus objetos são criados, compostos e representados.

| Padrão | Descrição Original (GoF) | Código Fonte |
| :--- | :--- | :--- |
| **Singleton** | Garante que uma classe tenha apenas uma instância e fornece um ponto global de acesso a ela. | [Ver Pasta](./A%20-%20Creational/1%20-%20Singleton/) |
| **Factory Method** | Define uma interface para criar um objeto, mas deixa as subclasses decidirem qual classe instanciar. O Factory Method permite que uma classe adie a instanciação para subclasses. | [Ver Pasta](./A%20-%20Creational/2%20-%20Factory%20Method/) |
| **Abstract Factory** | Fornece uma interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas. | [Ver Pasta](./A%20-%20Creational/3%20-%20Abstract%20Factory/) |
| **Builder** | Separa a construção de um objeto complexo da sua representação, de modo que o mesmo processo de construção possa criar diferentes representações. | [Ver Pasta](./A%20-%20Creational/4%20-%20Builder/) |
| **Prototype** | Especifica os tipos de objetos a serem criados usando uma instância prototípica e cria novos objetos copiando este protótipo. | [Ver Pasta](./A%20-%20Creational/5%20-%20Prototype/) |

### Structural (Estruturais)
Lidam com a composição de classes e objetos para formar estruturas maiores, permitindo que diferentes partes do sistema trabalhem de forma coesa.

| Padrão | Descrição Original (GoF) | Código Fonte |
| :--- | :--- | :--- |
| **Adapter** | Converte a interface de uma classe em outra interface que os clientes esperam. O Adapter permite que classes trabalhem juntas, o que de outra forma seria impossível devido a interfaces incompatíveis. | [Ver Pasta](./B%20-%20Structural/6%20-%20Adapter/) |
| **Bridge** | Desacopla uma abstração de sua implementação, de modo que as duas possam variar independentemente. | [Ver Pasta](./B%20-%20Structural/7%20-%20Bridge/) |
| **Decorator** | Dinamicamente adiciona responsabilidades extras a um objeto. Os Decorators fornecem uma alternativa flexível à herança para estender funcionalidades. | [Ver Pasta](./B%20-%20Structural/8%20-%20Decorator/) |
| **Composite** | Compõe objetos em estruturas de árvore para representar hierarquias parte-todo. O Composite permite que os clientes tratem objetos individuais e composições de objetos de maneira uniforme. | [Ver Pasta](./B%20-%20Structural/9%20-%20Composite/) |
| **Facade** | Fornece uma interface unificada para um conjunto de interfaces em um subsistema. O Facade define uma interface de nível mais alto que torna o subsistema mais fácil de usar. | [Ver Pasta](./B%20-%20Structural/10%20-%20Facade/) |
| **Proxy** | Fornece um substituto ou marcador de lugar para outro objeto para controlar o acesso a ele. | [Ver Pasta](./B%20-%20Structural/11%20-%20Proxy/) |
| **Flyweight** | Usa o compartilhamento para suportar grandes quantidades de objetos de granularidade fina de forma eficiente. | [Ver Pasta](./B%20-%20Structural/12%20-%20Flyweight/) |

### Behavioral (Comportamentais)
Os padrões comportamentais se concentram nos algoritmos e na atribuição de responsabilidades entre os objetos. Eles não descrevem apenas padrões de objetos ou classes, mas também os padrões de comunicação entre eles.

| Padrão | Descrição Original (GoF) | Código Fonte |
| :--- | :--- | :--- |
| **Template Method** | Define o esqueleto de um algoritmo em uma operação, adiando alguns passos para as subclasses. O Template Method permite que as subclasses redefinem certos passos de um algoritmo sem mudar a estrutura do mesmo. | [Ver Pasta](./C%20-%20Behavioral/13%20-%20Template%20Method/) |
| **Strategy** | Define uma família de algoritmos, encapsula cada um deles e os torna intercambiáveis. O Strategy permite que o algoritmo varie independentemente dos clientes que o utilizam. | [Ver Pasta](./C%20-%20Behavioral/14%20-%20Strategy/) |
| **Command** | Encapsula uma solicitação como um objeto, desta forma permitindo parametrizar clientes com diferentes solicitações, enfileirar ou registrar solicitações e suportar operações que podem ser desfeitas. | [Ver Pasta](./C%20-%20Behavioral/15%20-%20Command/) |
| **Memento** | Sem violar o encapsulamento, captura e externaliza um estado interno de um objeto, de modo que o objeto possa ser restaurado para este estado mais tarde. | [Ver Pasta](./C%20-%20Behavioral/16%20-%20Memento/) |
| **Mediator** | Define um objeto que encapsula como um conjunto de objetos interage. O Mediator promove o acoplamento fraco ao manter objetos que não se referem um ao outro explicitamente, permitindo variar sua interação independentemente. | [Ver Pasta](./C%20-%20Behavioral/17%20-%20Mediator/) |
| **Chain of Responsibility** | Evita o acoplamento do remetente de uma solicitação ao seu receptor, permitindo que múltiplos objetos tenham a oportunidade de tratar a solicitação passando-a ao longo de uma cadeia até que algum trate. | [Ver Pasta](./C%20-%20Behavioral/18%20-%20Chain%20of%20Responsibility/) |

---
*Referências: Gamma, Erich; Helm, Richard; Johnson, Ralph; Vlissides, John (1994). Design Patterns: Elements of Reusable Object-Oriented Software.*