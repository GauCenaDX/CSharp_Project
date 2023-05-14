
namespace MethodOverridingDemo.Person
{
    public class EmployeeModel : PersonModel
    {
        public decimal HourlyRate { get; set; }

        // Use virtual to mark a method to allow for being overridden
        public virtual decimal GetPaycheckAmount(int hoursWorked)
        {
            return hoursWorked * HourlyRate;
        }
    }
}
