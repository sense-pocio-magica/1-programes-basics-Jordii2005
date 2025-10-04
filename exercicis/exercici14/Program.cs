namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix una paraula: ");
        string paraula = Console.ReadLine();

        if (!string.IsNullOrEmpty(paraula))
        {
            int longitud = paraula.Length;
            char primeraLletra = paraula[0];
            char ultimaLletra = paraula[longitud - 1];
            char lletraDelMig = paraula[longitud / 2];

            Console.WriteLine($"La primera lletra és: {primeraLletra}");
            Console.WriteLine($"L'última lletra és: {ultimaLletra}");
            Console.WriteLine($"La lletra del mig és: {lletraDelMig}");
        }
        else
        {
            Console.WriteLine("No has introduït cap paraula.");
        }
    }
}

