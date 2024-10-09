using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

// DESERIALIZAÇÃO

//ler o arquivo
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

//como é uma coleção, representa-la tbm, deserializando o arquivo e transformando em objeto no formato de lista
List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);
// faço um foreach para demonstrar o objeto
foreach(Venda venda in listaVenda){
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Preco} - Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy hh:mm")}");
}































// SERIALIZAÇÃO
/*
DateTime dataAtual = DateTime.Now;

// lista para criar uma coleção de objeto 
List<Venda> listaVendas = new List<Venda>();

//objeto
Venda v1 = new Venda(1, "Material de escritorio", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

//adicionando a lista os objetos
listaVendas.Add(v1);
listaVendas.Add(v2);

//serializando / convertendo p json a coleção de objetos
string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

//criando e escrevendo um arquivo com o valor da variavel  
File.WriteAllText("Arquivos/vendas.json", serializado);

//mostrando o que tem na variavel no formato json
Console.WriteLine(serializado);
*/







































//IF TERNARIO - 

/*
// - por exemplo esse codigo esta muito extenso para algo tao simples

int numero = 20;

if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par");
}
else
{
        Console.WriteLine($"O número {numero} é impar");
}
*/


// - utiliza geralmente para comparações simples de sim e nao, if else, (condição ? resultado verdadeiro : resultado falso)
/*int numero = 20;
bool ehPar = false;

ehPar = numero % 2 == 0;
Console.WriteLine($" O número {numero} é "+ (ehPar ? "par":"impar"));

*/






//DESCONSTRUTOR - se eu construi duas strings eu posso desconstruir essas partes. separar objetos, semelhante a uma tupla
/*
Pessoa p1 = new Pessoa("Bruno", "Martins");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");
*/













//TUPLAS - fornece sintaze concisa para agrupar varios elementos de dados em uma estrutura de dados leve
//alternativa para quando não quer criar uma classe, e representar de forma simples os dados

/*
LeituraArquivo arquivo = new LeituraArquivo();
//var pois a tupla tem diferentes tipos de informações, assim o programa daixa cada informação no seu tipo
var (sucesso, linhasArquivos, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if(sucesso)
{
    //DESCARTE - Caso eu não queira utilizar todas as informações, no caso essa quantidadeLinhas coloco um _ na tupla
    //Console.WriteLine("Quantidade do arquivo: "+ quantidadeLinhas);
    foreach(string linha in linhasArquivos)
    {
        Console.WriteLine(linha);
    }
}
else{
    Console.WriteLine("Não foi possivel ler o arquivo");
}
*/








/*
(int, string, string, decimal) tupla = (1, "Hero", "Brine", 1.80M);

Console.WriteLine($"Id:{tupla.Item1}");
Console.WriteLine($"Nome:{tupla.Item2}");
Console.WriteLine($"Sobrenome:{tupla.Item3}");
Console.WriteLine($"Altura:{tupla.Item4}");
*/


















/*
//COLEÇÃO DE DADOS

Dictionary<string, string> estados = new Dictionary<string, string>();
//primeiro é uma chave key, depois valor value
//key deve ser unico
estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");
estados.Add("PR", "Parana");

foreach(var item in estados)
{
    Console.WriteLine($"Chave {item.Key}, Valor: {item.Value}");
}
Console.WriteLine("___________");
estados.Remove("PR");
estados["SP"] = "São Paulo - valor alterado";

foreach(var item in estados)
{
    Console.WriteLine($"Chave {item.Key}, Valor: {item.Value}");
}

//como saber se o dictioary tem o valor:
string chave = "BA";
Console.WriteLine("------------");
Console.WriteLine("verificando o elemento:");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe: {chave}");
}

//obter valor / mostrar valor
Console.WriteLine(estados["MG"]);
*/














/*
//PILHA - LIFO

Stack<int> pilha = new Stack<int>();

pilha.Push(3);
pilha.Push(6);
pilha.Push(8);
pilha.Push(11);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}
//remover elemento da pilha / sempre em ordem(ultimo a entar, primeiro a sair)
Console.WriteLine($"Removendo o elemento do topo {pilha.Pop()}");
pilha.Push(30);
foreach(int item in pilha)
{
    Console.WriteLine(item);
}
*/





//FILA - FIFO
/*
Queue<int> fila = new Queue<int>();
//colocar elemento na fila
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach(int item in fila)
{
    Console.WriteLine(item);
}
//remover elemento da fila / sempre sera em ordem(primeiro a entrar ate o ultimo)
Console.WriteLine($"Removendo o elemento {fila.Dequeue()}");
fila.Enqueue(10);

foreach(int item in fila)
{
    Console.WriteLine(item);
}
*/















/*
EXCEÇÕES E COLEÇÕES
- EXCEÇÃO / EXCEPTIONS
Os recurso de manipulação de exceção da linguagem c#ajudam voce a lidar com quaisquer situações excepcionais ou inesperadas que ocorram quando um programa for executado

situações que n estao sobre o controle do programa

*/

//USANDO O THROW
//new ExemploExcecao().Metodo1();

















/*
01-
//tenta fazer o que esta dentro dele, sabe q pode acontecer algum erro
try
{
    // fazer leitura de um arquivo txt
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
    //se passar o nome errado do arquivo por exemplo haveria uma exceção, o programa n tem saida, n sabe como proceguir e se encerra
    foreach(string linha in linhas){
        Console.WriteLine(linha);
    }
} 
//exceção especifica, arquivo não encontrado
catch(FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
}
//exceção especifica, diretorio não encontrado
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"Caminho da pasta não encontrado. {ex.Message}");
}
catch(Exception ex) //caso nao consiga fazer o que esta no try, trás a exceção na variavel e continua o programa
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}

finally
{
    Console.WriteLine("Chegou até aqui");
}
*/




























/*
//formatando dataTime
string dataString = "2024-09-00 12:00";
bool sucesso = DateTime.TryParseExact(dataString, //a propria data q quer trabalhar
                      "yyyy-MM-dd HH:00", //o formato que a data esta
                      CultureInfo.InvariantCulture, //para localização
                      DateTimeStyles.None, //para localização
                      out DateTime data);// se conseguir converter ou n, vai por nessa variavel 'data'

//validando o retorno do tryparse
// o tryparse retorna um boleano entao pode se fazer uma comparação/validação
if (sucesso)
{
    Console.WriteLine($"Conversao feita com sucesso! Data: {data}");
}
else
{
    Console.WriteLine($"{data} não é uma data válida");
}
*/



//DateTime data = DateTime.Now;

//parse - converte uma string para o datatime, e verifica se é uma data valida
//DateTime data2 = DateTime.Parse("15/06/2024 12:15");

/*
d - dia
M - mes
y - ano
H - hora em 24h
h - hora em 12h
m - minuto
s - segundo
*/

// Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));

// apenas data
// Console.WriteLine(data.ToShortDateString());
// apenas hora
// Console.WriteLine(data.ToShortTimeString());











/*
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 13382.6M;;

//:C = Currency - valor monetario do sistema, aqui esta configurado sendo BR
// para configurar para outra localização do codigo, add using System.Globalization; e o CultureInfo
// alterar a localização da cultura
// Console.WriteLine(valorMonetario.ToString("C",CultureInfo.CreateSpecificCulture("en-US")));

//personalizar formatação - C1/N1  o numero sendo as casas decimais  a serem mostradas
// N - sendo formatação numerica, sem o $
//Console.WriteLine(valorMonetario.ToString("C1"));
Console.WriteLine(valorMonetario.ToString("N2"));


//porcentagem
double porcentagem = .5421;
Console.WriteLine(porcentagem.ToString("P"));

//colocar um formato especial personalizado
//# representa o digito
int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));
*/










/*
//construtores - quando eu iniciar a classe, ja passar o valor
Pessoa p1 = new Pessoa( nome: "Bruno", sobrenome: "Martins");
Pessoa p2 = new Pessoa();
p2.Nome = "Matheus";
p2.Sobrenome = "Martins";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
*/






/*
//codigo sem construtor

Pessoa p1 = new Pessoa();
p1.Nome = "Bruno";
p1.Sobrenome = "Martins";

Pessoa p2 = new Pessoa();
p2.Nome = "Matheus";
p2.Sobrenome = "Martins";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
*/












//Pessoa p1 = new Pessoa();
//p1.Nome = "Bruno";
//p1.Sobrenome = "Martins";
//p1.Idade = 22;
//p1.Apresentar();

/*
1 PROPRIEDADES
- um membro que oferece um mecanismo flexivel para ler, gravar ou calcular o valor de um campo particular

2 MÉTODOS
- é um bloco de codigo que contem uma serie de instruçções
- seria uma ação, uma ação que aqueça classe vai fazer 
- tambem pode reaproveitar codigos

3 CONSTRUTORES
- permitem que o programagor defina valores padrao, limite a instanciação e grave códigos flexiveis e faceis de ler.
- faz uma classe e ja passa o valor q vai receber, em vez de depois passa cada valor
- deve ter o mesmo nome de sua classe
- nao tem um tipo de retorno


-----------------------------------------

###MANIPULANDO VALORES###
CONCATENAÇÃO DE STRINGS
- Podemos formatar valores em diversas representações. Essas formatações de valores é conhecida por concatenação e temos a  interpolação
- juntar textos
*/