using DesafioPOO.Models;
using DesafioPOO.Tests;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Configurar encoding para suportar caracteres especiais
        Console.OutputEncoding = Encoding.UTF8;
        
        // Verificar se o terminal suporta UTF-8, senão usar versão ASCII
        bool useEmojis = SupportsUTF8();
        
        if (useEmojis)
        {
            ExecutarVersaoComEmojis();
        }
        else
        {
            ExecutarVersaoSimples();
        }
    }

    static bool SupportsUTF8()
    {
        try
        {
            Console.OutputEncoding = Encoding.UTF8;
            return true;
        }
        catch
        {
            return false;
        }
    }

    static void ExecutarVersaoComEmojis()
    {
        Console.WriteLine("📱 SISTEMA DE GERENCIAMENTO DE SMARTPHONES 📱");
        Console.WriteLine("=".PadRight(50, '='));
        Console.WriteLine();

        try
        {
            // Testando Nokia
            Console.WriteLine("🔶 TESTANDO NOKIA 🔶");
            var nokia = new Nokia("11987654321", "Nokia 3310", "111111111111111", 64);
            TestarSmartphone(nokia);
            
            Console.WriteLine();
            nokia.JogarSnake();
            nokia.ExibirAplicativos();

            Console.WriteLine("\n" + "=".PadRight(50, '=') + "\n");

            // Testando iPhone
            Console.WriteLine("🔷 TESTANDO IPHONE 🔷");
            var iphone = new Iphone("11912345678", "iPhone 14 Pro", "222222222222222", 256);
            TestarSmartphone(iphone);
            
            Console.WriteLine();
            iphone.AbrirAppStore();
            iphone.UsarSiri();
            iphone.ExibirAplicativos();

            Console.WriteLine("\n" + "=".PadRight(50, '=') + "\n");

            // Testando Samsung
            Console.WriteLine("🔸 TESTANDO SAMSUNG 🔸");
            var samsung = new Samsung("11911111111", "Galaxy S23 Ultra", "333333333333333", 512);
            TestarSmartphone(samsung);
            
            Console.WriteLine();
            samsung.AbrirGalaxyStore();
            samsung.UsarBixby();
            samsung.AbrirSamsungDeX();
            samsung.ExibirAplicativos();

            Console.WriteLine("\n" + "=".PadRight(50, '=') + "\n");

            // Demonstração adicional de funcionalidades
            Console.WriteLine("🔧 DEMONSTRAÇÃO DE FUNCIONALIDADES AVANÇADAS 🔧");
            DemonstrarFuncionalidadesAvancadas(nokia, iphone);

            Console.WriteLine("\n" + "=".PadRight(50, '=') + "\n");

            // Executando testes de exemplo
            SmartphoneTests.ExecutarTodos();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"❌ Erro durante a execução: {ex.Message}");
        }

        Console.WriteLine("\n✅ Demonstração concluída com sucesso!");
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static void ExecutarVersaoSimples()
    {
        Console.WriteLine("SISTEMA DE GERENCIAMENTO DE SMARTPHONES");
        Console.WriteLine("=".PadRight(50, '='));
        Console.WriteLine();

        try
        {
            // Testando Nokia
            Console.WriteLine(">> TESTANDO NOKIA <<");
            var nokia = new Nokia("11987654321", "Nokia 3310", "111111111111111", 64);
            TestarSmartphoneSimples(nokia);
            
            Console.WriteLine();
            Console.WriteLine("Iniciando o classico jogo Snake no Nokia!");
            Console.WriteLine("Aplicativos instalados no Nokia Nokia 3310:");
            foreach (var app in nokia.AplicativosInstalados)
            {
                Console.WriteLine($"   - {app}");
            }

            Console.WriteLine("\n" + "=".PadRight(50, '=') + "\n");

            // Testando iPhone
            Console.WriteLine(">> TESTANDO IPHONE <<");
            var iphone = new Iphone("11912345678", "iPhone 14 Pro", "222222222222222", 256);
            TestarSmartphoneSimples(iphone);
            
            Console.WriteLine();
            Console.WriteLine("Abrindo App Store no iPhone iPhone 14 Pro...");
            Console.WriteLine("\"Hey Siri\" ativado no iPhone iPhone 14 Pro!");
            Console.WriteLine("Siri: Como posso ajuda-lo hoje?");
            Console.WriteLine("Aplicativos instalados no iPhone iPhone 14 Pro:");
            foreach (var app in iphone.AplicativosInstalados)
            {
                Console.WriteLine($"   - {app}");
            }

            Console.WriteLine("\n" + "=".PadRight(50, '=') + "\n");

            // Testando Samsung
            Console.WriteLine(">> TESTANDO SAMSUNG <<");
            var samsung = new Samsung("11911111111", "Galaxy S23 Ultra", "333333333333333", 512);
            TestarSmartphoneSimples(samsung);
            
            Console.WriteLine();
            Console.WriteLine("Abrindo Galaxy Store no Samsung Galaxy S23 Ultra...");
            Console.WriteLine("\"Hi Bixby\" ativado no Samsung Galaxy S23 Ultra!");
            Console.WriteLine("Bixby: Ola! Como posso ajuda-lo hoje?");
            Console.WriteLine("Iniciando Samsung DeX no Galaxy S23 Ultra...");
            Console.WriteLine("Modo desktop ativado!");
            Console.WriteLine("Aplicativos instalados no Samsung Galaxy S23 Ultra:");
            foreach (var app in samsung.AplicativosInstalados)
            {
                Console.WriteLine($"   - {app}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERRO durante a execucao: {ex.Message}");
        }

        Console.WriteLine("\nDemonstracao concluida com sucesso!");
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static void TestarSmartphone(Smartphone smartphone)
    {
        smartphone.ExibirInformacoes();
        Console.WriteLine();
        
        smartphone.Ligar();
        smartphone.ReceberLigacao();
        
        // Testando instalação de aplicativo
        if (smartphone is Nokia nokia)
        {
            nokia.InstalarAplicativo("Snake");
            nokia.InstalarAplicativo("Calculadora");
        }
        else if (smartphone is Iphone iphone)
        {
            iphone.InstalarAplicativo("Instagram");
            iphone.InstalarAplicativo("WhatsApp");
        }
        else if (smartphone is Samsung samsung)
        {
            samsung.InstalarAplicativo("Samsung Health");
            samsung.InstalarAplicativo("SmartThings");
        }
        
        smartphone.DesligarTelefone();
    }

    static void TestarSmartphoneSimples(Smartphone smartphone)
    {
        Console.WriteLine($"Informacoes do Smartphone:");
        Console.WriteLine($"   Modelo: {smartphone.Modelo}");
        Console.WriteLine($"   Numero: {smartphone.Numero}");
        Console.WriteLine($"   IMEI: {smartphone.IMEI}");
        Console.WriteLine($"   Memoria: {smartphone.Memoria}GB");
        Console.WriteLine();
        
        smartphone.Ligar();
        smartphone.ReceberLigacao();
        
        // Testando instalação de aplicativo
        if (smartphone is Nokia nokia)
        {
            nokia.InstalarAplicativo("Snake");
            nokia.InstalarAplicativo("Calculadora");
        }
        else if (smartphone is Iphone iphone)
        {
            iphone.InstalarAplicativo("Instagram");
            iphone.InstalarAplicativo("WhatsApp");
        }
        else if (smartphone is Samsung samsung)
        {
            samsung.InstalarAplicativo("Samsung Health");
            samsung.InstalarAplicativo("SmartThings");
        }
        
        smartphone.DesligarTelefone();
    }

    static void DemonstrarFuncionalidadesAvancadas(Nokia nokia, Iphone iphone)
    {
        Console.WriteLine("📋 Testando validações e casos especiais:\n");

        // Testando instalação de app já existente
        Console.WriteLine("1️⃣ Tentando instalar aplicativo já existente:");
        nokia.InstalarAplicativo("Snake");
        Console.WriteLine();

        // Testando desinstalação
        Console.WriteLine("2️⃣ Testando desinstalação:");
        nokia.DesinstalarAplicativo("Calculadora");
        Console.WriteLine();

        // Testando app não encontrado na App Store (iPhone)
        Console.WriteLine("3️⃣ Tentando instalar app não disponível na App Store:");
        iphone.InstalarAplicativo("AppInexistente");
        Console.WriteLine();

        // Testando remoção de app do sistema (iPhone)
        Console.WriteLine("4️⃣ Tentando remover aplicativo do sistema:");
        iphone.DesinstalarAplicativo("Safari");
        Console.WriteLine();

        // Testando validações de entrada vazia
        Console.WriteLine("5️⃣ Testando validações de entrada:");
        nokia.InstalarAplicativo("");
        iphone.DesinstalarAplicativo("");
    }
}
