namespace SimuladorInvestimentos.Core;

public class RendimentoEmJuros
{
    private decimal _montanteFinal;
    private int _periodoMeses;
    public RendimentoEmJuros(decimal montanteFinal, int periodoMeses)
    {
        _montanteFinal = montanteFinal;
        _periodoMeses = periodoMeses;
    }

    public decimal Calcular()
    {
        return _montanteFinal * (_periodoMeses-1);
    }
}