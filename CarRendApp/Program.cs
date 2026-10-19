namespace CarRentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Αρχικοποίηση και δήλωση μεταβλητών 
            const int COST_PER_DAY = 25;

            double rentKilomiters = 0d;
            int rentDays          = 0;


            // Εισαγωγή δεδομένων, data binding και validation


            Console.WriteLine("Δωστε ημέρες ενοικίασης αυτοκινήτου");

            if (!int.TryParse(Console.ReadLine(), out rentDays) || rentDays <= 0) 
            {
                Console.WriteLine("Μη έγκυρη είσοδος για ημέρες.");
                return;
            }

            Console.WriteLine("Δώστε αποσταση χιλιομέτρων ");
            if (!double.TryParse(Console.ReadLine(), out rentKilomiters) || rentKilomiters <= 0)
            {
                Console.WriteLine("Μη έγκυρη είσοδος για τα χιλιόμετρα.");
                return;
            }



            // Μετατροπή και υπολογισμοί - Λογική του προγράμματος
            // Εμφάνιση αποτελεσμάτων
        }
    }
}
