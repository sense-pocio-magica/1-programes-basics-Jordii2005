namespace exercici7;

/* Defineix tres variables amb tres notes numèriques. 
Calcula la mitjana i mostra el resultat per pantalla. */ 

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nota 1 :");
        string nota1 = Console.ReadLine();
        Console.Write("Nota 2 :");
        string nota2 = Console.ReadLine();
        Console.Write("Nota 3 :");
        string nota3 = Console.ReadLine();
        if (double.TryParse(nota1, out double n1) && double.TryParse(nota2, out double n2) && double.TryParse(nota3, out double n3))
        {

            double mitjana = (n1 + n2 + n3) / 3;
            Console.WriteLine($"La mitjana es {mitjana:F2}:");
        }
        else
        {
            Console.WriteLine("Les notes han de ser numeros");
        }
    }
}


