using Solid.dia4;
namespace Solid.dia4;
public class Gerente : Funcionarios
{
  public Gerente(string nome, decimal salario) : base(nome, salario) {}

    public override decimal CalcularBonus()
    {
      return Salario * 0.20m;
    }
}