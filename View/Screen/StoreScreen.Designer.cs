namespace View.Screen
{
    partial class StoreScreen
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.pic_image = new System.Windows.Forms.PictureBox();
            this.btn_cart = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.template = new System.Windows.Forms.Panel();
            this.flowProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).BeginInit();
            this.template.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowProducts
            // 
            this.flowProducts.AutoScroll = true;
            this.flowProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.flowProducts.Controls.Add(this.template);
            this.flowProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowProducts.Location = new System.Drawing.Point(0, 0);
            this.flowProducts.Name = "flowProducts";
            this.flowProducts.Size = new System.Drawing.Size(675, 499);
            this.flowProducts.TabIndex = 26;
            // 
            // pic_image
            // 
            this.pic_image.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_image.Image = global::View.Properties.Resources.blank_profile;
            this.pic_image.Location = new System.Drawing.Point(0, 0);
            this.pic_image.Name = "pic_image";
            this.pic_image.Size = new System.Drawing.Size(142, 136);
            this.pic_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_image.TabIndex = 0;
            this.pic_image.TabStop = false;
            // 
            // btn_cart
            // 
            this.btn_cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(232)))), ((int)(((byte)(207)))));
            this.btn_cart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_cart.FlatAppearance.BorderSize = 0;
            this.btn_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cart.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cart.ForeColor = System.Drawing.Color.White;
            this.btn_cart.Image = global::View.Properties.Resources.Cart;
            this.btn_cart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cart.Location = new System.Drawing.Point(0, 218);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.Size = new System.Drawing.Size(142, 37);
            this.btn_cart.TabIndex = 7;
            this.btn_cart.Text = "Adicionar";
            this.btn_cart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cart.UseVisualStyleBackColor = false;
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(4, 137);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(135, 42);
            this.lbl_title.TabIndex = 29;
            this.lbl_title.Text = "Anel de Urubata PRATA";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(76, 186);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(55, 18);
            this.lbl_price.TabIndex = 28;
            this.lbl_price.Text = "$ 12.00";
            // 
            // template
            // 
            this.template.BackColor = System.Drawing.Color.Snow;
            this.template.Controls.Add(this.lbl_price);
            this.template.Controls.Add(this.lbl_title);
            this.template.Controls.Add(this.btn_cart);
            this.template.Controls.Add(this.pic_image);
            this.template.Location = new System.Drawing.Point(10, 10);
            this.template.Margin = new System.Windows.Forms.Padding(10);
            this.template.Name = "template";
            this.template.Size = new System.Drawing.Size(142, 255);
            this.template.TabIndex = 27;
            this.template.Visible = false;
            // 
            // StoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.flowProducts);
            this.Name = "StoreScreen";
            this.Size = new System.Drawing.Size(675, 499);
            this.Load += new System.EventHandler(this.StoreScreen_Load);
            this.flowProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_image)).EndInit();
            this.template.ResumeLayout(false);
            this.template.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowProducts;
        private System.Windows.Forms.Panel template;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_cart;
        private System.Windows.Forms.PictureBox pic_image;
    }
}
