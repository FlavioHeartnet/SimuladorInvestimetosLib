using SimuladorInvestimentos.Core.Validator;

namespace SimuladorInvestimentos.Core;
//Esta classe pode ser depois fundida com Montante Depois IR, pois as mesmas tratam de IR então podem ser a mesma classe
public class ImpostoRendaRetido
{
        private decimal _montanteFinal;
        private double _aliquota;

        private ImpostoRendaRetido(decimal montanteFinal, double aliquota)
        {
            _montanteFinal = montanteFinal;
            _aliquota = aliquota;
            Validate();
        }
        
        public decimal GetMontanteFinal()
        {
            return _montanteFinal;
        }

        public double GetAliquota()
        {
            return _aliquota;
        }

        private void Validate()
        {
            new ImpostoRetidoFonteFactory().Create().Validate(this);
        }

        public static ImpostoRendaRetido Create(decimal montanteFinal, double aliquota)
        {
            return new ImpostoRendaRetido(montanteFinal, aliquota);
        }

        public decimal Calcular()
        {
            return _montanteFinal * Decimal.Parse(_aliquota.ToString());
        }
}
