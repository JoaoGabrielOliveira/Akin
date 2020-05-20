using Model;
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
        public AddCart()
        {
            InitializeComponent();
        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_cart_Click_1(object sender, EventArgs e)
        {
            AdicionarAoCarrinho(new Produto(), (int)txt_qand.Value);
        }

        private void AdicionarAoCarrinho(Produto produto, int unit)
        {
            Controller.CartControlller.CartProducts.Add(produto, unit);
        }
    }
}
