namespace CarRentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Αρχικοποίηση και δήλωση μεταβλητών 
            const int COST_PER_DAY          =  25;
            const double COST_PER_KILOMETER = 0.15d;
            const double VAT = 0.24d;

            double rentKilomoters   = 0d;
            int rentDays            = 0;
            double totalCost        = 0d;
            double vatAmount        = 0d;
            double totalCostWithVAT = 0d;

            // Εισαγωγή δεδομένων, data binding και validation

            Console.WriteLine("Δωστε ημέρες ενοικίασης αυτοκινήτου");

            if (!int.TryParse(Console.ReadLine(), out rentDays) || rentDays <= 0) 
            {
                Console.WriteLine("Μη έγκυρη είσοδος για ημέρες.");
                return;
            }

            Console.WriteLine("Δώστε αποσταση χιλιομέτρων ");
            if (!double.TryParse(Console.ReadLine(), out rentKilomoters) || rentKilomoters <= 0)
            {
                Console.WriteLine("Μη έγκυρη είσοδος για τα χιλιόμετρα.");
                return;
            }

            // Μετατροπή και υπολογισμοί - Λογική του προγράμματος

            totalCost = (rentDays * COST_PER_DAY) + (rentKilomoters * COST_PER_KILOMETER);
            vatAmount = totalCost * VAT;
            totalCostWithVAT = totalCost + (totalCost * VAT);

            // Εμφάνιση αποτελεσμάτων

            //Εμφάνιση αποτελεσμάτων στον χρήστη, output binding
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine($"{"Τιμή χωρίς ΦΠΑ:",-20} {totalCost:N2} \u20AC");
            Console.WriteLine($"{"ΦΠΑ(24%):",-20} {vatAmount:N2} \u20AC");
            Console.WriteLine($"{"Τιμή με ΦΠΑ:",-20} {totalCostWithVAT:N2} \u20AC");
        }
    }
}
