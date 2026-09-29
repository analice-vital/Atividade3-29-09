using System;
using System.Collections.Generic;
using FitManager.Interfaces;

namespace FitManager.Classes
{
    public class Academia : IPagamento
    {
        public string Nome { get; set; }

        public List<Aluno> Alunos { get; set; }
        public List<Funcionario> Funcionarios { get; set; }
        public List<Plano> Planos { get; set; }
        public List<Matricula> Matriculas { get; set; }
        public List<Mensalidade> Mensalidades { get; set; }

        private static int codigoAtendimento = 1000;

        public Academia()
        {
            Alunos = new List<Aluno>();
            Funcionarios = new List<Funcionario>();
            Planos = new List<Plano>();
            Matriculas = new List<Matricula>();
            Mensalidades = new List<Mensalidade>();
        }

        public Academia(string nome) : this()
        {
            Nome = nome;
        }

        public static int GerarCodigoAtendimento()
        {
            codigoAtendimento++;
            return codigoAtendimento;
        }

        public void AdicionarAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
        }

        public void AdicionarPlano(Plano plano)
        {
            Planos.Add(plano);
        }

        public void AdicionarMatricula(Matricula matricula)
        {
            Matriculas.Add(matricula);
        }

        public void AdicionarMensalidade(Mensalidade mensalidade)
        {
            Mensalidades.Add(mensalidade);
        }

        public decimal CalcularValorEmAberto(int alunoId)
        {
            decimal total = 0;

            foreach (Mensalidade mensalidade in Mensalidades)
            {
                if (mensalidade.AlunoId == alunoId && !mensalidade.Paga)
                {
                    total += mensalidade.Valor;
                }
            }

            return total;
        }

        public bool RealizarPagamento(decimal valor)
        {
            if (valor <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
