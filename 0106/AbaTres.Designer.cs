using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace _0106
{
    partial class AbaTres
    {
        private IContainer components = null;
        private FlowLayoutPanel FlowLayoutPanel;
        private Library.Label lb_MonthCalendar;
        private MonthCalendar mc_MonthCal;
        private Library.Label lbl_Web;
        private WebBrowser wb_ExWebBrowser;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new Container();
            this.ClientSize = new Size(500, 550);
            this.Text = "Aba Tres";
            this.BackColor = Color.AliceBlue;
            this.Dock = DockStyle.Fill;

            this.FlowLayoutPanel = new FlowLayoutPanel();
            this.FlowLayoutPanel.Dock = DockStyle.Fill;
            this.FlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            this.FlowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            this.FlowLayoutPanel.Visible = true;

            this.lb_MonthCalendar = new Library.Label();
            this.lb_MonthCalendar.Text = "MonthCalendar";
            this.lb_MonthCalendar.Dock = DockStyle.Fill;
            this.FlowLayoutPanel.Controls.Add(this.lb_MonthCalendar);

            DateTime dtAgora = new DateTime();
            dtAgora = DateTime.Now;
            this.mc_MonthCal = new MonthCalendar();
            this.mc_MonthCal.MaxSelectionCount = 10;
            this.mc_MonthCal.MinDate = new DateTime(2019, 01, 01);
            this.mc_MonthCal.MaxDate = new DateTime(2020, 12, 31);
            this.mc_MonthCal.SelectionRange = new SelectionRange(dtAgora, new DateTime(2020, 05, 19));
            this.mc_MonthCal.Anchor = AnchorStyles.Top;
            this.mc_MonthCal.Dock = DockStyle.Fill;
            this.FlowLayoutPanel.Controls.Add(this.mc_MonthCal);

            this.lbl_Web = new Library.Label();
            this.lbl_Web.Text = "WebBrowser";
            this.lbl_Web.Dock = DockStyle.Fill;
            this.FlowLayoutPanel.Controls.Add(this.lbl_Web);

            this.wb_ExWebBrowser = new WebBrowser();
            this.wb_ExWebBrowser.Size = new Size(480, 300);
            this.wb_ExWebBrowser.Navigate("https://github.com/KaduFloresta");
            this.wb_ExWebBrowser.Anchor = AnchorStyles.Bottom;
            this.FlowLayoutPanel.Controls.Add(this.wb_ExWebBrowser);

            this.Controls.Add(this.FlowLayoutPanel);
        }
    }
}
