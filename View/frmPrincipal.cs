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
        }

        private void homeScreen1_Load(object sender, EventArgs e)
        {

        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            Normalizar();
            btn_profile.BackColor = Color.FromArgb(20, 105, 93);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Normalizar();
            btn_home.BackColor = Color.FromArgb(20, 105, 93);
            lbl_index.Top = btn_home.Location.Y + 12;
        }


        private void btn_store_Click(object sender, EventArgs e)
        {
            Normalizar();
            btn_store.BackColor = Color.FromArgb(20, 105, 93);
            lbl_index.Top = btn_store.Location.Y + 12;

        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            Normalizar();
            btn_cart.BackColor = Color.FromArgb(20, 105, 93);
            lbl_index.Top = btn_cart.Location.Y + 12;
        }



        //HELPERS
        private void Normalizar()
        {
            btn_home.BackColor = Color.FromArgb(44, 232, 207);
            btn_cart.BackColor = Color.FromArgb(44, 232, 207);
            btn_store.BackColor = Color.FromArgb(44, 232, 207);
            btn_profile.BackColor = Color.FromArgb(44, 232, 207);
        }


    }
}
