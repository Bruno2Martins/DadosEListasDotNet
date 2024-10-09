using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class ExemploExcecao
    {
    //Para lançarmos uma exception e interromper o fluxo de nosso código, usamos uma palavra reservada throw:
    //Throw - se achar uma exceção volta o caminho para tentar tratar pelo catch ou encerra o programa
     public void Metodo1(){
        try{
            Metodo2();
        }catch(Exception){
            Console.WriteLine("Exceção tratada");
        }
    }
     public void Metodo2(){Metodo3();}
     public void Metodo3(){Metodo4();}
     public void Metodo4(){
        throw new Exception("Ocorreu uma exceção");
     }

    }

}