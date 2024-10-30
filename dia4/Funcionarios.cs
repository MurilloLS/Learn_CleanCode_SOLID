namespace Solid.dia4;
public abstract class Funcionarios
{
  public string Nome { get; set; }
  public decimal Salario { get; set; }

  public Funcionarios(string nome, decimal salario)
  {
    Nome = nome;
    Salario = salario;
  }

  public abstract decimal CalcularBonus();
}