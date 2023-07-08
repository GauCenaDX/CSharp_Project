namespace BrokenLibrary
{
    class CompanyModel
    {
        public string CompanyName { get; set; }
        public int NumberOfEmployees { get; set; }
        public int NumberOfDaysOffTotal { get; set; }
        
        int AverageDaysOff ()
        {
            return NumberOfDaysOffTotal / NumberOfEmployees;
        }
    }
}