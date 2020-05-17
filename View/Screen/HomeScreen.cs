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
    public partial class HomeScreen : UserControl
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            lbl_text1.Text = "AKIN é uma palavra de origem africana que significa Guerreiro e Herói,"
                + "esses que sempre tinham o objetivo de defender seu povo. No contexto da nossa empresa não é diferente. A moda africana "
            + "sofre, como sempre sofreu, terríveis ataques quanto ao seu estilo diferenciado.";

            lbl_text2.Text = "Nós, da Akin Winkel, temos como principal objetivo defender os antigos valores da cultura africana,"
            + "lutando a favor do reconhecimento dessa na atual sociedade e do empoderamento pessoal,";
            ;
            lbl_text3.Text = "pois uma pessoa que tem consciência do seu poder de fala, não teme diante aos inimigos. Como já disse Shaka Zulu, 'Não preciso de guarda-costas, pois até os homens mais corajosos que se"
            + " aproximam de mim ficam fracos de joelhos' ";

            /*
            Como já disse Shaka Zulu, "Não preciso de guarda-costas, pois até os homens mais corajosos que se
            aproximam
            de mim ficam fracos de joelhos"*/
        }
    }
}
