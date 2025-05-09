namespace TestePratica
{
    public class Teste2{
    int a = 0;
    int b = 1;
    public void calcularSequencia(int numero){
        if (numero == 0 || numero == 1)
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
            return;
        }

        int fib = a + b;
        while (fib < numero)
        {
            a = b;
            b = fib;
            fib = a + b;
        }

        if (fib == numero)
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
    }

    }
    }