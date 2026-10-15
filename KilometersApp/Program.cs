namespace KilometersApp;

internal class Program
{
    static void Main(string[] args)
    {
        // Αρχικοποίηση και δήλωση μεταβλητών 
        const double METER_PER_KM = 1000D;
        const double CM_PER_KM = 100000D;
        const double MILES_PER_KM = 0.621371D;

        double kilometers = 0D;
        double meters = 0D;
        double centimeters = 0D;
        double miles = 0D;

        //Εισαγωγή δεδομένων από τον χρήστη,data binding,and validation

        Console.WriteLine("Εισαγωγή αριθμού χιλιομέτρων:");
        if (!double.TryParse(Console.ReadLine(), out  kilometers) || kilometers < 0) {

            Console.WriteLine("Μη έγκηρη τιμή");
            return;
        }
        //Επεξεργασία δεδομένων, υπολογισμοί και logic App

        meters = kilometers * METER_PER_KM;
        centimeters = kilometers * CM_PER_KM;
        miles = kilometers * MILES_PER_KM;

        //Εμφάνιση αποτελεσμάτων στον χρήστη, output binding

        Console.WriteLine($"{"Χιλιόμετρα",-20} {kilometers,-15:N2}km");
        Console.WriteLine($"{"Μέτρα",-20} {meters, -15:N2}m");
        Console.WriteLine($"{"Εκατοστά",-20} {centimeters,-15:N2}cm");
        Console.WriteLine($"{"Μίλια",-20} {miles,-15:N2}mls");
    }
}
  