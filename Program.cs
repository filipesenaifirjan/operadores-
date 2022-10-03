string a = "15-";

int b = 0;

int.TryParse(a, out b); //nesse caso, ele espera e tenta converter sem parar o programa e mesmo que dê erro, ele continua..
//também funciona com int.TryParse(a, out int b); declarando a variável b (tipo inteiro, nesse caso) dentro do parse

//int b = Convert.ToInt32(a);

Console.WriteLine(b);
Console.WriteLine("Conversão realizada com sucesso!");