using TestePratica;
internal class Teste1
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Teste 1:");
        int INDICE = 13, SOMA = 0, K = 0;
        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
            System.Console.WriteLine(SOMA);
        }//1,3,6,10,15,21,28,36,45,55,66,78,91
        System.Console.WriteLine("Teste 2:");
        System.Console.WriteLine("Entre com um numero");
        int numero = int.Parse(Console.ReadLine());
        Teste2 teste2 = new Teste2();
        teste2.calcularSequencia(numero);

        System.Console.WriteLine("Teste 5:");
        Teste5 teste5 = new Teste5();
        string textoOriginal = "Abacate";
        Console.WriteLine("original: " + textoOriginal);

        Console.WriteLine("invertida: " +  teste5.InverterTexto(textoOriginal));
    
}
}