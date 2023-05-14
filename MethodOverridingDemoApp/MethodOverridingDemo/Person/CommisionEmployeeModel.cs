
namespace MethodOverridingDemo.Person
{
    public class CommisionEmployeeModel : EmployeeModel
    {
        public decimal CommissionAmount { get; set; }

        public override decimal GetPaycheckAmount(int hoursWorked)
        {
            // Use base.MethodName() to call the parent object's method
            decimal initialPay = base.GetPaycheckAmount(hoursWorked);

            return initialPay + CommissionAmount;
        }
    }
}
