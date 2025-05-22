namespace SimuladorInvestimentos.Core.Entity.validator;

public interface IValidator<T>
{
    void Validate(T entity);
}