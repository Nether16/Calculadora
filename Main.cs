internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escolha a operação : ");
        Console.WriteLine("1 - Adição");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        int operacao = int.Parse(Console.ReadLine());

        Console.WriteLine("Escolha o primeiro numero do calculo : ");
        float num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Escolha o segundo numero do calculo : ");
        float num2 = float.Parse(Console.ReadLine());
        float resultado = 0;

        switch (operacao)
        {
            case 1: resultado = num1 + num2; break;
            case 2: resultado = num1 - num2; break;
            case 3: resultado = num1 * num2; break;
            case 4: resultado = num1 / num2; break;
        }

        Console.WriteLine($"O resultado da sua operação foi {resultado}");
    }
}