using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Screen
{
    public partial class ProfileScreen : UserControl
    {
        public ProfileScreen()
        {
            InitializeComponent();
        }


        //HELPERS

        private void ProfileInfo()
        {
            lbl_user_name.Text = Controller.LoginController.user.Name;
            lbl_user_email.Text = Controller.LoginController.user.Email;

            string type = "Padrão";
            if (Controller.LoginController.user.TypeUser == 'a') type = "Administrador";
            lbl_user_type.Text = type;
        }

        private void ProfileScreen_Load(object sender, EventArgs e)
        {
            ProfileInfo();
        }
    }
}
