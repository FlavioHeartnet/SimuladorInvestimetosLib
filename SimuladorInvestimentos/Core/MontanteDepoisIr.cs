using System.Runtime.InteropServices;
using SimuladorInvestimentos.Core.Entity;
using SimuladorInvestimentos.Core.Validator;

namespace SimuladorInvestimentos.Core;

public class MontanteDepoisIr
{
    
    private decimal _montanteFinal;
    private double _aliquota;

    public decimal GetMontanteFinal()
    {
        return _montanteFinal;
    }

    public double GetAliquota()
    {
        return _aliquota;
    }

    private MontanteDepoisIr( decimal montanteFinal, double aliquota)
    {
        _montanteFinal = montanteFinal;
        _aliquota = aliquota;
        Validate();
    }

    private void Validate()
    {
        new MontanteDepoisIrFactory().Create().Validate(this);
    }

    public static MontanteDepoisIr Create(decimal montanteFinal, double aliquota)
    {
        return new MontanteDepoisIr(montanteFinal, aliquota);
    }

    public decimal Calcular()
    {
        return _montanteFinal - (_montanteFinal * Decimal.Parse(_aliquota.ToString()));
    }
}