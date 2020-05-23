using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Controller;
using View.Screen.another;
using Model;

namespace View.Screen
{
    public partial class StoreScreen : UserControl
    {
        public StoreScreen()
        {
            InitializeComponent();
            //MessageBox.Show(StoreController.ListProducts[0].Name);
        }

        private void StoreScreen_Load(object sender, EventArgs e)
        {           
            foreach (var product in  StoreController.ListProducts)
            {
                if (Produto.Find(product.ID).ID > 0)
                {
                    CreateBox(product.Name, product.Price, product.ID);
                }
                
            }
        }


        //Helper
        private void CreateBox(string n = "Desconhecido", double p = 00.00f, int id = -1)
        {
            Panel block = new Panel();
            Label title = new Label();
            Label price = new Label();
            Button btn = new Button();
            PictureBox image = new PictureBox();
            //string pathImage = System.Windows.Forms.Application.StartupPath + @"Produtos\Img\" + id + ".png";
            string pathImage = @"E:\Projetos Programação\Akin\View\bin\Debug\Produtos\Img\2.png";

            //Nome
            title.AutoSize = false;
            title.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title.Location = new System.Drawing.Point(4, 142);
            title.Name = "lbl_title";
            title.Size = new System.Drawing.Size(135, 42);
            title.TabIndex = 29;
            title.Text = n;

            //Price
            price.AutoSize = true;
            price.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            price.Location = new System.Drawing.Point(76, 186);
            price.Name = "lbl_price";
            price.Size = new System.Drawing.Size(135, 42);
            price.TabIndex = 28;
            price.Text = p.ToString("c");

            //Botão
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(232)))), ((int)(((byte)(207)))));
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.ForeColor = System.Drawing.Color.White;
            btn.Image = global::View.Properties.Resources.Cart;
            btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Location = new System.Drawing.Point(0, 200);
            btn.Name = "id_" + id;
            btn.Click += Btn_Click;
            btn.Size = new System.Drawing.Size(142, 37);
            btn.TabIndex = 7;
            btn.Text = "Comprar";
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn.UseVisualStyleBackColor = false;

            //Imagem
            image.Dock = System.Windows.Forms.DockStyle.Top;
            if (System.IO.File.Exists(pathImage)) { image.Image = Image.FromFile(pathImage); }
            else { image.Image =  global::View.Properties.Resources.blank_product; }
            image.Location = new System.Drawing.Point(0, 0);
            image.Size = new System.Drawing.Size(142, 136);
            block.BackColor = Color.FromArgb(45, 47, 51);
            image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            block.Margin = new System.Windows.Forms.Padding(10);
            image.TabIndex = 0;block.Size = new System.Drawing.Size(142, 237);
            image.TabStop = false;block.TabIndex = 27;

            block.BackColor = System.Drawing.Color.Snow;
            block.Location = new System.Drawing.Point(10, 10);
            block.Margin = new System.Windows.Forms.Padding(10);
            block.Name = "block_" + id;
            block.Size = new System.Drawing.Size(142, 255);
            block.TabIndex = 27;

            block.Controls.Add(price);
            block.Controls.Add(title);
            block.Controls.Add(btn);
            block.Controls.Add(image);
            


            this.flowProducts.Controls.Add(block);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = int.Parse(btn.Name.Split('_')[1]);

            AddCart cart = new AddCart( Produto.Find(id) );
            cart.Show();
        }
    }
}
