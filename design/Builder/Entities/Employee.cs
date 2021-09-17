using System.Text;

namespace Builder.Entities
{
    public class Employee
    {
        public double HealthAmount { get; protected set; }
        public double TotalToPay { get; protected set; }
        public double RetirementAmount { get; protected set; }
        public double TotalDiscount { get; protected set; }
        public Person Person { get; set; }
        public Position Position { get; set; }
        public HealthPlan HealthPlan { get; set; }
        public RetirementPlan RetirementPlan { get; set; }
        private void calculateSalary()
        {
            HealthAmount = Position.Salary * (HealthPlan.PercentageQuote / 100);
            RetirementAmount = Position.Salary * (RetirementPlan.PercentageQuote / 100);
            TotalDiscount = HealthAmount + RetirementAmount;
            TotalToPay = Position.Salary - TotalDiscount;

        }
        public string GetSummary()
        {
            calculateSalary();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Person: {Person.Name} {Person.LastName}");
            stringBuilder.AppendLine($"Position: {Position.PositionName} {Position.Salary}");
            stringBuilder.AppendLine($"HealthPlan: {HealthPlan.PlanType} {HealthPlan.PercentageQuote}, HealthAmount: {HealthAmount} ");
            stringBuilder.AppendLine($"RetirementPlan: {RetirementPlan.PlanType} {RetirementPlan.PercentageQuote}, RetirementAmount: {RetirementAmount}");
            stringBuilder.AppendLine("=======================================================");
            stringBuilder.AppendLine($"Total Discount: {TotalDiscount}");
            stringBuilder.AppendLine($"Total to Pay: {TotalToPay}");
            return stringBuilder.ToString();
        }
    }
}


