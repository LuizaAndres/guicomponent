using System;
using System.Windows.Forms;

namespace _0106
{
    public partial class AbaUm : TabPage
    {
        public AbaUm()
        {
            InitializeComponent();
        }
        private void LinkForHelp_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to open link that was clicked.");
            }
        }
        private void VisitLink()
        {
            this.link_help.LinkVisited = true;
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\Chrome.exe",
            "https://docs.microsoft.com/pt-br/dotnet/api/system.windows.forms.linklabel.linkclicked?view=netcore-3.1");
        }
    }
}

