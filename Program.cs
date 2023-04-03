
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("A string será invertida");
        
        string textoNormal = "";
        while (textoNormal == string.Empty){
            Console.Write("Favor digitar a string: ");
            textoNormal = Console.ReadLine();
        }

        string textoInvertido = "";        
        for (int i = textoNormal.Length - 1; i >= 0; i--){
            textoInvertido += textoNormal[i];
        }

        Console.WriteLine($"String digitada: {textoNormal}");
        Console.WriteLine($"String invertida: {textoInvertido}");
        
    }  
}