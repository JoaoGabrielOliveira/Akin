namespace View.Screen
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_text3 = new System.Windows.Forms.Label();
            this.lbl_text2 = new System.Windows.Forms.Label();
            this.lbl_text1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(235)))), ((int)(((byte)(99)))));
            this.lbl_title.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(224, 16);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(226, 50);
            this.lbl_title.TabIndex = 21;
            this.lbl_title.Text = "Bem Vindo";
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // lbl_text3
            // 
            this.lbl_text3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(235)))));
            this.lbl_text3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text3.ForeColor = System.Drawing.Color.White;
            this.lbl_text3.Location = new System.Drawing.Point(87, 367);
            this.lbl_text3.Name = "lbl_text3";
            this.lbl_text3.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lbl_text3.Size = new System.Drawing.Size(501, 94);
            this.lbl_text3.TabIndex = 22;
            this.lbl_text3.Text = "AKIN é uma palavra de origem africana que significa Guerreiro e Herói, esses que " +
    "sempre tinham o objetivo";
            this.lbl_text3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_text2
            // 
            this.lbl_text2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(23)))));
            this.lbl_text2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text2.ForeColor = System.Drawing.Color.White;
            this.lbl_text2.Location = new System.Drawing.Point(87, 241);
            this.lbl_text2.Name = "lbl_text2";
            this.lbl_text2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lbl_text2.Size = new System.Drawing.Size(501, 94);
            this.lbl_text2.TabIndex = 23;
            this.lbl_text2.Text = "AKIN é uma palavra de origem africana que significa Guerreiro e Herói, esses que " +
    "sempre tinham o objetivo";
            this.lbl_text2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_text1
            // 
            this.lbl_text1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(23)))), ((int)(((byte)(71)))));
            this.lbl_text1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text1.ForeColor = System.Drawing.Color.White;
            this.lbl_text1.Location = new System.Drawing.Point(87, 115);
            this.lbl_text1.Name = "lbl_text1";
            this.lbl_text1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lbl_text1.Size = new System.Drawing.Size(501, 94);
            this.lbl_text1.TabIndex = 24;
            this.lbl_text1.Text = resources.GetString("lbl_text1.Text");
            this.lbl_text1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_text1.Click += new System.EventHandler(this.label3_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lbl_text1);
            this.Controls.Add(this.lbl_text2);
            this.Controls.Add(this.lbl_text3);
            this.Controls.Add(this.lbl_title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeScreen";
            this.Size = new System.Drawing.Size(675, 499);
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_text3;
        private System.Windows.Forms.Label lbl_text2;
        private System.Windows.Forms.Label lbl_text1;
    }
}
