# Aprendizado de Código Limpo e SOLID

## Dia 1 - Introdução ao Código Limpo
- Refatoração inicial para código mais legível e simples.
- Separação de responsabilidades em métodos individuais.


## Dia 2 - Aplicando o Princípio de Responsabilidade Única (SRP)
- Refatoração do código do dia 1 para aplicar o Single Responsibility Principle.
- Divisão das responsabilidades em classes dedicadas: `FuncionarioStatusService`, `FuncionarioSalaryService` e `FuncionarioRelatoryService`.
- O código agora está mais modular e fácil de manter, facilitando futuras expansões e alterações.


## Dia 3 - Aplicando o Princípio Aberto/Fechado (OCP)
- Refatoração para aplicar o Open/Closed Principle.
- Implementação da interface `IBonusCalculator` e classes de cálculo de bônus específicas (`GerenteBonusCalculator`, `FuncionarioComumBonusCalculator`).
- O `FuncionarioSalaryService` agora pode calcular bônus sem precisar ser modificado para novos tipos de funcionário.


## Dia 4 - Aplicando o Princípio de Substituição de Liskov (LSP)
- Refatoração para garantir que `FuncionarioComum` e `Gerente` possam substituir `Funcionario` sem alterar o comportamento esperado.
- Implementação de uma estrutura de classes para calcular bônus, assegurando que o cálculo seja feito de forma apropriada para cada tipo de funcionário.
- O código agora é mais seguro para herança e promove maior flexibilidade ao adicionar novos tipos de funcionários no futuro.


## Dia 5 - Aplicando o Princípio de Segregação de Interfaces (ISP)
- Aplicação do Princípio de Segregação de Interfaces para manter as interfaces pequenas e específicas.
- Criação das interfaces `IBonificacao` e `IGerenciamentoRelatorio`, para que as classes implementem apenas métodos relevantes às suas responsabilidades.
- `FuncionarioComum` implementa apenas `IBonificacao`, enquanto `Gerente` implementa tanto `IBonificacao` quanto `IGerenciamentoRelatorio`, permitindo que cada classe tenha apenas as funcionalidades necessárias.
- A estrutura modular reduz dependências e melhora a flexibilidade e manutenção do código.


## Dia 6 - Aplicando o Princípio de Inversão de Dependência (DIP)
- Implementação do Dependency Inversion Principle para reduzir dependências de classes de baixo nível.
- Criação da interface `INotificador`, possibilitando injeção de dependências para notificação (e.g., `NotificadorEmail`).
- Modificação da classe `Gerente` para usar `INotificador` no envio de notificações e geração de relatórios.
- O código agora é mais independente e permite substituições de dependências sem modificações no código de alto nível.


## Dia 7 - Consolidando o SOLID com Cálculo de Impostos
- Implementação de uma solução completa aplicando os cinco princípios SOLID no cálculo de impostos:
  - **SRP**: Separação das responsabilidades de cálculo de impostos em `ImpostoFederalService` e `ImpostoEstadualService`.
  - **OCP**: `CalculadoraImposto` é extensível sem necessidade de alteração, podendo receber novos tipos de impostos.
  - **LSP**: `CalculadoraImposto` permite substituições de `ICalculoImposto`, garantindo o comportamento esperado.
  - **ISP**: Interface `ICalculoImposto` é pequena e específica, evitando métodos desnecessários.
  - **DIP**: `CalculadoraImposto` depende de abstrações (`ICalculoImposto`) em vez de implementações concretas.
- Essa refatoração final aplicou o SOLID de maneira completa, tornando o sistema mais modular, fácil de testar e preparado para expansões futuras.