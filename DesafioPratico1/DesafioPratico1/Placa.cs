namespace DesafioPratico1;

public class Placa
{
    public static void ValidarPlaca()
    {
        Console.WriteLine("Informe a placa do veículo: ");
        string placa = Console.ReadLine();

        if (placa.Length != 7 
            || !char.IsLetter(placa[0]) || !char.IsLetter(placa[1]) || !char.IsLetter(placa[2]) 
            || !char.IsNumber(placa[3]) || !char.IsNumber(placa[4]) || !char.IsNumber(placa[5]) || char.IsLetter(placa[6]))
        {
            Console.WriteLine("Falso");
        } else
        {
            Console.WriteLine("Verdadeiro");
        }
    }
}
