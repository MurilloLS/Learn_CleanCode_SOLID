namespace Solid.dia2;

public class FuncionarioRelatoryService
{
  public void GerarRelatorio(Funcionario funcionario)
  {
    string status = funcionario.Ativo ? "Ativo" : "Inativo";
    Console.WriteLine($"Relatório do funcionario {funcionario.Nome}: Status - {status}");
  }
}