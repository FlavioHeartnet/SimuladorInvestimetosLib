using SimuladorInvestimento.validator;

namespace SimuladorInvestimento;

public class Simulation
{
    private decimal _aporteMensal;
    private decimal _valorInicial;
    private decimal _taxaJurosAnual;
    private decimal _taxaCustodia;
    private int _pediodoAnos;
    private bool _isComeCotas;

    public int PeriodoMeses => _pediodoAnos * 12;
    
    public decimal TaxaJurosMensal => _taxaJurosAnual / 12 / 100;

    public int PediodoAnos => _pediodoAnos;

    public decimal AporteMensal
    {
        get => _aporteMensal;
    }

    public decimal ValorInicial
    {
        get => _valorInicial;
    }

    public decimal TaxaJurosAnual
    {
        get => _taxaJurosAnual;
    }

    public decimal TaxaCustodia
    {
        get => _taxaCustodia;
    }

    public bool IsComeCotas
    {
        get => _isComeCotas;
    }

    public Simulation(decimal aporteMensal, decimal valorInicial, decimal taxaJurosAnual, decimal taxaCustodia, int periodoAnos, bool isComeCotas = false)
    {
        _aporteMensal = aporteMensal;
        _valorInicial = valorInicial;
        _taxaJurosAnual = taxaJurosAnual;
        _pediodoAnos = periodoAnos;
        _isComeCotas = isComeCotas;
        _taxaCustodia = taxaCustodia;
        Validate();
    }

    private void Validate()
    {
        new SimulationValidatorFactory().Create().Validate(this);
    }

    public  static Simulation CreateSimulation(decimal valorInicial, decimal taxaJurosAnual, decimal aporteMensal, decimal taxaCustodia, bool isComeCotas, int periodoAnos)
    {
        return new Simulation(aporteMensal, valorInicial, taxaJurosAnual, taxaCustodia, periodoAnos, isComeCotas);
    }
    

}
