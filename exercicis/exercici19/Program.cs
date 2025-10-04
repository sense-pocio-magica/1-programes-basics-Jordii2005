namespace exercici19;

// Assigna una paraula a una variable de text. Utilitza una funció per a obtenir la seva longitud i 
// imprimeix la paraula i el seu nombre de caràcters.
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix una paraula: ");
        string paraula = Console.ReadLine();

        if (!string.IsNullOrEmpty(paraula))
        {
            int longitud = paraula.Length;
            Console.WriteLine($"La paraula és: {paraula} i té {longitud} caràcters.");
        }
    }
}
