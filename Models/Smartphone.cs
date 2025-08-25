namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; }
        public string IMEI { get; }
        public int Memoria { get; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            if (string.IsNullOrWhiteSpace(numero))
                throw new ArgumentException("Número não pode ser vazio.");
            if (string.IsNullOrWhiteSpace(modelo))
                throw new ArgumentException("Modelo não pode ser vazio.");
            if (string.IsNullOrWhiteSpace(imei) || imei.Length < 10)
                throw new ArgumentException("IMEI inválido.");
            if (memoria <= 0)
                throw new ArgumentException("Memória deve ser maior que zero.");

            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine($"[{Modelo}] Ligando para {FormatarNumero()}");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"[{Modelo}] Chamada recebida de {FormatarNumero()}");
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"\n--- Dados do Aparelho ---");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Memória: {Memoria}GB");
            Console.WriteLine($"Número: {FormatarNumero()}");
        }
        
        public abstract void InstalarAplicativo(string nomeApp);

        private string FormatarNumero()
        {
            if (Numero != null && Numero.Length == 11)
                return $"({Numero.Substring(0, 2)}){Numero.Substring(2, 5)}-{Numero.Substring(7, 4)}";
            return Numero;
        }
    }
}