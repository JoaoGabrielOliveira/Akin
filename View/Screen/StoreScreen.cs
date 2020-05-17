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
    public partial class StoreScreen : UserControl
    {
        public StoreScreen()
        {
            InitializeComponent();
        }

        private void StoreScreen_Load(object sender, EventArgs e)
        {
            CreateBox("Brinco", 20.29f);
            CreateBox("Bolsa", 20.29f);
        }


        //Helper
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
            price.Text = "R$" + p;

            //Botão
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(232)))), ((int)(((byte)(207)))));
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.ForeColor = System.Drawing.Color.White;
            btn.Image = global::View.Properties.Resources.Cart;
            btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Location = new System.Drawing.Point(264, 99);
            btn.Name = "btn_cart";
            btn.Size = new System.Drawing.Size(151, 28);
            btn.TabIndex = 22;
            btn.Text = "Adicionar";
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn.UseVisualStyleBackColor = false;

            //Imagem
            image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            image.Location = new System.Drawing.Point(9, 6);
            image.Size = new System.Drawing.Size(121, 121);
            image.TabIndex = 1;
            image.TabStop = false;

            block.BorderStyle = BorderStyle.FixedSingle;
            block.Size = new Size(435, 134);
            block.Controls.Add(title);
            block.Controls.Add(price);
            block.Controls.Add(btn);
            block.Controls.Add(image);
            
            


            this.flowProducts.Controls.Add(block);
        }
    }
}
