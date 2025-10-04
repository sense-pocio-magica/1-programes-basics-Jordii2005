namespace exercici9;

/* Demana un valor en metres. Converteix el valor a peus (1 metre = 3,28084 metres) 
i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix un valor en metres :");
        string metres = Console.ReadLine();
        if (double.TryParse(metres, out double valorMetres))
        {
            double peus = valorMetres * 3.28084;
            Console.WriteLine($"{valorMetres} metres son {peus} peus");
        }
        else
        {
            Console.WriteLine("El valor ha de ser un numero");
        }
    }
}
