namespace Solid.dia7;

public class ImpostoEstadualService : ICalculoImposto
{
  public decimal Calcular(decimal valor)
  {
    return valor * 0.1m;
  }
}