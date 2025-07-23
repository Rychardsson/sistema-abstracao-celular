namespace DesafioPOO.Models
{
    /// <summary>
    /// Exemplo de como estender o sistema com uma nova marca de smartphone
    /// </summary>
    public class Samsung : Smartphone, ISmartphoneFeatures
    {
        private readonly List<string> _aplicativosInstalados;
        private readonly List<string> _galaxyStore;

        public IReadOnlyList<string> AplicativosInstalados => _aplicativosInstalados.AsReadOnly();
        public IReadOnlyList<string> GalaxyStore => _galaxyStore.AsReadOnly();

        public Samsung(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            _aplicativosInstalados = new List<string> 
            { 
                "Samsung Internet", "Galaxy Store", "Câmera", "Galeria", "Configurações" 
            };
            _galaxyStore = new List<string> 
            { 
                "Instagram", "WhatsApp", "TikTok", "YouTube", "Netflix", 
                "Samsung Health", "Samsung Pay", "SmartThings", "Bixby" 
            };
        }

        public override void Ligar()
        {
            Console.WriteLine($"🎵 Samsung {Modelo} ligando com toque Galaxy...");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine($"📱 Samsung {Modelo} recebendo ligação com One UI...");
        }

        public override void InstalarAplicativo(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("❌ Nome do aplicativo não pode ser vazio.");
                return;
            }

            if (_aplicativosInstalados.Contains(nome, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine($"⚠️ {nome} já está instalado no Samsung {Modelo}.");
                return;
            }

            if (!_galaxyStore.Contains(nome, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine($"❌ {nome} não foi encontrado na Galaxy Store.");
                return;
            }

            _aplicativosInstalados.Add(nome);
            Console.WriteLine($"🏪 Conectando à Galaxy Store...");
            Console.WriteLine($"📥 Instalando {nome} no Samsung {Modelo}...");
            Console.WriteLine($"✅ {nome} instalado com sucesso!");
        }

        public override void DesinstalarAplicativo(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("❌ Nome do aplicativo não pode ser vazio.");
                return;
            }

            var app = _aplicativosInstalados.FirstOrDefault(a => 
                string.Equals(a, nome, StringComparison.OrdinalIgnoreCase));

            if (app == null)
            {
                Console.WriteLine($"❌ {nome} não está instalado no Samsung {Modelo}.");
                return;
            }

            var sistemApps = new[] { "Samsung Internet", "Galaxy Store", "Câmera", "Configurações" };
            if (sistemApps.Contains(app, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine($"⚠️ {nome} é um aplicativo do sistema e não pode ser removido.");
                return;
            }

            _aplicativosInstalados.Remove(app);
            Console.WriteLine($"🗑️ Removendo {nome} do Samsung {Modelo}...");
            Console.WriteLine($"✅ {nome} removido com sucesso!");
        }

        public void ExibirAplicativos()
        {
            Console.WriteLine($"📱 Aplicativos instalados no Samsung {Modelo}:");
            foreach (var app in _aplicativosInstalados)
            {
                Console.WriteLine($"   • {app}");
            }
        }

        public void AbrirGalaxyStore()
        {
            Console.WriteLine($"🏪 Abrindo Galaxy Store no Samsung {Modelo}...");
            Console.WriteLine("📱 Aplicativos Samsung disponíveis:");
            foreach (var app in _galaxyStore.Take(5))
            {
                Console.WriteLine($"   • {app}");
            }
            Console.WriteLine("   ... e muitos outros!");
        }

        public void UsarBixby()
        {
            Console.WriteLine($"🤖 \"Hi Bixby\" ativado no Samsung {Modelo}!");
            Console.WriteLine("🎙️ Bixby: Olá! Como posso ajudá-lo hoje?");
        }

        public void AbrirSamsungDeX()
        {
            Console.WriteLine($"🖥️ Iniciando Samsung DeX no {Modelo}...");
            Console.WriteLine("💻 Modo desktop ativado!");
        }
    }
}
