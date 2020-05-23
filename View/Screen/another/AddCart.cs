﻿using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Screen.another
{
    public partial class AddCart : Form
    {
        public static Produto Product;

        public AddCart(Produto p)
        {
            InitializeComponent();
            Product = p;
        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_cart_Click_1(object sender, EventArgs e)
        {
            if (Produto.Find(Product.ID).Stock < (int)txt_qand.Value)
            {
                Controller.StoreController.AdicionarAoCarrinho(Product, (int)txt_qand.Value);
            }
        }


    }
}
