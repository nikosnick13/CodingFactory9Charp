namespace ProductsVat;

/// <summary>
/// Reads a product price from the console, calculates the VAT (24%) and the
/// total price including VAT, and prints the results formatted to 2 decimal places.
/// </summary>
internal class Program
{
    static void Main(string[] args)
    {
        // Αρχικοποίηση και δήλωση μεταβλητών

        const double VAT_RATE = 0.24D;

        double productPrice = 0D;
        double vat = 0d;
        double totalPrice = 0D;

        //Εισαγωγή δεδομένων από τον χρήστη,data binding,and validation

        Console.WriteLine("Δώστε την τιμή του προιόντος: ");
        if (!double.TryParse(Console.ReadLine(),out productPrice) || productPrice < 0) {

            Console.WriteLine("Μη έγκηρη τιμή");
        }

        //Επεξεργασία δεδομένων, υπολογισμοί και logic App

        vat = VAT_RATE * productPrice;
        totalPrice = productPrice + vat;

        //Εμφάνιση αποτελεσμάτων στον χρήστη, output binding
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine($"{"Τιμή χωρίς ΦΠΑ:",-20} {productPrice:N2} \u20AC");
        Console.WriteLine($"{"ΦΠΑ(24%):",-20} {vat:N2} \u20AC");
        Console.WriteLine($"{"Τιμή με ΦΠΑ:",-20} {totalPrice:N2} \u20AC");

    }
}
