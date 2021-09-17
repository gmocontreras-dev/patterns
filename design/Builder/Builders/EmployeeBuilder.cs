using Builder.Entities;

namespace Builder.Builders
{
    public class EmployeeBuilder : IEmployeBuilder
    {
        Person _person;
        Position _position;
        HealthPlan _healthPlan;
        RetirementPlan _retirementPlan;
        public IEmployeBuilder LikeAnPerson(Person person)
        {
            _person = person;
            return this;
        }
        public IEmployeBuilder HasAPosition(Position position)
        {
            _position = position;
            return this;
        }
        public IEmployeBuilder HasAnHealthPlan(HealthPlan healthPlan)
        {
            _healthPlan = healthPlan;
            return this;
        }

        public IEmployeBuilder HasAnRetirementPlan(RetirementPlan retirementPlan)
        {
            _retirementPlan = retirementPlan;
            return this;
        }
        public Employee Build()
        {
            return new Employee
            {
                Person = _person,
                Position =_position,
                HealthPlan = _healthPlan,
                RetirementPlan = _retirementPlan
            };
        }
    }
}
