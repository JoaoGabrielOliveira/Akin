using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class frmPagamento : Form
    {
        public frmPagamento()
        {
            InitializeComponent();
        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "MM/yyyy";

            txt_name.Text = Controller.LoginController.user.Name;
            txt_email.Text = Controller.LoginController.user.Email;

            lbl_placeholder_name = Placeholder(txt_name, lbl_placeholder_name);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmbBuyForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBuyForm.SelectedIndex)
            {
                case 0:
                    panel_infopag_cart.Visible = true;
                    btn_gen_boleto.Visible = false;
                break;

                case 1:
                    panel_infopag_cart.Visible = true;
                    btn_gen_boleto.Visible = false;
                break;

                case 2:
                    panel_infopag_cart.Visible = false;
                    btn_gen_boleto.Visible = true;
                break;
            }
        }

        #region
        private void txt_ncartao_Enter(object sender, EventArgs e)
        {
            lbl_placeholder_ncartao.Visible = false;
        }

        private void txt_ncartao_Leave(object sender, EventArgs e)
        {
            lbl_placeholder_ncartao = Placeholder(this.txt_ncartao, this.lbl_placeholder_ncartao);
        }

        private void panel_txt_ncartao_Click(object sender, EventArgs e)
        {
            txt_ncartao.Focus();
        }
        #endregion

        #region
        private void panel_txt_name_Click(object sender, EventArgs e)
        {
            txt_name.Focus();
        }

        private void txt_name_Enter(object sender, EventArgs e)
        {
            lbl_placeholder_name.Visible = false;
        }

        private void txt_name_Leave(object sender, EventArgs e)
        {
            lbl_placeholder_name = Placeholder(txt_name, lbl_placeholder_name);
        }
        #endregion

        #region
        private void panel_txt_email_Click(object sender, EventArgs e)
        {
            txt_email.Focus();
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            lbl_placeholder_email.Visible = false;
        }

        private void txt_email_Leave(object sender, EventArgs e)
        {
            lbl_placeholder_email = Placeholder(this.txt_email, this.lbl_placeholder_email);
        }
        #endregion

        #region
        private void panel_txt_cpf_Click(object sender, EventArgs e)
        {
            txt_cpf.Focus();
        }

        private void txt_cpf_Enter(object sender, EventArgs e)
        {
            this.lbl_placeholder_ncpf.Visible = false;
        }

        private void txt_cpf_Leave(object sender, EventArgs e)
        {
            this.lbl_placeholder_ncpf = Placeholder(this.txt_cpf, this.lbl_placeholder_ncpf);
        }
        #endregion

        #region
        private void panel_txt_cvc_Click(object sender, EventArgs e)
        {
            txt_cvc.Focus();
        }

        private void txt_cvc_Enter(object sender, EventArgs e)
        {
            lbl_placeholder_cvc.Visible = false;
        }

        private void txt_cvc_Leave(object sender, EventArgs e)
        {
            lbl_placeholder_cvc = Placeholder(txt_cvc, lbl_placeholder_cvc);
        }
        #endregion



        private Label Placeholder(TextBox txtBox, Label lblPlace)
        {
            if (txtBox.Text.Equals(string.Empty))
            {
                 lblPlace.Visible = true;
            }

            return lblPlace;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            new frmPrincipal().Show();
            this.Hide();
        }
    }
}
