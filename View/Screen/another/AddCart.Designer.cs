namespace View.Screen.another
{
    partial class AddCart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_qand = new System.Windows.Forms.NumericUpDown();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_cart = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qand)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_qand
            // 
            this.txt_qand.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F);
            this.txt_qand.Location = new System.Drawing.Point(42, 79);
            this.txt_qand.Name = "txt_qand";
            this.txt_qand.Size = new System.Drawing.Size(145, 29);
            this.txt_qand.TabIndex = 27;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(42, 40);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(367, 21);
            this.lbl_title.TabIndex = 25;
            this.lbl_title.Text = "Quantos do item deseja adicionar ao carrinho?";
            // 
            // btn_cart
            // 
            this.btn_cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(232)))), ((int)(((byte)(207)))));
            this.btn_cart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cart.FlatAppearance.BorderSize = 0;
            this.btn_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cart.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cart.ForeColor = System.Drawing.Color.White;
            this.btn_cart.Image = global::View.Properties.Resources.Cart;
            this.btn_cart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cart.Location = new System.Drawing.Point(-2, 154);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.Size = new System.Drawing.Size(227, 37);
            this.btn_cart.TabIndex = 28;
            this.btn_cart.Text = "Adicionar ao Carrinho";
            this.btn_cart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cart.UseVisualStyleBackColor = false;
            this.btn_cart.Click += new System.EventHandler(this.btn_cart_Click_1);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Brown;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Image = global::View.Properties.Resources.cart_remove;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(299, 154);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(147, 37);
            this.btn_cancel.TabIndex = 26;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cart_Click);
            // 
            // AddCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 192);
            this.Controls.Add(this.btn_cart);
            this.Controls.Add(this.txt_qand);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCart";
            this.Deactivate += new System.EventHandler(this.AddCart_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.txt_qand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cart;
        private System.Windows.Forms.NumericUpDown txt_qand;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
    }
}