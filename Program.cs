bool eMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;
if (eMaiorDeIdade || possuiAutorizacaoDoResponsavel){
    Console.WriteLine("entrada liberada");
}
//nesse caso, um ou outro sendo verdadeiro, ele já executa o código
// ele só não vai executar se nenhuma das condições forem verdadeiras

else{
    Console.WriteLine("entrada não liberada");
}