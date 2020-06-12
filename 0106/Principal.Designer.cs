using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace _0106
{
    partial class Principal : Form
    {
        private IContainer components = null;
        private TabControl tabControl;
        private Button btn_Confirmar;
        private Button btn_Cancelar;

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
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.LightGray;
            this.ClientSize = new Size(500, 640);
            this.Text = "Principal";

            this.tabControl = new TabControl();
            this.tabControl.Size = new Size(500, 550);
            this.tabControl.Location = new Point(0, 20);

            TabPage abaUm = new AbaUm();
            this.tabControl.Controls.Add(abaUm);
            TabPage abaDois = new AbaDois();
            this.tabControl.Controls.Add(abaDois);
            TabPage abaTres = new AbaTres();
            this.tabControl.Controls.Add(abaTres);

            this.Controls.Add(this.tabControl);
            MenuStrip menu = new MenuStrip();
            ToolStripMenuItem windowMenu = new ToolStripMenuItem("Window");
            menu.MdiWindowListItem = windowMenu;
            ToolStripMenuItem windowNovoMenu = new ToolStripMenuItem("Novo", null, new EventHandler(WindowNovoMenu_Click));
            windowMenu.DropDownItems.Add(windowNovoMenu);
            ToolStripMenuItem windowSalvarMenu = new ToolStripMenuItem("Salvar", null, new EventHandler(WindowSalvarMenu_Click));
            windowMenu.DropDownItems.Add(windowSalvarMenu);
            ((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(windowMenu.DropDown)).ShowCheckMargin = true;

            menu.Items.Add(windowMenu);
            menu.Dock = DockStyle.Top;
            this.MainMenuStrip = menu;
            this.Controls.Add(menu);

            this.btn_Confirmar = new Button();
            this.btn_Confirmar.Text = "CONFIRMAR";
            this.btn_Confirmar.Location = new Point(70, 580);
            this.btn_Confirmar.Size = new Size(150, 40);
            this.btn_Confirmar.BackColor = Color.Gray;
            this.btn_Confirmar.ForeColor = Color.Black;
            this.btn_Confirmar.Click += new EventHandler(this.Btn_ConfirmarClick);
            this.Controls.Add(this.btn_Confirmar);

            this.btn_Cancelar = new Button();
            this.btn_Cancelar.Text = "CANCELAR";
            this.btn_Cancelar.Location = new Point(260, 580);
            this.btn_Cancelar.Size = new Size(150, 40);
            this.btn_Cancelar.BackColor = Color.Gray;
            this.btn_Cancelar.ForeColor = Color.Chartreuse;
            this.btn_Cancelar.Click += new EventHandler(this.Btn_CancelarClick);
            this.Controls.Add(this.btn_Cancelar);
        }
    }
}