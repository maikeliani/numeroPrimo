internal class Program
{
    private static void Main(string[] args)
    {
        float numero;
        int contador = 0;
        Console.WriteLine("Digite um numero maior que zero");
        numero = float.Parse(Console.ReadLine());

        for(int x=1; x <= numero; x++)
        {
            if (numero % x == 0)
            {
                contador++;
            }

        }

        if  (contador != 2)
        {
            Console.WriteLine(" Não é numero primo");
        }
        else
        {
            Console.WriteLine(" É numero primo!");
        }
    }
}