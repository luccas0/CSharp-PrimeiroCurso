using System;
class Programa
{
    static void Main(string[] args)
    {

        int nFatorial = 1;

        for(int i = 1; i < 11; i++)
        {
            nFatorial *= i;

            Console.WriteLine("O fatorial de " + i + " é " + nFatorial);
        }





        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
