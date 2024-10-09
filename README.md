# PACOTE / BIBLIOTECA
É um conjunto  de codigos uteis, que possibilitam o compartilhamento e reuso do codigo.

Por exemplo uma integração com o google maps
>não fará do zero, irá baixar o pacote que o google fornece, codigos prontos para fazer o reuso

### Gerenciadores de pacote
- NPM   -> javascript
- NUGET -> .net
- MAVEN -> java

### NUGET
 O gerenciador de pacote do .NET

# SERIALIZAÇÃO
é o processo de transformar objetos para um fluxo de bytes para seu armazenamento ou transmissao 

### Por exemplo
objeto tipo pessoa e quero que seja serializado no banco de dados
faço um processo p ele se tornar mais proximo do que um banco de dados reconhece como objeto

passar por uma transformação para uma forma que o meu destino aceite (traduzir)

### JSON
JS Notation Object é um formato de texto que segue a sintaxe do Javascript, muito usado para transmitir dados entre aplicações
Ele padroniza o formato, faz a troca de dados entre linguagens, comunicação 
um intermediario de como vc serializa seus dados

Ex de json:

```
{
    "Id":1,
    "Produto":"P1",
    "Preco":10.50
}
```

Ex de .NET convertendo objeto para Json:

```
//pegar pacote
using Newtonsoft.Json;

//objeto
Venda v1 = new Venda(1, "Material de escritorio", 25.00M);

//serializando / convertendo p json o objeto
string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

//criando e escrevendo um arquivo com o valor da variavel  
File.WriteAllText("Arquivos/vendas.json", serializado);
```

Ex de .NET convertendo uma coleção de objeto para Json:

```
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
```
Quando é uma coleção de objeto o JSON fica:
```
[
  {
    "Id": 1,
    "Produto": "Material de escritorio",
    "Preco": 25.00,
    "DataVenda": "2024-09-19T13:12:58.6665796-03:00"
  },
  {
    "Id": 2,
    "Produto": "Licença de Software",
    "Preco": 110.00,
    "DataVenda": "2024-09-19T13:12:58.6665796-03:00"
  }
]
``` 
Entre colchetes [ ] para demonstrar ser uma coleção

Padrão de data do JSON é ISO 8601

### JSON Viewer

para validar o Json pode usar algumas ferramentas para isso, como esse site: <a href="https://codebeautify.org/jsonviewer">Code Beautify - JSON Viewer</a>

# DESERIALIZAÇÃO

Exemplo, o JSON anterior é o que você recebeu e deve ser representado no seu sistema, nesse exemplo você não tem a classe Venda.cs original então:

Comeca mapeando o conteudo do arquivo em uma classe de seu nome < Venda >
e representa as propriedades que tem no Json para a classe (no caso n temos o construtor)
```
[
  {
    "Id": 1,
    "Nome_Produto": "Material de escritorio",
    "Preco": 25.00,
    "DataVenda": "2024-09-19T13:12:58.6665796-03:00"
  },
  {
    "Id": 2,
    "Produto": "Licença de Software",
    "Preco": 110.00,
    "DataVenda": "2024-09-19T13:12:58.6665796-03:00"
  }
]
```
#### Temos as propriedades:
> prop Id

> prop Produto

> prop Preco

> prop DataVenda

Como é uma coleção, represente a coleção tambem
```
//ler o arquivo
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

//como é uma coleção, representa-la tbm, deserializando o arquivo e transformando em objeto no formato de lista
List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// faço um foreach para demonstrar o objeto
foreach(Venda venda in listaVenda){
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Preco} - Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy hh:mm")}");
}
```
### Atributo
Na hora da deserialização
se o nome da propriedade tiver _ (o que não é uma pratica legal do c#, pois utiliza o CamelCase), ex: _Nome_Produto_ deve fazer da seguinte maneira:
```
[JsonProperty("Nome_Produto")]
public string Produto { get; set; }
```