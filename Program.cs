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




    var funcionarioGerente = new Funcionario
    {
        Nome = "Maria",
        Cargo = "Gerente",            Salario = 6000,
        Ativo = true
    };

    var funcionarioComum = new Funcionario
    {
        Nome = "João",
        Cargo = "Funcionário Comum",
        Salario = 3000,
        Ativo = true
    };

    var salarioService = new FuncionarioSalaryService();
        
    decimal salarioGerente = salarioService.CalcularSalario(funcionarioGerente, new GerenteBonusCalculator());
    Console.WriteLine($"Salário do Gerente {funcionarioGerente.Nome}: {salarioGerente}");

    decimal salarioComum = salarioService.CalcularSalario(funcionarioComum, new FuncionarioComumBonusCalculator());
    Console.WriteLine($"Salário do Funcionário Comum {funcionarioComum.Nome}: {salarioComum}");
  }
}
