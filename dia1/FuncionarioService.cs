public class FuncionarioService
{
    public void GerenciarFuncionario(Funcionario funcionario)
    {
        // Código para ativar ou inativar o funcionário
        if (funcionario.Ativo)
        {
            funcionario.Ativo = false;
        }
        else
        {
            funcionario.Ativo = true;
        }

        // Código para calcular o salário
        decimal salarioBase = funcionario.Salario;
        decimal bonus = funcionario.Cargo == "Gerente" ? 1000 : 500;
        decimal salarioFinal = salarioBase + bonus;
        Console.WriteLine($"Salário calculado: {salarioFinal}");

        // Código para emitir relatório
        Console.WriteLine($"Relatório do funcionário {funcionario.Nome}: Status - {(funcionario.Ativo ? "Ativo" : "Inativo")}");
    }
}
