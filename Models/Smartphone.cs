namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string _numero = string.Empty;
        private string _modelo = string.Empty;
        private string _imei = string.Empty;
        private int _memoria;

        public string Numero 
        { 
            get => _numero;
            set => _numero = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Número não pode ser vazio");
        }

        public string Modelo 
        { 
            get => _modelo;
            protected set => _modelo = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Modelo não pode ser vazio");
        }

        public string IMEI 
        { 
            get => _imei;
            protected set => _imei = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("IMEI não pode ser vazio");
        }

        public int Memoria 
        { 
            get => _memoria;
            protected set => _memoria = value > 0 ? value : throw new ArgumentException("Memória deve ser maior que zero");
        }

        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public virtual void Ligar()
        {
            Console.WriteLine($"📞 Ligando do {Modelo}...");
        }

        public virtual void ReceberLigacao()
        {
            Console.WriteLine($"📱 Recebendo ligação no {Modelo}...");
        }

        public virtual void DesligarTelefone()
        {
            Console.WriteLine($"📴 Desligando {Modelo}...");
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"""
                📱 Informações do Smartphone:
                   Modelo: {Modelo}
                   Número: {Numero}
                   IMEI: {IMEI}
                   Memória: {Memoria}GB
                """);
        }

        public abstract void InstalarAplicativo(string nome);
        public abstract void DesinstalarAplicativo(string nome);
    }
}
