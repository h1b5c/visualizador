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
            // OptionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.image_removebg_preview;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(384, 261);
            Controls.Add(btn_OK);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "OptionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Opções do Visualizador";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_OK;
    }
}