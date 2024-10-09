using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        /* 
        void - tipo do metodo / void quando n preciso retornar nada
        AdicionarAluno - Nome do metodo
        Pessoa - (parametro) tipo da variavel, no caso uma classe
        aluno - (parametro) Nome da variavel
        */
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        /*
        int - tipo do metodo / retorno um inteiro
        ObterQ... - Nome do metodo
        () - Não tem parametros / Não tem argumentos
        */
        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            //return - significa que chegou ao final do metodo e lhe dá uma resposta
            return quantidade;
        }
        /*
        Exemplo - se ele retornar um boleano
        se ele removeu com sucesso ou não
        */
        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }
        public void ListarAlunos(){
            Console.WriteLine($"Alunos do curso de {Nome}");
            for (int count = 0; count < Alunos.Count; count++)
            {
                /*MANEIRAS DE CONCATENAR 
                - escrever o texto, colocar o sinal de + e a variavel: 
                "texto" + variavel
                string texto = "N° " + (count+1) + " - " + Alunos[count].NomeCompleto;
                
                - interpolação: 
                $"texto {variavel}" 
                string texto = $"N° {(count+1)} {Alunos[count].NomeCompleto}";
                */
                string texto = $"N° {count + 1} {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }            
        }
    }
}