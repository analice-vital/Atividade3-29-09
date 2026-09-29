using System;

namespace FitManager.Classes
{
    public class Mensalidade
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public decimal Valor { get; set; }
        public DateTime Vencimento { get; set; }

        public bool Paga { get; private set; }

        public Mensalidade()
        {
        }

        public Mensalidade(
            int id,
            int alunoId,
            decimal valor,
            DateTime vencimento)
        {
            Id = id;
            AlunoId = alunoId;
            Valor = valor;
            Vencimento = vencimento;
            Paga = false;
        }

        public void RegistrarPagamento()
        {
            Paga = true;
        }

        public bool EstaAtrasada()
        {
            return !Paga && DateTime.Now.Date > Vencimento.Date;
        }
    }
}
