namespace DesafioPratico1;

public class Data
{
    public static void FormatarDataAtual()
    {
        DateTime dataAtual = DateTime.Now;

        Console.WriteLine(dataAtual.ToString("dddd, MM, MMMM, yyyy, HH, mm, ss"));
        Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
        Console.WriteLine(dataAtual.ToString("HH"));
        Console.WriteLine(dataAtual.ToString("dd MMMM yyyy"));
    }
}
