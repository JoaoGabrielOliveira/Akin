namespace View
{
    partial class frmPrincipal
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
            this.panel_menu = new System.Windows.Forms.Panel();
            this.lbl_not_number = new System.Windows.Forms.Label();
            this.panel_ext_btn = new System.Windows.Forms.Panel();
            this.btn_ext_site = new System.Windows.Forms.Button();
            this.btn_ext_facebook = new System.Windows.Forms.Button();
            this.btn_cart = new System.Windows.Forms.Button();
            this.btn_store = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel_profile = new System.Windows.Forms.Panel();
            this.btn_profile = new System.Windows.Forms.Button();
            this.lbl_index = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.cartScreen = new View.Screen.CartScreen();
            this.storeScreen = new View.Screen.StoreScreen();
            this.homeScreen = new View.Screen.HomeScreen();
            this.profileScreen = new View.Screen.ProfileScreen();
            this.panel_menu.SuspendLayout();
            this.panel_ext_btn.SuspendLayout();
            this.panel_profile.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(235)))), ((int)(((byte)(99)))));
            this.panel_menu.Controls.Add(this.lbl_not_number);
            this.panel_menu.Controls.Add(this.panel_ext_btn);
            this.panel_menu.Controls.Add(this.btn_cart);
            this.panel_menu.Controls.Add(this.btn_store);
            this.panel_menu.Controls.Add(this.btn_home);
            this.panel_menu.Controls.Add(this.panel_profile);
            this.panel_menu.Controls.Add(this.lbl_index);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(200, 575);
            this.panel_menu.TabIndex = 0;
            // 
            // lbl_not_number
            // 
            this.lbl_not_number.AutoSize = true;
            this.lbl_not_number.BackColor = System.Drawing.Color.Red;
            this.lbl_not_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_not_number.ForeColor = System.Drawing.Color.White;
            this.lbl_not_number.Location = new System.Drawing.Point(51, 334);
            this.lbl_not_number.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_not_number.Name = "lbl_not_number";
            this.lbl_not_number.Size = new System.Drawing.Size(17, 12);
            this.lbl_not_number.TabIndex = 6;
            this.lbl_not_number.Text = "1+";
            this.lbl_not_number.Visible = false;
            // 
            // panel_ext_btn
            // 
            this.panel_ext_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(232)))), ((int)(((byte)(207)))));
            this.panel_ext_btn.Controls.Add(this.btn_ext_site);
            this.panel_ext_btn.Controls.Add(this.btn_ext_facebook);
            this.panel_ext_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ext_btn.Location = new System.Drawing.Point(0, 514);
            this.panel_ext_btn.Name = "panel_ext_btn";
            this.panel_ext_btn.Size = new System.Drawing.Size(200, 61);
            this.panel_ext_btn.TabIndex = 2;
            // 
            // btn_ext_site
            // 
            this.btn_ext_site.BackColor = System.Drawing.Color.Transparent;
            this.btn_ext_site.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ext_site.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_ext_site.FlatAppearance.BorderSize = 2;
            this.btn_ext_site.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ext_site.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ext_site.Image = global::View.Properties.Resources.link_externo;
            this.btn_ext_site.Location = new System.Drawing.Point(119, 8);
            this.btn_ext_site.Name = "btn_ext_site";
            this.btn_ext_site.Size = new System.Drawing.Size(44, 44);
            this.btn_ext_site.TabIndex = 6;
            this.btn_ext_site.UseVisualStyleBackColor = false;
            // 
            // btn_ext_facebook
            // 
            this.btn_ext_facebook.BackColor = System.Drawing.Color.Transparent;
            this.btn_ext_facebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ext_facebook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_ext_facebook.FlatAppearance.BorderSize = 2;
            this.btn_ext_facebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ext_facebook.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ext_facebook.Image = global::View.Properties.Resources.facebook;
            this.btn_ext_facebook.Location = new System.Drawing.Point(38, 8);
            this.btn_ext_facebook.Name = "btn_ext_facebook";
            this.btn_ext_facebook.Size = new System.Drawing.Size(44, 44);
            this.btn_ext_facebook.TabIndex = 5;
            this.btn_ext_facebook.UseVisualStyleBackColor = false;
            // 
            // btn_cart
            // 
            this.btn_cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(232)))), ((int)(((byte)(207)))));
            this.btn_cart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cart.FlatAppearance.BorderSize = 0;
            this.btn_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cart.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cart.ForeColor = System.Drawing.Color.White;
            this.btn_cart.Image = global::View.Properties.Resources.Cart;
            this.btn_cart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cart.Location = new System.Drawing.Point(27, 302);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.Size = new System.Drawing.Size(173, 50);
            this.btn_cart.TabIndex = 6;
            this.btn_cart.Text = "Carrinho";
            this.btn_cart.UseVisualStyleBackColor = false;
            this.btn_cart.Click += new System.EventHandler(this.btn_cart_Click);
            // 
            // btn_store
            // 
            this.btn_store.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(232)))), ((int)(((byte)(207)))));
            this.btn_store.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_store.FlatAppearance.BorderSize = 0;
            this.btn_store.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_store.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_store.ForeColor = System.Drawing.Color.White;
            this.btn_store.Image = global::View.Properties.Resources.shop;
            this.btn_store.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_store.Location = new System.Drawing.Point(27, 213);
            this.btn_store.Name = "btn_store";
            this.btn_store.Size = new System.Drawing.Size(173, 50);
            this.btn_store.TabIndex = 5;
            this.btn_store.Text = "Loja";
            this.btn_store.UseVisualStyleBackColor = false;
            this.btn_store.Click += new System.EventHandler(this.btn_store_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(105)))), ((int)(((byte)(93)))));
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = global::View.Properties.Resources.shop;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(27, 124);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(173, 50);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel_profile
            // 
            this.panel_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(235)))), ((int)(((byte)(99)))));
            this.panel_profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_profile.Controls.Add(this.btn_profile);
            this.panel_profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_profile.Location = new System.Drawing.Point(0, 0);
            this.panel_profile.Name = "panel_profile";
            this.panel_profile.Size = new System.Drawing.Size(200, 76);
            this.panel_profile.TabIndex = 1;
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(232)))), ((int)(((byte)(207)))));
            this.btn_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_profile.FlatAppearance.BorderSize = 0;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile.ForeColor = System.Drawing.Color.White;
            this.btn_profile.Image = global::View.Properties.Resources.user;
            this.btn_profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profile.Location = new System.Drawing.Point(12, 12);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(182, 57);
            this.btn_profile.TabIndex = 3;
            this.btn_profile.Text = "RODOLFO";
            this.btn_profile.UseVisualStyleBackColor = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // lbl_index
            // 
            this.lbl_index.AutoSize = true;
            this.lbl_index.BackColor = System.Drawing.Color.Transparent;
            this.lbl_index.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_index.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(105)))), ((int)(((byte)(93)))));
            this.lbl_index.Location = new System.Drawing.Point(3, 136);
            this.lbl_index.Name = "lbl_index";
            this.lbl_index.Size = new System.Drawing.Size(25, 25);
            this.lbl_index.TabIndex = 2;
            this.lbl_index.Text = "●";
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(235)))), ((int)(((byte)(99)))));
            this.panel_header.Controls.Add(this.btn_close);
            this.panel_header.Controls.Add(this.lbl_title);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(200, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(675, 76);
            this.panel_header.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(43)))), ((int)(((byte)(35)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(635, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 26);
            this.btn_close.TabIndex = 19;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(23, 12);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(248, 50);
            this.lbl_title.TabIndex = 20;
            this.lbl_title.Text = "Akin Winkel";
            // 
            // cartScreen
            // 
            this.cartScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.cartScreen.Location = new System.Drawing.Point(201, 76);
            this.cartScreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cartScreen.Name = "cartScreen";
            this.cartScreen.Size = new System.Drawing.Size(674, 499);
            this.cartScreen.TabIndex = 5;
            this.cartScreen.Visible = false;
            this.cartScreen.VisibleChanged += new System.EventHandler(this.cartScreen_VisibleChanged);
            // 
            // storeScreen
            // 
            this.storeScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.storeScreen.Location = new System.Drawing.Point(200, 76);
            this.storeScreen.Name = "storeScreen";
            this.storeScreen.Size = new System.Drawing.Size(675, 499);
            this.storeScreen.TabIndex = 4;
            // 
            // homeScreen
            // 
            this.homeScreen.AutoSize = true;
            this.homeScreen.Location = new System.Drawing.Point(200, 76);
            this.homeScreen.Margin = new System.Windows.Forms.Padding(2);
            this.homeScreen.Name = "homeScreen";
            this.homeScreen.Size = new System.Drawing.Size(675, 499);
            this.homeScreen.TabIndex = 3;
            this.homeScreen.Visible = false;
            // 
            // profileScreen
            // 
            this.profileScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(232)))), ((int)(((byte)(207)))));
            this.profileScreen.Location = new System.Drawing.Point(200, 76);
            this.profileScreen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profileScreen.Name = "profileScreen";
            this.profileScreen.Size = new System.Drawing.Size(675, 499);
            this.profileScreen.TabIndex = 2;
            this.profileScreen.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 575);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel_menu);
            this.Controls.Add(this.cartScreen);
            this.Controls.Add(this.storeScreen);
            this.Controls.Add(this.homeScreen);
            this.Controls.Add(this.profileScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel_ext_btn.ResumeLayout(false);
            this.panel_profile.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_profile;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_cart;
        private System.Windows.Forms.Button btn_store;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel_ext_btn;
        private System.Windows.Forms.Button btn_ext_site;
        private System.Windows.Forms.Button btn_ext_facebook;
        private System.Windows.Forms.Label lbl_index;
        private Screen.ProfileScreen profileScreen;
        private Screen.HomeScreen homeScreen;
        private Screen.StoreScreen storeScreen;
        private Screen.CartScreen cartScreen;
        private System.Windows.Forms.Label lbl_not_number;
    }
}