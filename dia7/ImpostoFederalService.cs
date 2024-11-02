namespace Solid.dia7;

public class ImpostoFederalService : ICalculoImposto
{
    public decimal Calcular(decimal valor)
    {
      return valor * 0.2m;
    }
}