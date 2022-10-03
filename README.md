# tipos de operadores em c#

Operadores de atribuição

O código está com comentários para facilitar na didática, assim a gente não perde nenhum detalhe na hora que precisar ensinar 
Assim vai ficar tudo muito bem explicado, rico em detalhes.
 

Combinando Operadores:

//nesse caso, esse sinal é de atribuição, pois o sinal e igual atribui o valor para a variável

int a = 10;   
int b = 20;
int c = a + b;

c = c + 5;  //nesse caso não precisa declarar novamente o c como int, pq ja foi feito isso na linha 5
//outro detalhe, vc não pode colocar c + 5 direto, tem que ser c = c + 5 pois assim ele puxa a resposta de cima e acrescenta mais 5 conforme escrito que se trata de 30 + 5

//Pode usar c += 5; combinando dessa forma, o compilador copnsegue identificar normalmente, pois assim estamos combinando os operadores +=
//exemplos abaixo:
c -= 2;
c *= 3;

Console.WriteLine(c);           
-------------------------------------------------------------------
Convertendo tipos de variáveis:

//int a = 5;  //Ele não vai reconhecer se o valor for declarado como int e estiver entre "5", pois em "" só deve se colocar string ou 5a, 5b, nesse caso tbm deixa de ser número inteiro.
// Cast ou Casting faz a conversão
//Convert é uma classe
//Toint32 é um método que recebe uma string e transforma em int
//exemplos abaixo:

//int a = Convert.ToInt32("5");

int a = int.Parse("5"); 

//o parse converte a representação de string para 32bit de inteiro, mas se vc colocar 5c vai dar erro pq não vai conseguir ler 
//todos os tipos podem ser convertidos através do convert ou parse e esse processo chamamos de cast ou casting. Mas tem que tomar cuidado pq nem sempre vem como se espera( lembra que o usuário pode e vai te surpreender)

Console.WriteLine(a);
-------------------------------------------------------------------------
diferença entre parse e convert:

int a = Convert.ToInt32(null);//nesse caso, um dato vazio é representado através do null, pois o null converte o valor (vazio) para zero e não vai dar erro e nesse caso não pode usar o parse pq ele não vai aceitar que seja nulo.

Console.WriteLine(a);
---------------------------------------------------------------------------
Conversão para string:

//Não existe parse para string

int inteiro = 5;  //aqui tenho o valor inteiro
string a = inteiro.ToString(); //Aqui tenho o valor inteiro que foi atribuido e convertido para string


//O ToString é muito comum no c# e ele vem de uma classe mais genérica do c# chamada object (mãe de todas as classes) 
//Todo tipo pode ser representado em string e a gente usa o ToString

Console.WriteLine(a);
------------------------------------------------------------------------------------------
Cast implícito:

//int a = 5;  //aqui está acontecendo um cast implícito
//double b = a; //o double representa um número muito grande e também representa casas decimais (inteiro cabe no double)
//Não precisa fazer double b = Convert.ToDouble(a); pois isso seria redundante
//da mesma forma:

//int a = 5;
//long b = a; //long representa valores em até trilhões
//Não pode fazer o contrário, pois o int não tem os valores que o long tem, nesse caso vai precisar realizar a conversao de forma manual, ex abaixo:

//long a = 5;  //Só não pode usar espaço além do int, por exemplo, não pode usar long.MaxValue; Mas podemos usar int.MaxValue, pois o int cabe dentro do long e o long não cabe dentro do int
//int b = Convert.ToInt32(a);
//exemplo de int maxvalue dentro do long

int a = int.MaxValue;//vai imprimir sem erro o max de valor de um int (bilhões)
long b = a;

Console.WriteLine(b);
----------------------------------------------------------
Ordem dos operadores:

//double a = 4 / 2 + 2;

double a = 4 / (2 + 2);//nesse caso quero que realize a soma primeiro, acrescentando os ()
Console.WriteLine(a);

//O c# obedece as mesmas ordens da matemática, primeiro vai resolver parênteses, depois expoente, depois divisão e multiplicação e em seguida, adição e subtração

//sempre que for fazer uma operação, prestar atenção nas prioridades
-------------------------------------------------------
Convertendo de maneira segura:

string a = "15-";

int b = 0;

int.TryParse(a, out b); //nesse caso, ele espera e tenta converter sem parar o programa e mesmo que dê erro, ele continua..
//também funciona com int.TryParse(a, out int b); declarando a variável b (tipo inteiro, nesse caso) dentro do parse

//int b = Convert.ToInt32(a);

Console.WriteLine(b);
Console.WriteLine("Conversão realizada com sucesso!");

-----------------------------------------------------------
operadores condicionais na prática:

int quantidadeEmEstoque = 10; 
int quantidadeCompra = 44;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade em compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");


if(possivelVenda)  //lembrando que o if avalia somente condições, não vai funcionar se vc passar um valor inteiro
{
    Console.WriteLine("Venda realizada.");
}
else{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque!");
} 
//Aqui é muito simples, a venda será realizada se a quantidade for menor que o valor do estoque, no caso if e se a venda(pedido) for maior que o estoque, automaticamente vai exibir a msg else, ou aparece uma condição ou outra, não vai imprimir os dois
-------------------------------------------------------
if aninhado:

int quantidadeEmEstoque = 10; 
int quantidadeCompra = 2;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra; //se a quantidade de compra for maior que 0 e menor que o total de estoque a venda vai ser realizada, são duas condições

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade em compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0){
    Console.WriteLine("Venda inválida");
}

 else if(possivelVenda)  
{
    Console.WriteLine("Venda realizada.");
}
else{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque!");
} 
--------------------------------------------------------------










