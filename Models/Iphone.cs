namespace DesafioPOO.Models
{
    public class Iphone : Smartphone, ISmartphoneFeatures
    {
        private readonly List<string> _aplicativosInstalados;
        private readonly List<string> _appStoreApps;

        public IReadOnlyList<string> AplicativosInstalados => _aplicativosInstalados.AsReadOnly();
        public IReadOnlyList<string> AppStoreApps => _appStoreApps.AsReadOnly();

        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            _aplicativosInstalados = new List<string> { "Safari", "Câmera", "Configurações", "App Store" };
            _appStoreApps = new List<string> 
            { 
                "Instagram", "WhatsApp", "TikTok", "YouTube", "Netflix", 
                "Spotify", "Twitter", "Facebook", "LinkedIn", "Uber" 
            };
        }

        public override void Ligar()
        {
            Console.WriteLine($"📱 iPhone {Modelo} ligando com Face ID/Touch ID...");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine($"🎵 iPhone {Modelo} recebendo ligação com toque personalizado...");
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
                Console.WriteLine($"⚠️ {nome} já está instalado no iPhone {Modelo}.");
                return;
            }

            // Simular verificação na App Store
            if (!_appStoreApps.Contains(nome, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine($"❌ {nome} não foi encontrado na App Store.");
                return;
            }

            _aplicativosInstalados.Add(nome);
            Console.WriteLine($"📱 Conectando à App Store...");
            Console.WriteLine($"📥 Baixando {nome} para iPhone {Modelo}...");
            Console.WriteLine($"✅ {nome} instalado com sucesso da App Store!");
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
                Console.WriteLine($"❌ {nome} não está instalado no iPhone {Modelo}.");
                return;
            }

            // Aplicativos do sistema não podem ser removidos
            var sistemApps = new[] { "Safari", "Câmera", "Configurações", "App Store" };
            if (sistemApps.Contains(app, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine($"⚠️ {nome} é um aplicativo do sistema e não pode ser removido.");
                return;
            }

            _aplicativosInstalados.Remove(app);
            Console.WriteLine($"🗑️ Removendo {nome} do iPhone {Modelo}...");
            Console.WriteLine($"✅ {nome} removido com sucesso!");
        }

        public void ExibirAplicativos()
        {
            Console.WriteLine($"📱 Aplicativos instalados no iPhone {Modelo}:");
            foreach (var app in _aplicativosInstalados)
            {
                Console.WriteLine($"   • {app}");
            }
        }

        public void AbrirAppStore()
        {
            Console.WriteLine($"🏪 Abrindo App Store no iPhone {Modelo}...");
            Console.WriteLine("📱 Aplicativos disponíveis para download:");
            foreach (var app in _appStoreApps.Take(5))
            {
                Console.WriteLine($"   • {app}");
            }
            Console.WriteLine("   ... e muitos outros!");
        }

        public void UsarSiri()
        {
            Console.WriteLine($"🎤 \"Hey Siri\" ativado no iPhone {Modelo}!");
            Console.WriteLine("🤖 Siri: Como posso ajudá-lo hoje?");
        }
    }
}
