namespace TestePratica
{
    public class Teste5
    {
        public string InverterTexto(string texto)
    {
        char[] caracteres = new char[texto.Length];
        int j = 0;

        for (int i = texto.Length - 1; i >= 0; i--)
        {
            caracteres[j] = texto[i];
            j++;
        }

        return new string(caracteres);
    }
    }
}