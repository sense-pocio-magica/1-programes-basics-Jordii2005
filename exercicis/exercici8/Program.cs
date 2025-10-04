namespace exercici8;

/* Assigna un nombre total de minuts a una variable. 
Calcula quantes hores senceres i minuts restants són i imprimeix el resultat. */

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Introdueix un nombre total de minuts :");
        string totalMinuts = Console.ReadLine();
        if (int.TryParse(totalMinuts, out int minuts))
        {
            int hores = minuts / 60;
            int minutsRestants = minuts % 60;
            Console.WriteLine($"{minuts} minuts son {hores} hores i {minutsRestants} minuts");
        }
        else
        {
            Console.WriteLine("El valor ha de ser un numero enter");
        }
    }

}

       