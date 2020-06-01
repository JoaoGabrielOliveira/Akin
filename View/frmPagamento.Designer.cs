namespace View
{
    partial class frmPagamento
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.cmbBuyForm = new System.Windows.Forms.ComboBox();
            this.panel_infopag_cart = new System.Windows.Forms.Panel();
            this.lbl_card_cvc = new System.Windows.Forms.Label();
            this.lbl_card_vencimento = new System.Windows.Forms.Label();
            this.lbl_card = new System.Windows.Forms.Label();
            this.panel_txt_cvc = new System.Windows.Forms.Panel();
            this.lbl_placeholder_cvc = new System.Windows.Forms.Label();
            this.txt_cvc = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.panel_txt_ncartao = new System.Windows.Forms.Panel();
            this.lbl_placeholder_ncartao = new System.Windows.Forms.Label();
            this.txt_ncartao = new System.Windows.Forms.TextBox();
            this.panel_infocomprador = new System.Windows.Forms.Panel();
            this.checkBox_gift = new System.Windows.Forms.CheckBox();
            this.panel_txt_cpf = new System.Windows.Forms.Panel();
            this.lbl_placeholder_ncpf = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.panel_txt_email = new System.Windows.Forms.Panel();
            this.lbl_placeholder_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.panel_txt_name = new System.Windows.Forms.Panel();
            this.lbl_placeholder_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_info_2 = new System.Windows.Forms.Label();
            this.lbl_info_1 = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_finalize = new System.Windows.Forms.Button();
            this.btn_gen_boleto = new System.Windows.Forms.Button();
            this.panel_infopag_cart.SuspendLayout();
            this.panel_txt_cvc.SuspendLayout();
            this.panel_txt_ncartao.SuspendLayout();
            this.panel_infocomprador.SuspendLayout();
            this.panel_txt_cpf.SuspendLayout();
            this.panel_txt_email.SuspendLayout();
            this.panel_txt_name.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(280, 43);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(393, 39);
            this.lbl_title.TabIndex = 21;
            this.lbl_title.Text = "Akin Winkel - Pagamento";
            // 
            // cmbBuyForm
            // 
            this.cmbBuyForm.FormattingEnabled = true;
            this.cmbBuyForm.Items.AddRange(new object[] {
            "Cartão de Crédito",
            "Cartão de Débito",
            "Boleto"});
            this.cmbBuyForm.Location = new System.Drawing.Point(657, 118);
            this.cmbBuyForm.Name = "cmbBuyForm";
            this.cmbBuyForm.Size = new System.Drawing.Size(240, 29);
            this.cmbBuyForm.TabIndex = 22;
            this.cmbBuyForm.SelectedIndexChanged += new System.EventHandler(this.cmbBuyForm_SelectedIndexChanged);
            // 
            // panel_infopag_cart
            // 
            this.panel_infopag_cart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(39)))), ((int)(((byte)(77)))));
            this.panel_infopag_cart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_infopag_cart.Controls.Add(this.lbl_card_cvc);
            this.panel_infopag_cart.Controls.Add(this.lbl_card_vencimento);
            this.panel_infopag_cart.Controls.Add(this.lbl_card);
            this.panel_infopag_cart.Controls.Add(this.panel_txt_cvc);
            this.panel_infopag_cart.Controls.Add(this.btn_finalize);
            this.panel_infopag_cart.Controls.Add(this.datePicker);
            this.panel_infopag_cart.Controls.Add(this.panel_txt_ncartao);
            this.panel_infopag_cart.Location = new System.Drawing.Point(387, 158);
            this.panel_infopag_cart.Name = "panel_infopag_cart";
            this.panel_infopag_cart.Size = new System.Drawing.Size(554, 327);
            this.panel_infopag_cart.TabIndex = 23;
            // 
            // lbl_card_cvc
            // 
            this.lbl_card_cvc.AutoSize = true;
            this.lbl_card_cvc.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_card_cvc.ForeColor = System.Drawing.Color.White;
            this.lbl_card_cvc.Location = new System.Drawing.Point(23, 201);
            this.lbl_card_cvc.Name = "lbl_card_cvc";
            this.lbl_card_cvc.Size = new System.Drawing.Size(188, 22);
            this.lbl_card_cvc.TabIndex = 33;
            this.lbl_card_cvc.Text = "Código de Segurança:";
            // 
            // lbl_card_vencimento
            // 
            this.lbl_card_vencimento.AutoSize = true;
            this.lbl_card_vencimento.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_card_vencimento.ForeColor = System.Drawing.Color.White;
            this.lbl_card_vencimento.Location = new System.Drawing.Point(23, 108);
            this.lbl_card_vencimento.Name = "lbl_card_vencimento";
            this.lbl_card_vencimento.Size = new System.Drawing.Size(179, 22);
            this.lbl_card_vencimento.TabIndex = 32;
            this.lbl_card_vencimento.Text = "Data de Vencimento:";
            // 
            // lbl_card
            // 
            this.lbl_card.AutoSize = true;
            this.lbl_card.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_card.ForeColor = System.Drawing.Color.White;
            this.lbl_card.Location = new System.Drawing.Point(23, 15);
            this.lbl_card.Name = "lbl_card";
            this.lbl_card.Size = new System.Drawing.Size(242, 22);
            this.lbl_card.TabIndex = 31;
            this.lbl_card.Text = "Cartão de Crédito ou Débito";
            // 
            // panel_txt_cvc
            // 
            this.panel_txt_cvc.BackColor = System.Drawing.Color.White;
            this.panel_txt_cvc.Controls.Add(this.lbl_placeholder_cvc);
            this.panel_txt_cvc.Controls.Add(this.txt_cvc);
            this.panel_txt_cvc.Location = new System.Drawing.Point(24, 226);
            this.panel_txt_cvc.Name = "panel_txt_cvc";
            this.panel_txt_cvc.Size = new System.Drawing.Size(333, 38);
            this.panel_txt_cvc.TabIndex = 18;
            this.panel_txt_cvc.Click += new System.EventHandler(this.panel_txt_cvc_Click);
            // 
            // lbl_placeholder_cvc
            // 
            this.lbl_placeholder_cvc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_placeholder_cvc.AutoSize = true;
            this.lbl_placeholder_cvc.BackColor = System.Drawing.Color.White;
            this.lbl_placeholder_cvc.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placeholder_cvc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(112)))), ((int)(((byte)(111)))));
            this.lbl_placeholder_cvc.Location = new System.Drawing.Point(9, 9);
            this.lbl_placeholder_cvc.Name = "lbl_placeholder_cvc";
            this.lbl_placeholder_cvc.Size = new System.Drawing.Size(40, 21);
            this.lbl_placeholder_cvc.TabIndex = 8;
            this.lbl_placeholder_cvc.Text = "CVC";
            // 
            // txt_cvc
            // 
            this.txt_cvc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_cvc.BackColor = System.Drawing.Color.White;
            this.txt_cvc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cvc.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txt_cvc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.txt_cvc.Location = new System.Drawing.Point(14, 9);
            this.txt_cvc.Name = "txt_cvc";
            this.txt_cvc.Size = new System.Drawing.Size(307, 21);
            this.txt_cvc.TabIndex = 7;
            this.txt_cvc.Enter += new System.EventHandler(this.txt_cvc_Enter);
            // 
            // datePicker
            // 
            this.datePicker.Checked = false;
            this.datePicker.CustomFormat = "MM/yyyy";
            this.datePicker.Location = new System.Drawing.Point(24, 133);
            this.datePicker.MaxDate = new System.DateTime(2090, 12, 30, 23, 59, 0, 0);
            this.datePicker.MinDate = new System.DateTime(2020, 5, 25, 23, 59, 59, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowCheckBox = true;
            this.datePicker.Size = new System.Drawing.Size(333, 29);
            this.datePicker.TabIndex = 18;
            this.datePicker.Value = new System.DateTime(2020, 5, 25, 23, 59, 59, 0);
            // 
            // panel_txt_ncartao
            // 
            this.panel_txt_ncartao.BackColor = System.Drawing.Color.White;
            this.panel_txt_ncartao.Controls.Add(this.lbl_placeholder_ncartao);
            this.panel_txt_ncartao.Controls.Add(this.txt_ncartao);
            this.panel_txt_ncartao.Location = new System.Drawing.Point(24, 41);
            this.panel_txt_ncartao.Name = "panel_txt_ncartao";
            this.panel_txt_ncartao.Size = new System.Drawing.Size(333, 38);
            this.panel_txt_ncartao.TabIndex = 17;
            this.panel_txt_ncartao.Click += new System.EventHandler(this.panel_txt_ncartao_Click);
            // 
            // lbl_placeholder_ncartao
            // 
            this.lbl_placeholder_ncartao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_placeholder_ncartao.AutoSize = true;
            this.lbl_placeholder_ncartao.BackColor = System.Drawing.Color.White;
            this.lbl_placeholder_ncartao.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placeholder_ncartao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(112)))), ((int)(((byte)(111)))));
            this.lbl_placeholder_ncartao.Location = new System.Drawing.Point(9, 9);
            this.lbl_placeholder_ncartao.Name = "lbl_placeholder_ncartao";
            this.lbl_placeholder_ncartao.Size = new System.Drawing.Size(140, 21);
            this.lbl_placeholder_ncartao.TabIndex = 8;
            this.lbl_placeholder_ncartao.Text = "Número do Cartão";
            // 
            // txt_ncartao
            // 
            this.txt_ncartao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_ncartao.BackColor = System.Drawing.Color.White;
            this.txt_ncartao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ncartao.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txt_ncartao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.txt_ncartao.Location = new System.Drawing.Point(14, 9);
            this.txt_ncartao.Name = "txt_ncartao";
            this.txt_ncartao.Size = new System.Drawing.Size(307, 21);
            this.txt_ncartao.TabIndex = 7;
            this.txt_ncartao.Enter += new System.EventHandler(this.txt_ncartao_Enter);
            this.txt_ncartao.Leave += new System.EventHandler(this.txt_ncartao_Leave);
            // 
            // panel_infocomprador
            // 
            this.panel_infocomprador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_infocomprador.Controls.Add(this.checkBox_gift);
            this.panel_infocomprador.Controls.Add(this.panel_txt_cpf);
            this.panel_infocomprador.Controls.Add(this.panel_txt_email);
            this.panel_infocomprador.Controls.Add(this.panel_txt_name);
            this.panel_infocomprador.Location = new System.Drawing.Point(12, 158);
            this.panel_infocomprador.Name = "panel_infocomprador";
            this.panel_infocomprador.Size = new System.Drawing.Size(345, 327);
            this.panel_infocomprador.TabIndex = 24;
            // 
            // checkBox_gift
            // 
            this.checkBox_gift.AutoSize = true;
            this.checkBox_gift.ForeColor = System.Drawing.Color.White;
            this.checkBox_gift.Location = new System.Drawing.Point(10, 268);
            this.checkBox_gift.Name = "checkBox_gift";
            this.checkBox_gift.Size = new System.Drawing.Size(202, 25);
            this.checkBox_gift.TabIndex = 20;
            this.checkBox_gift.Text = "Enviar como Presente?";
            this.checkBox_gift.UseVisualStyleBackColor = true;
            // 
            // panel_txt_cpf
            // 
            this.panel_txt_cpf.BackColor = System.Drawing.Color.White;
            this.panel_txt_cpf.Controls.Add(this.lbl_placeholder_ncpf);
            this.panel_txt_cpf.Controls.Add(this.txt_cpf);
            this.panel_txt_cpf.Location = new System.Drawing.Point(10, 198);
            this.panel_txt_cpf.Name = "panel_txt_cpf";
            this.panel_txt_cpf.Size = new System.Drawing.Size(326, 38);
            this.panel_txt_cpf.TabIndex = 19;
            this.panel_txt_cpf.Click += new System.EventHandler(this.panel_txt_cpf_Click);
            // 
            // lbl_placeholder_ncpf
            // 
            this.lbl_placeholder_ncpf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_placeholder_ncpf.AutoSize = true;
            this.lbl_placeholder_ncpf.BackColor = System.Drawing.Color.White;
            this.lbl_placeholder_ncpf.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placeholder_ncpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(112)))), ((int)(((byte)(111)))));
            this.lbl_placeholder_ncpf.Location = new System.Drawing.Point(12, 9);
            this.lbl_placeholder_ncpf.Name = "lbl_placeholder_ncpf";
            this.lbl_placeholder_ncpf.Size = new System.Drawing.Size(124, 21);
            this.lbl_placeholder_ncpf.TabIndex = 8;
            this.lbl_placeholder_ncpf.Text = "Número do CPF:";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_cpf.BackColor = System.Drawing.Color.White;
            this.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cpf.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txt_cpf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.txt_cpf.Location = new System.Drawing.Point(11, 9);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(307, 21);
            this.txt_cpf.TabIndex = 7;
            this.txt_cpf.Enter += new System.EventHandler(this.txt_cpf_Enter);
            this.txt_cpf.Leave += new System.EventHandler(this.txt_cpf_Leave);
            // 
            // panel_txt_email
            // 
            this.panel_txt_email.BackColor = System.Drawing.Color.White;
            this.panel_txt_email.Controls.Add(this.lbl_placeholder_email);
            this.panel_txt_email.Controls.Add(this.txt_email);
            this.panel_txt_email.Location = new System.Drawing.Point(10, 115);
            this.panel_txt_email.Name = "panel_txt_email";
            this.panel_txt_email.Size = new System.Drawing.Size(326, 38);
            this.panel_txt_email.TabIndex = 19;
            this.panel_txt_email.Click += new System.EventHandler(this.panel_txt_email_Click);
            // 
            // lbl_placeholder_email
            // 
            this.lbl_placeholder_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_placeholder_email.AutoSize = true;
            this.lbl_placeholder_email.BackColor = System.Drawing.Color.White;
            this.lbl_placeholder_email.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placeholder_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(112)))), ((int)(((byte)(111)))));
            this.lbl_placeholder_email.Location = new System.Drawing.Point(12, 9);
            this.lbl_placeholder_email.Name = "lbl_placeholder_email";
            this.lbl_placeholder_email.Size = new System.Drawing.Size(51, 21);
            this.lbl_placeholder_email.TabIndex = 8;
            this.lbl_placeholder_email.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_email.BackColor = System.Drawing.Color.White;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txt_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.txt_email.Location = new System.Drawing.Point(11, 9);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(307, 21);
            this.txt_email.TabIndex = 7;
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // panel_txt_name
            // 
            this.panel_txt_name.BackColor = System.Drawing.Color.White;
            this.panel_txt_name.Controls.Add(this.lbl_placeholder_name);
            this.panel_txt_name.Controls.Add(this.txt_name);
            this.panel_txt_name.Location = new System.Drawing.Point(10, 32);
            this.panel_txt_name.Name = "panel_txt_name";
            this.panel_txt_name.Size = new System.Drawing.Size(326, 38);
            this.panel_txt_name.TabIndex = 18;
            this.panel_txt_name.Click += new System.EventHandler(this.panel_txt_name_Click);
            // 
            // lbl_placeholder_name
            // 
            this.lbl_placeholder_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_placeholder_name.AutoSize = true;
            this.lbl_placeholder_name.BackColor = System.Drawing.Color.White;
            this.lbl_placeholder_name.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placeholder_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(112)))), ((int)(((byte)(111)))));
            this.lbl_placeholder_name.Location = new System.Drawing.Point(12, 9);
            this.lbl_placeholder_name.Name = "lbl_placeholder_name";
            this.lbl_placeholder_name.Size = new System.Drawing.Size(56, 21);
            this.lbl_placeholder_name.TabIndex = 8;
            this.lbl_placeholder_name.Text = "Nome:";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(5)))));
            this.txt_name.Location = new System.Drawing.Point(11, 9);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(307, 21);
            this.txt_name.TabIndex = 7;
            this.txt_name.Enter += new System.EventHandler(this.txt_name_Enter);
            this.txt_name.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // lbl_info_2
            // 
            this.lbl_info_2.AutoSize = true;
            this.lbl_info_2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_2.ForeColor = System.Drawing.Color.White;
            this.lbl_info_2.Location = new System.Drawing.Point(392, 121);
            this.lbl_info_2.Name = "lbl_info_2";
            this.lbl_info_2.Size = new System.Drawing.Size(259, 22);
            this.lbl_info_2.TabIndex = 25;
            this.lbl_info_2.Text = "Escolher forma de Pagamento:";
            // 
            // lbl_info_1
            // 
            this.lbl_info_1.AutoSize = true;
            this.lbl_info_1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_1.ForeColor = System.Drawing.Color.White;
            this.lbl_info_1.Location = new System.Drawing.Point(15, 121);
            this.lbl_info_1.Name = "lbl_info_1";
            this.lbl_info_1.Size = new System.Drawing.Size(241, 22);
            this.lbl_info_1.TabIndex = 26;
            this.lbl_info_1.Text = "Informações do Comprador:";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(43)))), ((int)(((byte)(35)))));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(913, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(40, 26);
            this.btn_close.TabIndex = 33;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(232)))), ((int)(((byte)(207)))));
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Image = global::View.Properties.Resources.esquerda;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(213, 32);
            this.btn_back.TabIndex = 34;
            this.btn_back.Text = "Voltar para Compras";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
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
            this.btn_finalize.Location = new System.Drawing.Point(358, 285);
            this.btn_finalize.Name = "btn_finalize";
            this.btn_finalize.Size = new System.Drawing.Size(191, 37);
            this.btn_finalize.TabIndex = 30;
            this.btn_finalize.Text = "Finalizar Pagamento";
            this.btn_finalize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_finalize.UseVisualStyleBackColor = false;
            // 
            // btn_gen_boleto
            // 
            this.btn_gen_boleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(235)))), ((int)(((byte)(99)))));
            this.btn_gen_boleto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gen_boleto.FlatAppearance.BorderSize = 0;
            this.btn_gen_boleto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gen_boleto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gen_boleto.ForeColor = System.Drawing.Color.White;
            this.btn_gen_boleto.Image = global::View.Properties.Resources.Cart;
            this.btn_gen_boleto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_gen_boleto.Location = new System.Drawing.Point(520, 300);
            this.btn_gen_boleto.Name = "btn_gen_boleto";
            this.btn_gen_boleto.Size = new System.Drawing.Size(325, 37);
            this.btn_gen_boleto.TabIndex = 32;
            this.btn_gen_boleto.Text = "Gerar boleto bancário";
            this.btn_gen_boleto.UseVisualStyleBackColor = false;
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(953, 497);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel_infopag_cart);
            this.Controls.Add(this.lbl_info_1);
            this.Controls.Add(this.lbl_info_2);
            this.Controls.Add(this.panel_infocomprador);
            this.Controls.Add(this.cmbBuyForm);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_gen_boleto);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPagamento";
            this.Load += new System.EventHandler(this.frmPagamento_Load);
            this.panel_infopag_cart.ResumeLayout(false);
            this.panel_infopag_cart.PerformLayout();
            this.panel_txt_cvc.ResumeLayout(false);
            this.panel_txt_cvc.PerformLayout();
            this.panel_txt_ncartao.ResumeLayout(false);
            this.panel_txt_ncartao.PerformLayout();
            this.panel_infocomprador.ResumeLayout(false);
            this.panel_infocomprador.PerformLayout();
            this.panel_txt_cpf.ResumeLayout(false);
            this.panel_txt_cpf.PerformLayout();
            this.panel_txt_email.ResumeLayout(false);
            this.panel_txt_email.PerformLayout();
            this.panel_txt_name.ResumeLayout(false);
            this.panel_txt_name.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ComboBox cmbBuyForm;
        private System.Windows.Forms.Panel panel_infopag_cart;
        private System.Windows.Forms.Panel panel_txt_ncartao;
        private System.Windows.Forms.Label lbl_placeholder_ncartao;
        private System.Windows.Forms.TextBox txt_ncartao;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Panel panel_infocomprador;
        private System.Windows.Forms.Label lbl_info_2;
        private System.Windows.Forms.Panel panel_txt_name;
        private System.Windows.Forms.Label lbl_placeholder_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_info_1;
        private System.Windows.Forms.CheckBox checkBox_gift;
        private System.Windows.Forms.Panel panel_txt_cpf;
        private System.Windows.Forms.Label lbl_placeholder_ncpf;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Panel panel_txt_email;
        private System.Windows.Forms.Label lbl_placeholder_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_finalize;
        private System.Windows.Forms.Panel panel_txt_cvc;
        private System.Windows.Forms.Label lbl_placeholder_cvc;
        private System.Windows.Forms.TextBox txt_cvc;
        private System.Windows.Forms.Label lbl_card_cvc;
        private System.Windows.Forms.Label lbl_card_vencimento;
        private System.Windows.Forms.Label lbl_card;
        private System.Windows.Forms.Button btn_gen_boleto;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_back;
    }
}