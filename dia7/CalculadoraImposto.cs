 namespace Solid.dia7;

public class CalculadoraImposto
{
  private readonly ICalculoImposto _calculoImposto;
  
  public CalculadoraImposto(ICalculoImposto calculoImposto)
  {
    _calculoImposto = calculoImposto;
  }

  public decimal CalcularImposto(decimal valor)
  {
    return _calculoImposto.Calcular(valor);
  }
}