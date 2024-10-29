public class FuncionarioSalaryService
{
  public decimal CalcularSalario(Funcionario funcionario, IBonusCalculator bonusCalculator)
  {
    decimal bonus = bonusCalculator.CalcularBonus(funcionario);
    return funcionario.Salario + bonus;
  }
}