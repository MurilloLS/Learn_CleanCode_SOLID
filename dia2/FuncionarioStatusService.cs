namespace Solid.dia2;

public class FuncionarioStatusService
{
  public void AlternarStatusFuncionario(Funcionario funcionario)
  {
    funcionario.Ativo = !funcionario.Ativo;
  }
}