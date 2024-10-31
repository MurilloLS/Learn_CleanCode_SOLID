using System.Security.Cryptography.X509Certificates;
using Solid.dia5;

namespace Solid.dia5;

public class Gerente : Funcionario, IBonificacao, IGerenciamentoRelatorio
{
  public Gerente(string nome, decimal salario) : base(nome,salario) {}

    public override decimal CalcularBonus()
    {
      return Salario * 0.2m;
    }

    public void GerarRelatorio()
    {
      Console.WriteLine($"Relatório do Gerente {Nome} gerado com sucesso.");
    }
}