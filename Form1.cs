using System;

namespace DificuldadeClique
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bntNao_MouseMove(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int y = random.Next(0, this.Height - bntNao.Height);
            int x = random.Next(0, this.Width - bntNao.Width);
            bntNao.Location = new Point(x, y);
        }
    }
}
