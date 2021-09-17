using Builder.Entities;

namespace Builder.Builders
{
    public interface IEmployeBuilder
    {
        IEmployeBuilder LikeAnPerson(Person employee);
        IEmployeBuilder HasAPosition(Position position);
        IEmployeBuilder HasAnHealthPlan(HealthPlan healthPlan);
        IEmployeBuilder HasAnRetirementPlan(RetirementPlan retirementPlan);
        Employee Build();
    }
}
