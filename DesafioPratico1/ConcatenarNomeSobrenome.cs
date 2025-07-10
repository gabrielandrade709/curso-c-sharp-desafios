namespace DesafioPratico1;

public class ConcatenarNomeSobrenome
{
    public static void ConcatenarNome()
    {
        Console.WriteLine("Informe o seu primeiro nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Informe o seu sobrenome");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"Seu nome é {nome} {sobrenome}");
    }
}
