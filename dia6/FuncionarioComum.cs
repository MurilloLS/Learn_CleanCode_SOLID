namespace Solid.dia6;

public class FuncionarioComum : Funcionario, IBonificacao
{
  public FuncionarioComum(string nome, decimal salario) : base(nome, salario){}

    public override decimal CalcularBonus()
    {
      return Salario * 0.1m;
    }
}