namespace FitManager.Classes
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(int id, string nome, string cpf, string telefone, string email)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
        }

        public virtual string ExibirResumo()
        {
            return $"ID: {Id} | Nome: {Nome} | CPF: {CPF}";
        }
    }
}