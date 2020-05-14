using System;
using System.Drawing;
using System.Windows.Forms;
using Controller;

namespace View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void Alteracao(object sender, EventArgs e)
        {
            if (txt_email.Text == "")
            {
                lbl_textemail.Visible = true;
            }

            else
            {
                lbl_textemail.Visible = false;
            }
            
        }

        private void AlteracaoSenha(object sender, EventArgs e)
        {
            if (txt_senha.Text == "")
            {
                lbl_textsenha.Visible = true;
            }           
                        
            else        
            {           
                lbl_textsenha.Visible = false;
            }
        }

        private void AlteracaoNome(object sender, EventArgs e)
        {
            if (txt_nome.Text == "")
            {
                lbl_textnome.Visible = true;
            }

            else
            {
                lbl_textnome.Visible = false;
            }
        }

        private void ClickEmailText(object sender, EventArgs e)
        {
            lbl_textemail.Visible = false;
            txt_email.Focus();
        }

        private void ClickSenhaText(object sender, EventArgs e)
        {
            lbl_textsenha.Visible = false;
            txt_senha.Focus();
        }

        private void ClickNomeText(object sender, EventArgs e)
        {
            lbl_textnome.Visible = false;
            txt_nome.Focus();
        }



        private void btn_logar_Click(object sender, EventArgs e)
        {
            Login.user.Name = txt_nome.Text;
            Login.user.Email = txt_email.Text;
            Login.user.Password = txt_senha.Text;

            string condicao = Login.user.Login();
            MessageBox.Show(condicao);
            Respostas(condicao);

        }

        private void btn_logar_Click_Cadastro(object sender, EventArgs e)
        {
            Login.user.Name = txt_nome.Text;
            Login.user.Email = txt_email.Text;
            Login.user.Password = txt_senha.Text;

            string condicao = Login.user.Cadastrar();
            MessageBox.Show(condicao);
            Respostas(condicao);
        }

        private void CriarConta(object sender, EventArgs e)
        {
            panel_nome.Visible = true;
            btn_logar.Text = "Cadastrar";
            this.btn_logar.Click -= new System.EventHandler(this.btn_logar_Click);
            this.btn_logar.Click += new System.EventHandler(this.btn_logar_Click_Cadastro);
        }

        private void CriarContaHover(object sender, EventArgs e)
        {
            lbl_criarCadastro.ForeColor = Color.FromArgb(77, 145, 53);
        }

        private void CriarContaLeave(object sender, EventArgs e)
        {
            lbl_criarCadastro.ForeColor = Color.FromArgb(118, 194, 91);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Respostas(string condicao)
        {
            if (condicao == "100")
            {
                MessageBox.Show("Bem-Vindo ao Akin Winkel!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new frmPrincipal().Show();
                this.Hide();
            }

            else if (condicao == "101")
            {
                MessageBox.Show("Bem-Vindo " + txt_email.Text, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new frmPrincipal().Show();
                this.Hide();
            }

            else if (condicao == "010")
            {
                MessageBox.Show("Email não cadastrado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else if (condicao == "000")
            {
                MessageBox.Show("Ocorreu um erro inesperado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MessageBox.Show("E-mail ou senha não cadastrados ou incorretos!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
