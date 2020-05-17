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
            this.SuspendLayout();
            // 
            // flowProducts
            // 
            this.flowProducts.AutoScroll = true;
            this.flowProducts.Location = new System.Drawing.Point(13, 10);
            this.flowProducts.Name = "flowProducts";
            this.flowProducts.Size = new System.Drawing.Size(564, 394);
            this.flowProducts.TabIndex = 23;
            // 
            // StoreScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowProducts);
            this.Name = "StoreScreen";
            this.Size = new System.Drawing.Size(600, 411);
            this.Load += new System.EventHandler(this.StoreScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowProducts;
    }
}
