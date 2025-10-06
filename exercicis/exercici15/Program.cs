namespace exercici15;

// Assigna un nom i un cognom en variables. Imprimeix el nom complet, 
// assegurant-te que la primera lletra de cada paraula estigui en majúscula
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix el nom :");
        string nom = Console.ReadLine();
        Console.Write("Introdueix el cognom :");
        string cognom = Console.ReadLine();

        nom = char.ToUpper(nom[0]) + nom.Substring(1).ToLower();
        cognom = char.ToUpper(cognom[0]) + cognom.Substring(1).ToLower();

        Console.WriteLine($"Nom complet es {nom} {cognom}");
    }
}
