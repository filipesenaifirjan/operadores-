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
