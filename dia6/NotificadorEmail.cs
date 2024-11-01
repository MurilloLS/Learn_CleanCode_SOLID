namespace Solid.dia6;

public class NotificadorEmail : INotificador
{
  public void EnviarNotificacao(string mensagem)
  {
    Console.WriteLine($"Email enviado: {mensagem}");
  }
}