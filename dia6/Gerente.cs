namespace Solid.dia6;

public class Gerente : Funcionario, IBonificacao, IGerenciamentoRelatorio
{
  public readonly INotificador _notificador;
  public Gerente(string nome, decimal salario, INotificador notificador) : base(nome, salario)
  {
    _notificador = notificador;
  }

    public override decimal CalcularBonus()
    {
      decimal bonus = Salario * 0.2m;
      _notificador.EnviarNotificacao($"{Nome} recebeu um bônus de {bonus:C}.");
      return bonus;
    }

    public void GerarRelatorio()
    {
      Console.WriteLine($"Relatório do Gerente {Nome} gerado com sucesso.");
      _notificador.EnviarNotificacao($"Relatório do Gerente {Nome} foi gerado");
    }
}