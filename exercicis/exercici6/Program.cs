namespace exercici6;

/* Declara una variable per al costat d'un quadrat. Calcula el seu perímetre (suma dels quatre costats) 
i imprimeix-lo. */

class Program
{
    static void Main(string[] args)
    {
    
        Console.Write("Introdueix la mida del costat del quadrat :");
        string costat = Console.ReadLine();
        if (double.TryParse(costat, out double midacostat))
        {
            double perimetre = midacostat * 4;
            Console.WriteLine($"El perimetre del costat es {perimetre}");
        }
    }
}

    