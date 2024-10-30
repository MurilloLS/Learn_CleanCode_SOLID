namespace Solid.dia4;

public class FuncionarioComum : Funcionarios
{
  public FuncionarioComum(string nome, decimal salario) : base(nome, salario){}

    public override decimal CalcularBonus()
    {
      return Salario * 0.10m;
    }
}
