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
    public partial class CartScreen : UserControl
    {
        public CartScreen()
        {
            InitializeComponent();
        }

        private void CartScreen_Load(object sender, EventArgs e)
        {

        }

        private void CreateBox(string n = "Desconhecido", float p = 00.00f)
        {
            Panel block = new Panel();
            Label title = new Label();
            Label price = new Label();
            Button btn = new Button();
            PictureBox image = new PictureBox();

            //Nome
            title.AutoSize = true;
            title.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title.ForeColor = System.Drawing.Color.Black;
            title.Location = new System.Drawing.Point(147, 4);
            title.Size = new System.Drawing.Size(102, 41);
            title.TabIndex = 21;
            title.Text = n;

            //Price
            price.AutoSize = true;
            price.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            price.Location = new System.Drawing.Point(160, 48);
            price.Size = new System.Drawing.Size(62, 29);
            price.TabIndex = 22;
            price.Text = "R$ " + p;

            //Botão
            btn.BackColor = System.Drawing.Color.Snow;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.ForeColor = System.Drawing.Color.Black;
            btn.Image = global::View.Properties.Resources.cart_add;
            btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Location = new System.Drawing.Point(320, 75);
            btn.Name = "btn_cart";
            btn.Size = new System.Drawing.Size(200, 50);
            btn.TabIndex = 22;
            btn.Text = "Adicionar ao Carrinho";
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn.UseVisualStyleBackColor = false;

            //Imagem
            //image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            image.Location = new System.Drawing.Point(10, 5);
            image.Size = new System.Drawing.Size(121, 121);
            image.TabIndex = 1;
            image.TabStop = false;

            block.BorderStyle = BorderStyle.FixedSingle;
            block.Size = new Size(535, 134);
            block.BackColor = Color.FromArgb(45, 47, 51);
            block.Controls.Add(title);
            block.Controls.Add(price);
            block.Controls.Add(btn);
            block.Controls.Add(image);




            this.flowProducts.Controls.Add(block);
        }
    }
}
