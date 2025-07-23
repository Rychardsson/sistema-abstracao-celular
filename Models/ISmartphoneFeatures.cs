namespace DesafioPOO.Models
{
    /// <summary>
    /// Interface que define funcionalidades comuns que um smartphone moderno deve ter
    /// </summary>
    public interface ISmartphoneFeatures
    {
        /// <summary>
        /// Lista de aplicativos instalados no dispositivo
        /// </summary>
        IReadOnlyList<string> AplicativosInstalados { get; }

        /// <summary>
        /// Instala um aplicativo no dispositivo
        /// </summary>
        /// <param name="nome">Nome do aplicativo a ser instalado</param>
        void InstalarAplicativo(string nome);

        /// <summary>
        /// Remove um aplicativo do dispositivo
        /// </summary>
        /// <param name="nome">Nome do aplicativo a ser removido</param>
        void DesinstalarAplicativo(string nome);

        /// <summary>
        /// Exibe todos os aplicativos instalados
        /// </summary>
        void ExibirAplicativos();
    }
}
