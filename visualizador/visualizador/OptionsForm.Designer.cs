namespace visualizador
{
    partial class OptionsForm
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
            btn_OK = new Button();
            lbl_userName = new Label();
            txb_NomeUsuario = new TextBox();
            btn_cancelar = new Button();
            chk_ConfirmarAoSair = new CheckBox();
            grp_FundoPadrao = new GroupBox();
            opt_fundoBranco = new RadioButton();
            opt_fundoPadrao = new RadioButton();
            grp_FundoPadrao.SuspendLayout();
            SuspendLayout();
            // 
            // btn_OK
            // 
            btn_OK.Location = new Point(305, 12);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(75, 23);
            btn_OK.TabIndex = 0;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            btn_OK.Click += btn_OK_Click;
            // 
            // lbl_userName
            // 
            lbl_userName.AutoSize = true;
            lbl_userName.Location = new Point(40, 41);
            lbl_userName.Name = "lbl_userName";
            lbl_userName.Size = new Size(50, 15);
            lbl_userName.TabIndex = 9;
            lbl_userName.Text = "Usuário:";
            // 
            // txb_NomeUsuario
            // 
            txb_NomeUsuario.Location = new Point(105, 38);
            txb_NomeUsuario.MaxLength = 0;
            txb_NomeUsuario.Name = "txb_NomeUsuario";
            txb_NomeUsuario.Size = new Size(139, 23);
            txb_NomeUsuario.TabIndex = 10;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(304, 38);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 11;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // chk_ConfirmarAoSair
            // 
            chk_ConfirmarAoSair.AutoSize = true;
            chk_ConfirmarAoSair.Location = new Point(105, 79);
            chk_ConfirmarAoSair.Name = "chk_ConfirmarAoSair";
            chk_ConfirmarAoSair.Size = new Size(132, 19);
            chk_ConfirmarAoSair.TabIndex = 12;
            chk_ConfirmarAoSair.Text = "Confirmação ao sair";
            chk_ConfirmarAoSair.UseVisualStyleBackColor = true;
            // 
            // grp_FundoPadrao
            // 
            grp_FundoPadrao.Controls.Add(opt_fundoBranco);
            grp_FundoPadrao.Controls.Add(opt_fundoPadrao);
            grp_FundoPadrao.Location = new Point(105, 112);
            grp_FundoPadrao.Name = "grp_FundoPadrao";
            grp_FundoPadrao.Size = new Size(200, 72);
            grp_FundoPadrao.TabIndex = 13;
            grp_FundoPadrao.TabStop = false;
            grp_FundoPadrao.Text = "Fundo padrão da imagem";
            // 
            // opt_fundoBranco
            // 
            opt_fundoBranco.AutoSize = true;
            opt_fundoBranco.Location = new Point(14, 42);
            opt_fundoBranco.Name = "opt_fundoBranco";
            opt_fundoBranco.Size = new Size(62, 19);
            opt_fundoBranco.TabIndex = 1;
            opt_fundoBranco.Text = "Branco";
            opt_fundoBranco.UseVisualStyleBackColor = true;
            // 
            // opt_fundoPadrao
            // 
            opt_fundoPadrao.AutoSize = true;
            opt_fundoPadrao.Checked = true;
            opt_fundoPadrao.Location = new Point(14, 19);
            opt_fundoPadrao.Name = "opt_fundoPadrao";
            opt_fundoPadrao.Size = new Size(94, 19);
            opt_fundoPadrao.TabIndex = 0;
            opt_fundoPadrao.TabStop = true;
            opt_fundoPadrao.Text = "Padrão Cinza";
            opt_fundoPadrao.UseVisualStyleBackColor = true;
            // 
            // OptionsForm
            // 
            AcceptButton = btn_OK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.image_removebg_preview;
            BackgroundImageLayout = ImageLayout.Zoom;
            CancelButton = btn_cancelar;
            ClientSize = new Size(384, 261);
            Controls.Add(grp_FundoPadrao);
            Controls.Add(chk_ConfirmarAoSair);
            Controls.Add(btn_cancelar);
            Controls.Add(txb_NomeUsuario);
            Controls.Add(lbl_userName);
            Controls.Add(btn_OK);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "OptionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Opções do Visualizador";
            grp_FundoPadrao.ResumeLayout(false);
            grp_FundoPadrao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_OK;
        private Label lbl_userName;
        private TextBox txb_NomeUsuario;
        private Button btn_cancelar;
        private CheckBox chk_ConfirmarAoSair;
        private GroupBox grp_FundoPadrao;
        private RadioButton opt_fundoPadrao;
        private RadioButton opt_fundoBranco;
    }
}