namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix un numero de tres xifres :");
        string numero = Console.ReadLine();
        if (int.TryParse(numero, out int num) && numero.Length == 3)
        {
            char[] digits = numero.ToCharArray();
            Array.Reverse(digits);
            string numeroInvertit = new string(digits);
            Console.WriteLine($"El numero invertit es: {numeroInvertit}");
        }
    }
}
