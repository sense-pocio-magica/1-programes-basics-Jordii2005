namespace exercici12;

/* Fes un programa que a partir de dos números imprimeixi per pantalla la seva suma, la seva resta, 
la seva multiplicació i la seva divisió

Entra el primer número: 3
Entra el segon número: 4

4 + 3 = 7
4 - 3 = 1
4 * 5 = 12
4 / 3 = 1  i en sobra 1


Entra el primer número: 25
Entra el segon número: 5

25 + 5 = 30
25 - 5 = 20
25 * 5 = 125
25 / 5 = 5  i en sobra 0
*/



class Program
{
    static void Main(string[] args)
    {
         Console.Write("Introdueix el primer numero :");
        string numero1 = Console.ReadLine();
        Console.Write("Introdueix el segon numero :");
        string numero2 = Console.ReadLine();
        if (int.TryParse(numero1, out int nm1) && int.TryParse(numero2, out int nm2))
        {

            int suma = nm1 + nm2;
            int resta = nm1 - nm2;
            int multiplicació = nm1 * nm2;
            int divisió = nm1 / nm2;
            int restadivisio = nm1 % nm2;

            Console.WriteLine($"{nm1} + {nm2} = {suma}");
            Console.WriteLine($"{nm1} - {nm2} = {resta}");
            Console.WriteLine($"{nm1} * {nm2} = {multiplicació}");
            Console.WriteLine($"{nm1} / {nm2} = {divisió} i en sobra {restadivisio}");

        }

        else
        {
            Console.WriteLine("Han de ser numero enters ");
        }

    }
}

