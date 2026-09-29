namespace FitManager.Classes
{
    public class Professor : Funcionario
    {
        public string Especialidade { get; set; }

        public Professor()
        {
        }

        public Professor(
            int id,
            string nome,
            string cpf,
            string telefone,
            string email,
            string especialidade)
            : base(id, nome, cpf, telefone, email, "Professor")
        {
            Especialidade = especialidade;
        }

        public override string ExibirResumo()
        {
            return $"Professor: {Nome} | Especialidade: {Especialidade}";
        }
    }
}