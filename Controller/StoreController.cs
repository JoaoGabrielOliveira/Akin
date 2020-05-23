using Model;
using System;
using System.Collections.Generic;

namespace Controller
{
    public static class StoreController
    {
        public static List<Produto> ListProducts = Model.Produto.All();

        public static void AdicionarAoCarrinho(Produto produto, int quantidade)
        {
            Controller.CartControlller.CartProducts.Add(produto, quantidade);
        }


    }
}