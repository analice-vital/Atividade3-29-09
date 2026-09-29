using System;

namespace FitManager.Classes
{
    public class Matricula
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public int PlanoId { get; set; }
        public DateTime DataInicio { get; set; }
        public bool Ativa { get; set; }

        public Matricula()
        {
        }

        public Matricula(
            int id,
            int alunoId,
            int planoId,
            DateTime dataInicio)
        {
            Id = id;
            AlunoId = alunoId;
            PlanoId = planoId;
            DataInicio = dataInicio;
            Ativa = true;
        }

        public void Cancelar()
        {
            Ativa = false;
        }
    }
}