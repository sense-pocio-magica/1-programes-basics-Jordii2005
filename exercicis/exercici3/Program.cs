namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        Console.Write("El nom del prodcute :");
        string producte = Console.ReadLine();
        Console.Write("Preu del prodcute :");
        string preuProducte = Console.ReadLine();
        Console.Write("Esta en estoc si/no :");
        string enEstoc = Console.ReadLine();

        bool estoc = enEstoc == "si";


        Console.WriteLine($"Producte {producte}");
        Console.WriteLine($"Preu del Producte {preuProducte}");
        Console.WriteLine($"Esta en estoc {(estoc ? "Si" : "No" )}");
    }
}

