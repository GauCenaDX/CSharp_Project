
namespace EventsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CollegeClassModel history = new CollegeClassModel("History 101", 3);
            CollegeClassModel math = new CollegeClassModel("Calculus 201", 2);

            // Adding Event Listeners to EnrollmentFull event
            history.EnrollmentFull += CollegeClass_EnrollmentFull;
            
            history.SignUpStudent("Choi Nam-ra").PrintToConsole();
            history.SignUpStudent("Lee Cheong-san").PrintToConsole();
            history.SignUpStudent("Nam On-jo").PrintToConsole();
            history.SignUpStudent("Lee Su-hyeok").PrintToConsole();
            history.SignUpStudent("Jang Ha-ri").PrintToConsole();

            Console.WriteLine();
            math.EnrollmentFull += CollegeClass_EnrollmentFull;

            math.SignUpStudent("Lee Su-hyeok").PrintToConsole();
            math.SignUpStudent("Jang Ha-ri").PrintToConsole();
            math.SignUpStudent("Lee Cheong-san").PrintToConsole();


            Console.WriteLine();
            Console.WriteLine("End of program. Hit Enter to exit.");
            Console.ReadLine();
        }

        //private static void Math_EnrollmentFull(object? sender, string e)
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("The enrollment is full for math");
        //    Console.WriteLine();
        //}

        //private static void History_EnrollmentFull(object sender, string e)
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("The enrollment is full for history");
        //    Console.WriteLine();
        //}

        //private static void CollegeClass_EnrollmentFull(object? sender, string e)
        //{
        //    Console.WriteLine();
        //    Console.WriteLine(e);
        //    Console.WriteLine();
        //}

        private static void CollegeClass_EnrollmentFull(object? sender, string e)
        {
            // Since we know the event is coming from the CollegeClassModel, we
            // can use cast to specify the type of the sender which will allow
            // us to access the sender's values.
            CollegeClassModel model = (CollegeClassModel)sender;

            Console.WriteLine();
            Console.WriteLine($"{model.CourseTitle} : Full");
            Console.WriteLine();
        }
    }
}
