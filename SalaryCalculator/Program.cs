namespace SalaryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            const int WORKING_DAYS_PER_MONTH = 22;

            const int WORKING_HOURS_PER_DAY = 8;
            

            double userSalaryPerMonth = 0d;
            double userSalaryPerDay = 0d;
            double userSalaryPerHour = 0d;
            double userSalaryPerMinute = 0d;

            Console.WriteLine("Δώστε τον μισθό σας ανά μήνα:");

            if (!double.TryParse(Console.ReadLine(), out userSalaryPerMonth) || userSalaryPerMonth < 0) {

                Console.WriteLine("Λάθος εισαγωγή δεδομένων από τον χρήστη");
                return;
            }

            userSalaryPerDay = userSalaryPerMonth / WORKING_DAYS_PER_MONTH; // Μηνιαίος / 22 εργάσιμες ημέρες
            userSalaryPerHour = userSalaryPerDay / WORKING_HOURS_PER_DAY;   // Ημερήσιος / 8 ώρες
            userSalaryPerMinute = userSalaryPerHour / 60;  // Ημερήσιος / 60 λεπτά

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"{"Μηνιαίος μισθός:",-25} {userSalaryPerMonth:N2} \u20AC");
            Console.WriteLine($"{"Ημερήσιος μισθός:",-25} {userSalaryPerDay:N2} \u20AC");
            Console.WriteLine($"{"Μισθός ανά λεπτό:",-25} {userSalaryPerMinute:N4} \u20AC");




        }
    }
}
