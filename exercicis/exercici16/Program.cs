namespace exercici16;

/* Ningú entén res del nou sistema d’avaluació. Necessitem un programa que calculi la part que és més senzilla: 
a partir de la mitjana de les notes les pràctiques i la nota de l’examen ens calculi la nota final

Nota de pràctiques: 8
Nota de l’examen: 9
La nota final és 8.7 o sigui un 8

Nota de pràctiques: 10
Nota de l’examen: 5
La nota final és 6.5 o sigui un 7 
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix la nota de practiques :");
        string notapractiques = Console.ReadLine();
        Console.Write("Introdueix la nota de examen :");
        string notaexamen = Console.ReadLine();

        if (double.TryParse(notapractiques, out double practiques) && double.TryParse(notaexamen, out double examen))
        {
            double mitjana = (practiques + examen) / 2;
            int notaFinal = (int)Math.Round(mitjana);

            Console.WriteLine($"La mitjana es {mitjana} o sigui un {notaFinal}");
        }
    }
}


