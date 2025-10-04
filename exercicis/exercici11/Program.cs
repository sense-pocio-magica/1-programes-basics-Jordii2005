namespace exercici11;

// A partir de dues variables (nom d'usuari i domini), crea i imprimeix una adreça de correu electrònic completa.
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix el teu nom de usuari :");
        string nom = Console.ReadLine();
        Console.Write("Introdueix el domini :");
        string domini = Console.ReadLine();
        string email = nom + "@" + domini + "." +"com";
        Console.WriteLine($"El teu correu es {email}");
    }
}
