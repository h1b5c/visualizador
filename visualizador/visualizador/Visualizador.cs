namespace visualizador
{
    public partial class w_visualizador : Form
    {
        public w_visualizador()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_imagem_Click(object sender, EventArgs e)
        {
            if (ofd_imagem.ShowDialog() == DialogResult.OK)
            {
                pb_imagem.Image = Image.FromFile(ofd_imagem.FileName);
            }
        }

        private void btn_aumentar_Click(object sender, EventArgs e)
        {
            this.Width = this.Width + 20;
            this.Height = this.Height + 20;
        }

        private void btn_diminuir_Click(object sender, EventArgs e)
        {
            this.Width -= 20;
            this.Height -= 20;
        }

        private void btn_desenharBorda_Click(object sender, EventArgs e)
        {
            Graphics ObjetoGrafico = null;
            ObjetoGrafico = this.CreateGraphics();
            ObjetoGrafico.Clear(Color.Cornsilk);
            ObjetoGrafico.DrawRectangle(Pens.Blue, pb_imagem.Left - 1, pb_imagem.Top - 1, pb_imagem.Width + 1, pb_imagem.Height + 1);
            ObjetoGrafico.Dispose();
        }

        private void pb_imagem_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_X.Text = "X: " + e.X.ToString();
            lbl_Y.Text = "Y: " + e.Y.ToString();
        }

        private void pb_imagem_MouseLeave(object sender, EventArgs e)
        {
            lbl_X.Text = "";
            lbl_Y.Text = "";
        }

        private void w_visualizador_Load(object sender, EventArgs e)
        {
            lbl_X.Text = "";
            lbl_Y.Text = "";
        }

        private void btn_OpcoesTexto_Click(object sender, EventArgs e)
        {
            OptionsForm frm_OptionsDialog = new OptionsForm();
            frm_OptionsDialog.Show();
        }
    }
}
