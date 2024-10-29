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