namespace visualizador
{
    partial class w_visualizador
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_visualizador));
            btn_imagem = new Button();
            btn_fechar = new Button();
            pb_imagem = new PictureBox();
            ofd_imagem = new OpenFileDialog();
            btn_aumentar = new Button();
            btn_diminuir = new Button();
            btn_desenharBorda = new Button();
            lbl_X = new Label();
            lbl_Y = new Label();
            btn_OpcoesTexto = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_imagem).BeginInit();
            SuspendLayout();
            // 
            // btn_imagem
            // 
            btn_imagem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_imagem.Cursor = Cursors.Hand;
            btn_imagem.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btn_imagem.FlatStyle = FlatStyle.Flat;
            btn_imagem.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_imagem.ForeColor = SystemColors.Highlight;
            btn_imagem.Location = new Point(295, 10);
            btn_imagem.Name = "btn_imagem";
            btn_imagem.Size = new Size(85, 23);
            btn_imagem.TabIndex = 0;
            btn_imagem.Text = "Imagem...";
            btn_imagem.UseVisualStyleBackColor = true;
            btn_imagem.Click += btn_imagem_Click;
            // 
            // btn_fechar
            // 
            btn_fechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_fechar.Cursor = Cursors.Hand;
            btn_fechar.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btn_fechar.FlatStyle = FlatStyle.Flat;
            btn_fechar.ForeColor = Color.Red;
            btn_fechar.Location = new Point(295, 40);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(85, 23);
            btn_fechar.TabIndex = 1;
            btn_fechar.Text = "Sair";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // pb_imagem
            // 
            pb_imagem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pb_imagem.BorderStyle = BorderStyle.FixedSingle;
            pb_imagem.Location = new Point(8, 8);
            pb_imagem.Name = "pb_imagem";
            pb_imagem.Size = new Size(282, 275);
            pb_imagem.SizeMode = PictureBoxSizeMode.Zoom;
            pb_imagem.TabIndex = 1;
            pb_imagem.TabStop = false;
            pb_imagem.MouseLeave += pb_imagem_MouseLeave;
            pb_imagem.MouseMove += pb_imagem_MouseMove;
            // 
            // ofd_imagem
            // 
            ofd_imagem.FileName = "ofd_imagem";
            ofd_imagem.Filter = "PNG Files|*.PNG|Windows Bitmaps|*.BMP|JPEG Files|*.JPG";
            // 
            // btn_aumentar
            // 
            btn_aumentar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_aumentar.BackColor = Color.PaleGoldenrod;
            btn_aumentar.FlatStyle = FlatStyle.Popup;
            btn_aumentar.Font = new Font("Arial", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_aumentar.Location = new Point(338, 261);
            btn_aumentar.Name = "btn_aumentar";
            btn_aumentar.Size = new Size(21, 23);
            btn_aumentar.TabIndex = 6;
            btn_aumentar.Text = "^";
            btn_aumentar.UseVisualStyleBackColor = false;
            btn_aumentar.Click += btn_aumentar_Click;
            // 
            // btn_diminuir
            // 
            btn_diminuir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_diminuir.BackColor = Color.PaleGoldenrod;
            btn_diminuir.FlatStyle = FlatStyle.Popup;
            btn_diminuir.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_diminuir.Location = new Point(365, 261);
            btn_diminuir.Name = "btn_diminuir";
            btn_diminuir.Size = new Size(21, 23);
            btn_diminuir.TabIndex = 7;
            btn_diminuir.Text = "v";
            btn_diminuir.UseVisualStyleBackColor = false;
            btn_diminuir.Click += btn_diminuir_Click;
            // 
            // btn_desenharBorda
            // 
            btn_desenharBorda.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_desenharBorda.Cursor = Cursors.Hand;
            btn_desenharBorda.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btn_desenharBorda.FlatStyle = FlatStyle.Flat;
            btn_desenharBorda.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_desenharBorda.ForeColor = SystemColors.ActiveCaptionText;
            btn_desenharBorda.Location = new Point(295, 69);
            btn_desenharBorda.Name = "btn_desenharBorda";
            btn_desenharBorda.Size = new Size(85, 23);
            btn_desenharBorda.TabIndex = 2;
            btn_desenharBorda.Text = "Borda";
            btn_desenharBorda.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_desenharBorda.UseVisualStyleBackColor = true;
            btn_desenharBorda.Click += btn_desenharBorda_Click;
            // 
            // lbl_X
            // 
            lbl_X.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_X.AutoSize = true;
            lbl_X.Location = new Point(300, 110);
            lbl_X.Name = "lbl_X";
            lbl_X.Size = new Size(20, 16);
            lbl_X.TabIndex = 4;
            lbl_X.Text = "X:";
            // 
            // lbl_Y
            // 
            lbl_Y.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Y.AutoSize = true;
            lbl_Y.Location = new Point(300, 125);
            lbl_Y.Name = "lbl_Y";
            lbl_Y.Size = new Size(17, 16);
            lbl_Y.TabIndex = 5;
            lbl_Y.Text = "Y:";
            // 
            // btn_OpcoesTexto
            // 
            btn_OpcoesTexto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_OpcoesTexto.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_OpcoesTexto.Location = new Point(295, 155);
            btn_OpcoesTexto.Name = "btn_OpcoesTexto";
            btn_OpcoesTexto.Size = new Size(85, 23);
            btn_OpcoesTexto.TabIndex = 3;
            btn_OpcoesTexto.Text = "Opções texto";
            btn_OpcoesTexto.UseVisualStyleBackColor = true;
            btn_OpcoesTexto.Click += btn_OpcoesTexto_Click;
            // 
            // w_visualizador
            // 
            AcceptButton = btn_fechar;
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Cornsilk;
            CancelButton = btn_fechar;
            ClientSize = new Size(384, 286);
            Controls.Add(btn_OpcoesTexto);
            Controls.Add(lbl_Y);
            Controls.Add(lbl_X);
            Controls.Add(btn_diminuir);
            Controls.Add(btn_aumentar);
            Controls.Add(pb_imagem);
            Controls.Add(btn_fechar);
            Controls.Add(btn_desenharBorda);
            Controls.Add(btn_imagem);
            Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "w_visualizador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizador";
            Load += w_visualizador_Load;
            ((System.ComponentModel.ISupportInitialize)pb_imagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_imagem;
        private Button btn_fechar;
        private PictureBox pb_imagem;
        private OpenFileDialog ofd_imagem;
        private Button btn_aumentar;
        private Button btn_diminuir;
        private Button btn_desenharBorda;
        private Label lbl_X;
        private Label lbl_Y;
        private Button btn_OpcoesTexto;
    }
}
