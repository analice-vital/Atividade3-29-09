namespace FitManager.Classes
{
    public class Plano
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int DuracaoMeses { get; set; }

        public Plano()
        {
        }

        public Plano(int id, string nome, decimal valor, int duracaoMeses)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            DuracaoMeses = duracaoMeses;
        }

        public string ExibirPlano()
        {
            return $"{Nome} - R$ {Valor:F2} - {DuracaoMeses} mês(es)";
        }
    }
}