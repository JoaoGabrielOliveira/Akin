using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

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
            foreach (KeyValuePair<Produto, int> key in Controller.CartControlller.CartProducts)
            {
                var produto = key.Key;
                var unidade = key.Value;

                CreateBox(produto.Name, produto.Price, unidade, produto.ID);
            }
        }

        private void CreateBox(string n = "Desconhecido", double p = 00.00f, int u = 0, int id = 0)
        {
            Panel block = new Panel();

            PictureBox image = new PictureBox();

            Panel panelprod = new Panel();
            Label info_prod = new Label();
            Label prod_name = new Label();
            Label price_unit = new Label();

            Panel panelbuy = new Panel();
            Label info_compra = new Label();
            Label unit_total = new Label();
            Label price_subtotal = new Label();
            Button btn = new Button();

            //Block
            block.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            block.Location = new System.Drawing.Point(7, 7);
            block.Margin = new System.Windows.Forms.Padding(7);
            block.Size = new System.Drawing.Size(643, 117);
            block.TabIndex = 31;

            //Imagem
            image.Image = global::View.Properties.Resources.blank_profile;
            image.Location = new System.Drawing.Point(0, 0);
            image.Name = "pic_prod";
            image.Size = new System.Drawing.Size(117, 117);
            image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            image.TabIndex = 1;
            image.TabStop = false;

            //Panel Produto
            panelprod.BackColor = System.Drawing.Color.Snow;
            panelprod.Dock = System.Windows.Forms.DockStyle.Left;
            panelprod.Location = new System.Drawing.Point(0, 0);
            panelprod.Size = new System.Drawing.Size(324, 117);
            panelprod.TabIndex = 1;
            //Informações do Produto
            info_prod.AutoSize = true;
            info_prod.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            info_prod.Location = new System.Drawing.Point(121, 3);
            info_prod.Size = new System.Drawing.Size(162, 22);
            info_prod.TabIndex = 32;
            info_prod.Text = "Dados do Produto";
            //Informação de Nome do Produto 
            prod_name.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prod_name.Location = new System.Drawing.Point(121, 31);
            prod_name.Size = new System.Drawing.Size(198, 42);
            prod_name.TabIndex = 31;
            prod_name.Text = n;
            prod_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //Informação de Preço do Produto
            price_unit.AutoSize = true;
            price_unit.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            price_unit.Location = new System.Drawing.Point(124, 82);
            price_unit.Size = new System.Drawing.Size(138, 18);
            price_unit.TabIndex = 30;
            price_unit.Text = "Valor unitário: " + p.ToString("c") ;

            panelprod.Controls.Add(info_prod);
            panelprod.Controls.Add(prod_name);
            panelprod.Controls.Add(price_unit);
            panelprod.Controls.Add(image);


            //Panel de Compra
            panelbuy.BackColor = System.Drawing.Color.Snow;
            panelbuy.Dock = System.Windows.Forms.DockStyle.Right;
            panelbuy.Location = new System.Drawing.Point(326, 0);
            panelbuy.Size = new System.Drawing.Size(317, 117);
            panelbuy.TabIndex = 0;
            //Informações de Compra
            info_compra.AutoSize = true;
            info_compra.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            info_compra.Location = new System.Drawing.Point(3, 3);
            info_compra.Size = new System.Drawing.Size(157, 22);
            info_compra.TabIndex = 33;
            info_compra.Text = "Dados de Compra";
            //Informações de Compra do Total de Unidades
            unit_total.AutoSize = true;
            unit_total.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unit_total.Location = new System.Drawing.Point(12, 43);
            unit_total.Size = new System.Drawing.Size(105, 19);
            unit_total.TabIndex = 34;
            unit_total.Text = "Total unitário: " + u + "x";
            //Informações de Compra de SubTotal
            price_subtotal.AutoSize = true;
            price_subtotal.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            price_subtotal.Location = new System.Drawing.Point(13, 82);
            price_subtotal.Size = new System.Drawing.Size(113, 18);
            price_subtotal.TabIndex = 33;
            price_subtotal.Text = "SubTotal: " + (p * u).ToString("c");
            //Informações de Compra Botão de Remover Item
            btn.BackColor = System.Drawing.Color.Brown;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btn.ForeColor = System.Drawing.Color.White;
            btn.Image = global::View.Properties.Resources.cart_remove;
            btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Location = new System.Drawing.Point(187, -2);
            btn.Name = "btn_" + id;
            btn.Size = new System.Drawing.Size(129, 38);
            btn.TabIndex = 35;
            btn.Text = "Remover item";
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn.UseVisualStyleBackColor = false;
            btn.Click += new System.EventHandler(this.btn_remove_Click);

            panelbuy.Controls.Add(info_compra);
            panelbuy.Controls.Add(unit_total);
            panelbuy.Controls.Add(price_subtotal);
            panelbuy.Controls.Add(btn);


            block.Controls.Add(panelprod);
            block.Controls.Add(panelbuy);
            
            this.flowCartProducts.Controls.Add(block);
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string id = (btn.Name.Split('_'))[1];
            MessageBox.Show(id);
            
        }
    }
}
