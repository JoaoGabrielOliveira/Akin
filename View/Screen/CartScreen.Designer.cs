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
            this.panel_footer.SuspendLayout();
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
            this.flowCartProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCartProducts.Location = new System.Drawing.Point(0, 0);
            this.flowCartProducts.Name = "flowCartProducts";
            this.flowCartProducts.Size = new System.Drawing.Size(675, 435);
            this.flowCartProducts.TabIndex = 27;
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
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.Label lbl_info_finalize;
        private System.Windows.Forms.Label lbl_total_price;
        private System.Windows.Forms.Button btn_finalize;
        private System.Windows.Forms.FlowLayoutPanel flowCartProducts;
    }
}
