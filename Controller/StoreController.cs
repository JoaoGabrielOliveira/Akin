using System;
using System.Collections.Generic;
using System.Data;
using Model;

namespace Controller
{
    public static class StoreController
    {
        public static DataTable ListProducts = new DataTable();
        public static List<Produto> cartProduct;

        public static void Popular()
        {
            foreach (var produto in Model.Produto.All())
            {
                ListProducts.Rows.Add(produto.ID, produto.Name);
            }
        }
    }
}
