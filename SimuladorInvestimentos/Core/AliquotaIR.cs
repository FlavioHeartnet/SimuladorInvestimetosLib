namespace SimuladorInvestimentos.Core;

public class AliquotaIr
{
    private double _aliquota =0.225; // 22,5%
    public AliquotaIr()
    {
    }

    public double Calcular(int periodoAnos)
    {
        if(periodoAnos > 0.6 && periodoAnos <= 1) {
            _aliquota = 0.20; // 20%
        }
        if(periodoAnos is > 1 and <= 2) {
            _aliquota = 0.175; // 17,5%
        }
        if(periodoAnos > 2) {
            _aliquota = 0.15; // 15%
        }

        return _aliquota;
    }
}