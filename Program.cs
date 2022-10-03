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