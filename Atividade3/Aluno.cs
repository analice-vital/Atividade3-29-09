namespace FitManager.Classes
{
    public class Aluno : Pessoa
    {
        public string Objetivo { get; set; }
        public string PlanoAtual { get; set; }

        public Aluno()
        {
        }

        public Aluno(
            int id,
            string nome,
            string cpf,
            string telefone,
            string email,
            string objetivo,
            string planoAtual)
            : base(id, nome, cpf, telefone, email)
        {
            Objetivo = objetivo;
            PlanoAtual = planoAtual;
        }

        public override string ExibirResumo()
        {
            return $"Aluno: {Nome} | Objetivo: {Objetivo} | Plano: {PlanoAtual}";
        }
    }
}
