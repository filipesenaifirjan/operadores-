# operadores de atribuição
Operadores de atribuição-em-c#
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





