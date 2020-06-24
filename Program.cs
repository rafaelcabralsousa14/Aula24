using System;

namespace Aula24
{
    class Program
    {
        static void Main(string[] args)
        {
             Carrinho cart = new Carrinho();
            Produto p1 = new Produto(1, "The Titan's Curse", 37.99f);
            Produto p2 = new Produto(2, "Les Miserábles", 87.90f);
            Produto p3 = new Produto(3, "A coroa de Ptolomeu", 4.99f);
            Produto p4 = new Produto(4, "A Luva de Bronze", 20.00f);

            cart.Adicionar(p1);
            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);

            cart.Remover(p4);

            Produto p5 = new Produto(1, "Extraordinário", 30.99f);
            cart.Alterar(1 , p5);

            cart.Ler();

            Console.ForegroundColor = ConsoleColor.Red;
            cart.MostrarTotal();
            Console.ResetColor();
        }
    }
}
