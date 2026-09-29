namespace FitManager.Classes
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(
            int id,
            string nome,
            string cpf,
            string telefone,
            string email,
            string cargo)
            : base(id, nome, cpf, telefone, email)
        {
            Cargo = cargo;
        }

        public override string ExibirResumo()
        {
            return $"Funcionário: {Nome} | Cargo: {Cargo}";
        }
    }
}