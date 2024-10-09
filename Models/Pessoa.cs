using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        //CRIANDO UM CONSTRUTOR - deve ser logo o primeiro codigo da classe - deve ter o mesmo nome de sua classe - não terá um retorno
        //pode ser vazio ou receber parametros
        //é possivel ter mais q um construtor
        //aqui temos dois, um que n recebe nada e um q recebe nome e sobrenome
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }
        private string _nome;
        private int _idade;
        
        public string Nome //prop Nome
        { 
            // o get é para obter valores - (ler)
            //usar o => quando retorna uma unica linha / quando  é simples
            get =>  _nome.ToUpper();

            //o set é para atribuir valores - (escrever)
            set 
            {
                if(value=="")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public string Sobrenome { get; set; }
        //uma propriedade so de get, juntando o nome e sobrenome
        //sendo get, é apenas para leitura
        //e posso simplificar com o => (bodyExpressions)
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade 
        { 
            get => _idade;
            set
            {
                if(value<0)
                {
                    throw new ArgumentException("A idade não pode ser negativa");
                }
                _idade = value;
            }
        }
        
        public void Apresentar(){
            Console.WriteLine($"Nome: {NomeCompleto} \nIdade: {Idade}");
        }
    }
}