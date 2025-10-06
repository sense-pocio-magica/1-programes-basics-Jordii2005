namespace exercici5;

/* Feu un programa que demani un nom i l’any de naixement i imprimeixi per pantalla 
“Hola [nom]!  Ja tens [edat] anys? 
nom i edat seran el nom introduït i l'edat la resta de l’any actual i l’any de naixement. */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introdueix el teu nom :");
        string nom = Console.ReadLine();
        Console.WriteLine("Introdueix el teu any de naixament :");
        int anyNaixement = Convert.ToInt16(Console.ReadLine());
        int anyActual = DateTime.Now.Year;
        int edat = anyActual - anyNaixement;
        Console.WriteLine($"Hola {nom}! Ja tens {edat} anys?");
    }
}


