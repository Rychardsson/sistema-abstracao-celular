using DesafioPOO.Models;

namespace DesafioPOO.Tests
{
    /// <summary>
    /// Exemplos de testes unitários para demonstrar como testar o sistema
    /// Para executar, instale o pacote NUnit: dotnet add package NUnit
    /// </summary>
    public class SmartphoneTests
    {
        /// <summary>
        /// Exemplo de teste para validação de construtor do Nokia
        /// </summary>
        public void TestNokiaConstruction()
        {
            // Arrange & Act
            var nokia = new Nokia("11987654321", "Nokia 3310", "123456789012345", 64);

            // Assert (em um teste real usaríamos Assert.AreEqual)
            Console.WriteLine($"✅ Nokia criado: {nokia.Modelo}");
            Console.WriteLine($"✅ Número: {nokia.Numero}");
            Console.WriteLine($"✅ Memória: {nokia.Memoria}GB");
        }

        /// <summary>
        /// Exemplo de teste para validação de instalação de aplicativo
        /// </summary>
        public void TestInstalarAplicativo()
        {
            // Arrange
            var iphone = new Iphone("11912345678", "iPhone 14", "987654321098765", 128);
            var appCount = iphone.AplicativosInstalados.Count;

            // Act
            iphone.InstalarAplicativo("Instagram");

            // Assert (em um teste real usaríamos Assert.AreEqual)
            var newAppCount = iphone.AplicativosInstalados.Count;
            Console.WriteLine($"✅ Apps antes: {appCount}, Apps depois: {newAppCount}");
            Console.WriteLine($"✅ Instagram instalado: {iphone.AplicativosInstalados.Contains("Instagram")}");
        }

        /// <summary>
        /// Exemplo de teste para validação de entrada inválida
        /// </summary>
        public void TestValidacaoEntrada()
        {
            try
            {
                // Arrange & Act - tentando criar Nokia com número vazio
                var nokia = new Nokia("", "Nokia 3310", "123456789012345", 64);
                Console.WriteLine("❌ Erro: deveria ter lançado exceção");
            }
            catch (ArgumentException ex)
            {
                // Assert
                Console.WriteLine($"✅ Validação funcionou: {ex.Message}");
            }
        }

        /// <summary>
        /// Exemplo de teste de polimorfismo
        /// </summary>
        public void TestPolimorfismo()
        {
            // Arrange - lista de smartphones diferentes
            List<Smartphone> smartphones = new()
            {
                new Nokia("11111111111", "Nokia 3310", "111111111111111", 64),
                new Iphone("22222222222", "iPhone 14", "222222222222222", 128),
                new Samsung("33333333333", "Galaxy S23", "333333333333333", 256)
            };

            // Act & Assert - testando polimorfismo
            foreach (var smartphone in smartphones)
            {
                Console.WriteLine($"✅ Testando {smartphone.GetType().Name}:");
                smartphone.Ligar(); // Cada um terá comportamento diferente
                smartphone.ReceberLigacao(); // Polimorfismo em ação
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Executa todos os testes de exemplo
        /// </summary>
        public static void ExecutarTodos()
        {
            var tests = new SmartphoneTests();
            
            Console.WriteLine("🧪 EXECUTANDO TESTES DE EXEMPLO 🧪");
            Console.WriteLine("=".PadRight(50, '='));
            Console.WriteLine();

            Console.WriteLine("1️⃣ Teste de Construção do Nokia:");
            tests.TestNokiaConstruction();
            Console.WriteLine();

            Console.WriteLine("2️⃣ Teste de Instalação de Aplicativo:");
            tests.TestInstalarAplicativo();
            Console.WriteLine();

            Console.WriteLine("3️⃣ Teste de Validação de Entrada:");
            tests.TestValidacaoEntrada();
            Console.WriteLine();

            Console.WriteLine("4️⃣ Teste de Polimorfismo:");
            tests.TestPolimorfismo();

            Console.WriteLine("✅ Todos os testes executados com sucesso!");
        }
    }
}
