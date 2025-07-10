namespace DesafioPratico1;

public class Caracteres
{

    public static void ContadorCaracteres()
    {
        Console.WriteLine("Digite uma frase: ");
        string frase = Console.ReadLine();

        Console.WriteLine("A frase possui " + frase?.Replace(" ", "").Length + " caracteres.");
    }

}
