# operadores de atribuição
Operadores de atribuição-em-c#
O código está com comentários para facilitar na didática, assim a gente não perde nenhum detalhe na hora que precisar ensinar 
 

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

