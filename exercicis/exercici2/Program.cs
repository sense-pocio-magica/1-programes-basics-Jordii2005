namespace exercici2;

/* Declara variables per emmagatzemar l’adreça d’una persona: 
carrer, número, codi postal i població. Imprimeix el resultat 
en una sola línia */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entra el carrer :");
        string carrer = Console.ReadLine();
        Console.Write("Entra el número :");
        string número = Console.ReadLine();
        Console.Write("Entra el Codi postal :");
        string codipostal = Console.ReadLine();
        Console.Write("Entra la població :");
        string població = Console.ReadLine();

        Console.WriteLine($"{carrer}, {número}, {codipostal}, {població}");

    }
}
