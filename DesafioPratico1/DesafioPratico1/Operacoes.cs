namespace DesafioPratico1;

public class Operacoes
{
    public static void Calculos()
    {
        Console.WriteLine("Informe o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Informe o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"{numero1} + {numero2} = " + (numero1 + numero2));

        Console.WriteLine($"{numero1} - {numero2} = " + (numero1 - numero2));

        Console.WriteLine($"{numero1} X {numero2} = " + (numero1 * numero2));

        Console.WriteLine($"{numero1} / {numero2} = " + (numero2 == 0 ? numero1 / 1 : numero1 / numero2));

        Console.WriteLine($"A média entre {numero1} e {numero2} é " + ((numero1 + numero2) / 2));
    }
}
