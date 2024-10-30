﻿using Solid.dia1;
using Solid.dia2;
using Solid.dia3;
using Solid.dia4;
using Solid.Models;

namespace Solid;

public class Program
{
  public static void Main(string[] args)
  {

    // Dia 1: Introdução ao Código Limpo e SOLID.

    // var funcionario = new Funcionario
    // {
    //   Nome = "João",
    //   Cargo = "Gerente",
    //   Salario = 5000,
    //   Ativo = true
    // };

    // var service = new RefactoredClass();
    // service.AlternarStatusFuncionario(funcionario);

    // decimal salarioFinal = service.CalcularSalario(funcionario);
    // Console.WriteLine($"Salário Final: {salarioFinal}");

    // service.GerarRelatorio(funcionario);





    // Dia 2 - Aplicando o Princípio de Responsabilidade Única (SRP)

    //  var funcionario = new Funcionario
    //     {
    //         Nome = "Maria",
    //         Cargo = "Gerente",
    //         Salario = 6000,
    //         Ativo = true
    //     };

    //     var statusService = new FuncionarioStatusService();
    //     var salarioService = new FuncionarioSalaryService();
    //     var relatorioService = new FuncionarioRelatoryService();

    //     statusService.AlternarStatusFuncionario(funcionario);

    //     decimal salarioFinal = salarioService.CalcularSalario(funcionario);
    //     Console.WriteLine($"Salário Final: {salarioFinal}");

    //     relatorioService.GerarRelatorio(funcionario);




    //Dia 3 - Aplicando o Princípio Aberto/Fechado (OCP)
    
    // var funcionarioGerente = new Funcionario
    // {
    //     Nome = "Maria",
    //     Cargo = "Gerente",            
    //     Salario = 6000,
    //     Ativo = true
    // };

    // var funcionarioComum = new Funcionario
    // {
    //     Nome = "João",
    //     Cargo = "Funcionário Comum",
    //     Salario = 3000,
    //     Ativo = true
    // };

    // var salarioService = new dia3.FuncionarioSalaryService();

    // decimal salarioGerente = salarioService.CalcularSalario(funcionarioGerente, new GerenteBonusCalculator());
    // Console.WriteLine($"Salário do Gerente {funcionarioGerente.Nome}: {salarioGerente}");

    // decimal salarioComum = salarioService.CalcularSalario(funcionarioComum, new FuncionarioComumBonusCalculator());
    // Console.WriteLine($"Salário do Funcionário Comum {funcionarioComum.Nome}: {salarioComum}");


    

    //Dia 4 - Aplicando o Princípio de Substituição de Liskov (LSP)
    
    Funcionarios funcionarioComum = new FuncionarioComum("Ana", 3000);
    Funcionarios gerente = new Gerente("Carlos", 8000);

    Console.WriteLine($"{funcionarioComum.Nome} - Bônus: {funcionarioComum.CalcularBonus():C}");
    Console.WriteLine($"{gerente.Nome} - Bônus: {gerente.CalcularBonus():C}");
  }
}
