namespace Solid.dia2;

public class FuncionarioSalaryService
{
  public decimal CalcularSalario(Funcionario funcionario)
  {
    decimal bonus = funcionario.Cargo == "Gerente" ? 1000 : 500;
    return funcionario.Salario + bonus;
  }
}