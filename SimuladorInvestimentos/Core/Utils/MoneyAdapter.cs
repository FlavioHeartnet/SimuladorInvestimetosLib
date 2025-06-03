using NMoneys;

namespace SimuladorInvestimentos.Core.Utils;

public class NMoneysAdapter: IMoneyAdapter
{
    public string Format(decimal value)
    {
       return new Money(value,CurrencyIsoCode.BRL).ToString();
    }
}