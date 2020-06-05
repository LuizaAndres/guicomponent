using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

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