using System.Runtime.InteropServices;

namespace ElectricityCalculator;

internal class Program
{
    static void Main(string[] args)
    {
        // Αρχικοποίηση και δήλωση μεταβλητών 
        
        const double ENERGY_COST_PER_KWH = 0.18d;
        const double FIXED_COST = 5.00d;
        const double RES_FEE= 0.02d;
        const double VAT = 0.24d;

        double usereLEctricityConsumption = 0d;
        double totalCost = 0d;
        double vatAmount = 0d;
        double totalCostWithVAT = 0d;

        // Εισαγωγή δεδομένων, data binding και validation

        Console.WriteLine("Δωστε την κατανάλωση ηλεκτρικής ενέργειας σε kWh:");

       if(!double.TryParse(Console.ReadLine(), out usereLEctricityConsumption ) || usereLEctricityConsumption < 0 ){

            Console.WriteLine("Λάθος εισαγωγή δεδομένων από τον χρήστη");
            return;

        }
        // Μετατροπή και υπολογισμοί - Λογική του προγράμματος

       totalCost = (usereLEctricityConsumption * ENERGY_COST_PER_KWH) + FIXED_COST + (usereLEctricityConsumption * RES_FEE);
       vatAmount = totalCost * VAT;
       totalCostWithVAT = totalCost + vatAmount;

        // Εμφάνιση αποτελεσμάτων
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine($"{"Το συνολικό κόστος χωρις ΦΠΑ είναι", -20} {totalCost:N2}\u20AC");
        Console.WriteLine($"{"Το ποσό του ΦΠΑ είναι:", -20} { vatAmount:N2}\u20AC");
        Console.WriteLine($"{"Το συνολικό κόστος με ΦΠΑ είναι:", -20} { totalCostWithVAT:N2}\u20AC");


    }

}
