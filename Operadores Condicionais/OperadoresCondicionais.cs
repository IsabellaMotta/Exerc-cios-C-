﻿//Operadores condicionais na prática.
//Possivel venda com condicional de variável booleana.x


int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

if (possivelVenda)
{
Console.WriteLine("Venda realizada!");
}
else
{
Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}