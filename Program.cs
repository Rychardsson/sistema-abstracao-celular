using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testando o Nokia:");
        Smartphone nokia = new Nokia("123456", "Nokia 3310", "111111111111111", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");

        Console.WriteLine("\n-------------------------\n");

        Console.WriteLine("Testando o iPhone:");
        Smartphone iphone = new Iphone("789012", "iPhone 13", "222222222222222", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
