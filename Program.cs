

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
