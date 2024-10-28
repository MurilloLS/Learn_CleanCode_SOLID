namespace Solid.dia1;
public class RefactoredClass
{
  public void AlternarStatusFuncionario(Funcionario funcionario){
    funcionario.Ativo = !funcionario.Ativo;
  }

  public decimal CalcularSalario(Funcionario funcionario){
    decimal bonus = funcionario.Cargo == "Gerente" ? 1000 : 500;
    return funcionario.Salario + bonus;
  }

  public void GerarRelatorio(Funcionario funcionario){
    string status = funcionario.Ativo ? "Ativo" : "Inativo";
    Console.WriteLine($"Relatório do funcionário {funcionario.Nome}: Status - {status}");
  }
}