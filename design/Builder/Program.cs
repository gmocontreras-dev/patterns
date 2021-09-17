using Builder.Builders;
using System;
using Builder.Entities;
namespace Patrones.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "Guillermo",
                LastName = "Contreras",
                Birthday = new DateTime(1980, 10, 3)
            };
            Position position = new Position
            {
                PositionName = "Arquitecto de software",
                Salary = 2500000
            };
            HealthPlan healthPlan = new HealthPlan
            {
                InstitutionName = "Banmedica",
                PercentageQuote = 12,
                PlanType = HealthPlanType.Private
            };
            RetirementPlan retirementPlan = new RetirementPlan
            {
                InstitutionName = "Afp Habitat",
                PlanType = RetirementPlanType.Private,
                PercentageQuote = 11.2
            };
            IEmployeBuilder employeBuilder = new EmployeeBuilder();
            Employee employee = employeBuilder.LikeAnPerson(person)
                 .HasAPosition(position)
                 .HasAnHealthPlan(healthPlan)
                 .HasAnRetirementPlan(retirementPlan).Build();
            Console.WriteLine(employee.GetSummary());
            Console.ReadKey();
        }
    }
}
