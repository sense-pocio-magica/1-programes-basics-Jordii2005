namespace exercici18;

/* Un rellotger està perdent la memòria i necessita un programa que a partir de l'hora actual li puguem dir
 quina hora serà d’aquí un nombre determinat d’hores.

Hora actual: 9
Hores a incrementar: 3
D'aquí a 3 hores seran les 12


Hora actual: 11
Hores a incrementar: 3
D'aquí a 3 hores seran les 2
*/ 

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix l'hora actual (0-24) :");
        string horaActual = Console.ReadLine();
        Console.Write("Introdueix les hores a incrementar :");
        string horesAIncrementar = Console.ReadLine();

        if (int.TryParse(horaActual, out int hora) && int.TryParse(horesAIncrementar, out int incrementar))
        {
            if (hora >= 0 && hora < 24)
            {
                int novaHora = (hora + incrementar) % 24;
                Console.WriteLine($"D'aquí a {incrementar} hores seran les {novaHora}");
            }
        }
    }
}
