namespace View.Screen
{
    partial class CartScreen
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
            this.panel_footer = new System.Windows.Forms.Panel();
            this.lbl_total_price = new System.Windows.Forms.Label();
            this.btn_finalize = new System.Windows.Forms.Button();
            this.lbl_info_finalize = new System.Windows.Forms.Label();
            this.flowCartProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_block = new System.Windows.Forms.Panel();
            this.panel_prod = new System.Windows.Forms.Panel();
            this.lbl_info_prod = new System.Windows.Forms.Label();
            this.pic_prod = new System.Windows.Forms.PictureBox();
            this.lbl_price_prod = new System.Windows.Forms.Label();
            this.lbl_name_prod = new System.Windows.Forms.Label();
            this.panel_buy = new System.Windows.Forms.Panel();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lbl_price_buy = new System.Windows.Forms.Label();
            this.lbl_info_compra = new System.Windows.Forms.Label();
            this.lbl_unit_buy = new System.Windows.Forms.Label();
            this.panel_footer.SuspendLayout();
            this.flowCartProducts.SuspendLayout();
            this.panel_block.SuspendLayout();
            this.panel_prod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prod)).BeginInit();
            this.panel_buy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel_footer.Controls.Add(this.lbl_total_price);
            this.panel_footer.Controls.Add(this.btn_finalize);
            this.panel_footer.Controls.Add(this.lbl_info_finalize);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 435);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(675, 64);
            this.panel_footer.TabIndex = 25;
            // 
            // lbl_total_price
            // 
            this.lbl_total_price.AutoSize = true;
            this.lbl_total_price.Font = new System.Drawing.Font("Roboto Cn", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_price.ForeColor = System.Drawing.Color.White;
            this.lbl_total_price.Location = new System.Drawing.Point(299, 22);
            this.lbl_total_price.Name = "lbl_total_price";
            this.lbl_total_price.Size = new System.Drawing.Size(99, 25);
            this.lbl_total_price.TabIndex = 31;
            this.lbl_total_price.Text = "R$ 120,99";
            this.lbl_total_price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_finalize
            // 
            this.btn_finalize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(235)))), ((int)(((byte)(99)))));
            this.btn_finalize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_finalize.FlatAppearance.BorderSize = 0;
            this.btn_finalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalize.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalize.ForeColor = System.Drawing.Color.White;
            this.btn_finalize.Image = global::View.Properties.Resources.Cart;
            this.btn_finalize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_finalize.Location = new System.Drawing.Point(491, 14);
            this.btn_finalize.Name = "btn_finalize";
            this.btn_finalize.Size = new System.Drawing.Size(174, 37);
            this.btn_finalize.TabIndex = 29;
            this.btn_finalize.Text = "Finalizar compra";
            this.btn_finalize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_finalize.UseVisualStyleBackColor = false;
            // 
            // lbl_info_finalize
            // 
            this.lbl_info_finalize.AutoSize = true;
            this.lbl_info_finalize.BackColor = System.Drawing.Color.Transparent;
            this.lbl_info_finalize.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_finalize.ForeColor = System.Drawing.Color.White;
            this.lbl_info_finalize.Location = new System.Drawing.Point(20, 17);
            this.lbl_info_finalize.Name = "lbl_info_finalize";
            this.lbl_info_finalize.Size = new System.Drawing.Size(285, 31);
            this.lbl_info_finalize.TabIndex = 22;
            this.lbl_info_finalize.Text = "Valor total da compra:";
            // 
            // flowCartProducts
            // 
            this.flowCartProducts.AutoScroll = true;
            this.flowCartProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.flowCartProducts.Controls.Add(this.panel_block);
            this.flowCartProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCartProducts.Location = new System.Drawing.Point(0, 0);
            this.flowCartProducts.Name = "flowCartProducts";
            this.flowCartProducts.Size = new System.Drawing.Size(675, 435);
            this.flowCartProducts.TabIndex = 27;
            // 
            // panel_block
            // 
            this.panel_block.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.panel_block.Controls.Add(this.panel_prod);
            this.panel_block.Controls.Add(this.panel_buy);
            this.panel_block.Location = new System.Drawing.Point(7, 7);
            this.panel_block.Margin = new System.Windows.Forms.Padding(7);
            this.panel_block.Name = "panel_block";
            this.panel_block.Size = new System.Drawing.Size(643, 117);
            this.panel_block.TabIndex = 31;
            this.panel_block.Visible = false;
            // 
            // panel_prod
            // 
            this.panel_prod.BackColor = System.Drawing.Color.Snow;
            this.panel_prod.Controls.Add(this.lbl_info_prod);
            this.panel_prod.Controls.Add(this.pic_prod);
            this.panel_prod.Controls.Add(this.lbl_price_prod);
            this.panel_prod.Controls.Add(this.lbl_name_prod);
            this.panel_prod.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_prod.Location = new System.Drawing.Point(0, 0);
            this.panel_prod.Name = "panel_prod";
            this.panel_prod.Size = new System.Drawing.Size(324, 117);
            this.panel_prod.TabIndex = 1;
            // 
            // lbl_info_prod
            // 
            this.lbl_info_prod.AutoSize = true;
            this.lbl_info_prod.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_prod.Location = new System.Drawing.Point(121, 3);
            this.lbl_info_prod.Name = "lbl_info_prod";
            this.lbl_info_prod.Size = new System.Drawing.Size(162, 22);
            this.lbl_info_prod.TabIndex = 32;
            this.lbl_info_prod.Text = "Dados do Produto";
            // 
            // pic_prod
            // 
            this.pic_prod.Image = global::View.Properties.Resources.blank_profile;
            this.pic_prod.Location = new System.Drawing.Point(0, 0);
            this.pic_prod.Name = "pic_prod";
            this.pic_prod.Size = new System.Drawing.Size(117, 117);
            this.pic_prod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_prod.TabIndex = 1;
            this.pic_prod.TabStop = false;
            // 
            // lbl_price_prod
            // 
            this.lbl_price_prod.AutoSize = true;
            this.lbl_price_prod.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price_prod.Location = new System.Drawing.Point(124, 82);
            this.lbl_price_prod.Name = "lbl_price_prod";
            this.lbl_price_prod.Size = new System.Drawing.Size(138, 18);
            this.lbl_price_prod.TabIndex = 30;
            this.lbl_price_prod.Text = "Valor unitário: $ 12.00";
            // 
            // lbl_name_prod
            // 
            this.lbl_name_prod.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name_prod.Location = new System.Drawing.Point(121, 31);
            this.lbl_name_prod.Name = "lbl_name_prod";
            this.lbl_name_prod.Size = new System.Drawing.Size(198, 42);
            this.lbl_name_prod.TabIndex = 31;
            this.lbl_name_prod.Text = "Anel de Urubata PRATA";
            this.lbl_name_prod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_buy
            // 
            this.panel_buy.BackColor = System.Drawing.Color.Snow;
            this.panel_buy.Controls.Add(this.btn_remove);
            this.panel_buy.Controls.Add(this.lbl_price_buy);
            this.panel_buy.Controls.Add(this.lbl_info_compra);
            this.panel_buy.Controls.Add(this.lbl_unit_buy);
            this.panel_buy.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_buy.Location = new System.Drawing.Point(326, 0);
            this.panel_buy.Name = "panel_buy";
            this.panel_buy.Size = new System.Drawing.Size(317, 117);
            this.panel_buy.TabIndex = 0;
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.Brown;
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Image = global::View.Properties.Resources.cart_remove;
            this.btn_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remove.Location = new System.Drawing.Point(187, -2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(129, 38);
            this.btn_remove.TabIndex = 35;
            this.btn_remove.Text = "Remover item";
            this.btn_remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lbl_price_buy
            // 
            this.lbl_price_buy.AutoSize = true;
            this.lbl_price_buy.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price_buy.Location = new System.Drawing.Point(13, 82);
            this.lbl_price_buy.Name = "lbl_price_buy";
            this.lbl_price_buy.Size = new System.Drawing.Size(113, 18);
            this.lbl_price_buy.TabIndex = 33;
            this.lbl_price_buy.Text = "SubTotal: $ 12.00";
            // 
            // lbl_info_compra
            // 
            this.lbl_info_compra.AutoSize = true;
            this.lbl_info_compra.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_compra.Location = new System.Drawing.Point(3, 3);
            this.lbl_info_compra.Name = "lbl_info_compra";
            this.lbl_info_compra.Size = new System.Drawing.Size(157, 22);
            this.lbl_info_compra.TabIndex = 33;
            this.lbl_info_compra.Text = "Dados de Compra";
            // 
            // lbl_unit_buy
            // 
            this.lbl_unit_buy.AutoSize = true;
            this.lbl_unit_buy.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unit_buy.Location = new System.Drawing.Point(12, 43);
            this.lbl_unit_buy.Name = "lbl_unit_buy";
            this.lbl_unit_buy.Size = new System.Drawing.Size(105, 19);
            this.lbl_unit_buy.TabIndex = 34;
            this.lbl_unit_buy.Text = "Total unitário: 5";
            // 
            // CartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.flowCartProducts);
            this.Controls.Add(this.panel_footer);
            this.Name = "CartScreen";
            this.Size = new System.Drawing.Size(675, 499);
            this.Load += new System.EventHandler(this.CartScreen_Load);
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.flowCartProducts.ResumeLayout(false);
            this.panel_block.ResumeLayout(false);
            this.panel_prod.ResumeLayout(false);
            this.panel_prod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_prod)).EndInit();
            this.panel_buy.ResumeLayout(false);
            this.panel_buy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.Label lbl_info_finalize;
        private System.Windows.Forms.Label lbl_total_price;
        private System.Windows.Forms.Button btn_finalize;
        private System.Windows.Forms.FlowLayoutPanel flowCartProducts;
        private System.Windows.Forms.Panel panel_block;
        private System.Windows.Forms.Panel panel_prod;
        private System.Windows.Forms.Label lbl_info_prod;
        private System.Windows.Forms.PictureBox pic_prod;
        private System.Windows.Forms.Label lbl_price_prod;
        private System.Windows.Forms.Label lbl_name_prod;
        private System.Windows.Forms.Panel panel_buy;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lbl_price_buy;
        private System.Windows.Forms.Label lbl_info_compra;
        private System.Windows.Forms.Label lbl_unit_buy;
    }
}
