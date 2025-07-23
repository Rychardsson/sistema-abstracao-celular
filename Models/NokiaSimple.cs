namespace DesafioPOO.Models
{
    public class NokiaSimple : Smartphone, ISmartphoneFeatures
    {
        private readonly List<string> _aplicativosInstalados;

        public IReadOnlyList<string> AplicativosInstalados => _aplicativosInstalados.AsReadOnly();

        public NokiaSimple(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            _aplicativosInstalados = new List<string> { "Snake", "Galeria", "Contatos" };
        }

        public override void Ligar()
        {
            Console.WriteLine($"Nokia {Modelo} ligando com som classico...");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine($"Nokia {Modelo} recebendo ligacao com toque Nokia Tune...");
        }

        public override void InstalarAplicativo(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("ERRO: Nome do aplicativo nao pode ser vazio.");
                return;
            }

            if (_aplicativosInstalados.Contains(nome, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine($"AVISO: {nome} ja esta instalado no Nokia {Modelo}.");
                return;
            }

            _aplicativosInstalados.Add(nome);
            Console.WriteLine($"Instalando {nome} no Nokia {Modelo}.");
            Console.WriteLine($"SUCESSO: {nome} instalado com sucesso!");
        }

        public override void DesinstalarAplicativo(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("ERRO: Nome do aplicativo nao pode ser vazio.");
                return;
            }

            var app = _aplicativosInstalados.FirstOrDefault(a => 
                string.Equals(a, nome, StringComparison.OrdinalIgnoreCase));

            if (app == null)
            {
                Console.WriteLine($"ERRO: {nome} nao esta instalado no Nokia {Modelo}.");
                return;
            }

            _aplicativosInstalados.Remove(app);
            Console.WriteLine($"Desinstalando {nome} do Nokia {Modelo}.");
            Console.WriteLine($"SUCESSO: {nome} removido com sucesso!");
        }

        public void ExibirAplicativos()
        {
            Console.WriteLine($"Aplicativos instalados no Nokia {Modelo}:");
            foreach (var app in _aplicativosInstalados)
            {
                Console.WriteLine($"   - {app}");
            }
        }

        public void JogarSnake()
        {
            if (_aplicativosInstalados.Contains("Snake", StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("Iniciando o classico jogo Snake no Nokia!");
            }
            else
            {
                Console.WriteLine("ERRO: Snake nao esta instalado. Instalando...");
                InstalarAplicativo("Snake");
            }
        }
    }
}
