namespace DesafioPratico1;

public class BoasVindas
{
    public static void MensagemBoasVindas()
    {
        Console.WriteLine("Informe o seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
    }
}
