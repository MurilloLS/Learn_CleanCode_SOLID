using Solid.dia1;
using Solid.dia2;
using Solid.dia3;
using Solid.dia4;
using Solid.dia5;
using Solid.dia6;
using Solid.dia7;
using Solid.Models;

namespace Solid;

public static class Program
{
  public static void Main(string[] args)
  {

    // Dia 1: Introdução ao Código Limpo e SOLID.

    // var funcionario = new Models.Funcionario
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





    //Dia 2 - Aplicando o Princípio de Responsabilidade Única (SRP)

    // var funcionaria = new Models.Funcionario
    // {
    //     Nome = "Maria",
    //     Cargo = "Gerente",
    //     Salario = 6000,
    //     Ativo = true
    // };

    // var statusService = new dia2.FuncionarioStatusService();
    // var salarioService = new dia2.FuncionarioSalaryService();
    // var relatorioService = new FuncionarioRelatoryService();

    // statusService.AlternarStatusFuncionario(funcionaria);

    // decimal salario = salarioService.CalcularSalario(funcionaria);
    // Console.WriteLine($"Salário Final: {salario}");

    // relatorioService.GerarRelatorio(funcionaria);




    //Dia 3 - Aplicando o Princípio Aberto/Fechado (OCP)

    // var funcionarioGerente = new Models.Funcionario
    // {
    //     Nome = "Maria",
    //     Cargo = "Gerente",            
    //     Salario = 6000,
    //     Ativo = true
    // };

    // var funcionarioComum = new Models.Funcionario
    // {
    //     Nome = "João",
    //     Cargo = "Funcionário Comum",
    //     Salario = 3000,
    //     Ativo = true
    // };

    // var salaryService = new dia3.FuncionarioSalaryService();

    // decimal salarioGerente = salaryService.CalcularSalario(funcionarioGerente, new GerenteBonusCalculator());
    // Console.WriteLine($"Salário do Gerente {funcionarioGerente.Nome}: {salarioGerente}");

    // decimal salarioComum = salaryService.CalcularSalario(funcionarioComum, new FuncionarioComumBonusCalculator());
    // Console.WriteLine($"Salário do Funcionário Comum {funcionarioComum.Nome}: {salarioComum}");




    //Dia 4 - Aplicando o Princípio de Substituição de Liskov (LSP)

    // Funcionarios funcionariaComum = new dia4.FuncionarioComum("Ana", 3000);
    // Funcionarios gerente = new dia4.Gerente("Carlos", 8000);

    // Console.WriteLine($"{funcionariaComum.Nome} - Bônus: {funcionariaComum.CalcularBonus():C}");
    // Console.WriteLine($"{gerente.Nome} - Bônus: {gerente.CalcularBonus():C}");



    //Dia 5 - Aplicando o Princípio de Segregação de Interfaces (ISP)

    // dia5.FuncionarioComum funcionaryComum = new dia5.FuncionarioComum("João", 3000);
    // dia5.Gerente gerente1 = new dia5.Gerente("Murillo", 8000);

    // Console.WriteLine($"{funcionaryComum.Nome} - Bônus: {funcionaryComum.CalcularBonus():C}");
    // Console.WriteLine($"{gerente1.Nome} - Bônus: {gerente1.CalcularBonus():C}");

    // gerente1.GerarRelatorio();


    //Dia 6 - Aplicando o Princípio de Inversão de Dependência (DIP)

    // dia6.FuncionarioComum funcionaryComum2 = new dia6.FuncionarioComum("Murillo", 3000);

    // INotificador notificador = new NotificadorEmail();

    // dia6.Gerente gerente2 = new dia6.Gerente("Carlos", 8000, notificador);

    // Console.WriteLine($"{funcionaryComum2.Nome} - Bônus: {funcionaryComum2.CalcularBonus():C}");
    // Console.WriteLine($"{gerente2.Nome} - Bônus: {gerente2.CalcularBonus():C}");
    // gerente2.GerarRelatorio();



    // Dia 7 - Consolidando o SOLID com Cálculo de Impostos

    // var impostoFederalService = new ImpostoFederalService();
    // var calculadoraImposto = new CalculadoraImposto(impostoFederalService);

    // decimal valor = 1000m;
    // Console.WriteLine($"Imposto calculado: {calculadoraImposto.CalcularImposto(valor)}"); 
  }
}
