using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Screen;

namespace View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            AbrirTela();
        }

        public static int screenIndex = 1;
        public static int cartItens = 0;

        private void homeScreen1_Load(object sender, EventArgs e)
        {

        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Normalizar();
            btn_profile.BackColor = Color.FromArgb(20, 105, 93);
            screenIndex = 4;
            AbrirTela();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Normalizar();
            lbl_title.Text = "Akin Winkel";
            btn_home.BackColor = Color.FromArgb(20, 105, 93);
            lbl_index.Top = btn_home.Location.Y + 12;
            screenIndex = 1;
            AbrirTela();
        }


        private void btn_store_Click(object sender, EventArgs e)
        {
            Normalizar();
            lbl_title.Text = "Loja";
            btn_store.BackColor = Color.FromArgb(20, 105, 93);
            lbl_index.Top = btn_store.Location.Y + 12;
            screenIndex = 2;
            AbrirTela();
        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            Normalizar();
            lbl_title.Text = "Carrinho";
            btn_cart.BackColor = Color.FromArgb(20, 105, 93);
            lbl_index.Top = btn_cart.Location.Y + 12;
            screenIndex = 3;

            AbrirTela();

            lbl_not_number.Visible = false;

            cartItens = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        //HELPERS
        private void Normalizar()
        {
            btn_home.BackColor = Color.FromArgb(44, 232, 207);
            btn_cart.BackColor = Color.FromArgb(44, 232, 207);
            btn_store.BackColor = Color.FromArgb(44, 232, 207);
            btn_profile.BackColor = Color.FromArgb(44, 232, 207);
        }

        private void AbrirTela()
        {
            switch (screenIndex)
            {
                //HomeScreen
                case 1:
                    homeScreen.Visible = true;
                    storeScreen.Visible = false;
                    cartScreen.Visible = false;
                    profileScreen.Visible = false;

                    break;

                //StoreScreen
                case 2:
                    homeScreen.Visible = false;
                    storeScreen.Visible = true;
                    cartScreen.Visible = false;
                    profileScreen.Visible = false;
                    break;

                //CartScreen
                case 3:
                    homeScreen.Visible = false;
                    storeScreen.Visible = false;
                    cartScreen.Visible = true;
                    profileScreen.Visible = false;
                break;

                //ProfileScreen
                case 4:
                    homeScreen.Visible = false;
                    storeScreen.Visible = false;
                    cartScreen.Visible = false;
                    profileScreen.Visible = true;
                break;
            }
        }

        public void Notificador()
        {
            cartItens++;
            lbl_not_number.Text = cartItens.ToString() + '+';
            lbl_not_number.Visible = true;

        }
    }
}
