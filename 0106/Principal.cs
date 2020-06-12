using System;
using System.Windows.Forms;

namespace _0106
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        private void WindowNovoMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New!!!!");
        }

        private void WindowSalvarMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save!!!!");
        }

        private void Btn_ConfirmarClick(object sender, EventArgs e)
        {

            MessageBox.Show($"Save!!!!");
        }
        private void Btn_CancelarClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}