using Form_ClienteCadastro;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MenuApplication
{
    public partial class Form_FinTracker : Form
    {
        public Form_FinTracker()
        {
            InitializeComponent();
            Menu_Connect.Enabled = true;
            Menu_Disconnect.Enabled = false;
            Menu_ClienteCadastro.Enabled = false;
        }

        private void Menu_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_ClienteCadastro_Click(object sender, EventArgs e)
        {
            ClienteCadastro clienteCadastro = new ClienteCadastro();
            TabPage tp = new TabPage
            {
                Name = "Cliente Cadastro",
                Text = "Cadastrar Cliente",
                ImageIndex = 2
            };
            tp.Controls.Add(clienteCadastro);
            Tbc_FinTracker.TabPages.Add(tp);
        }

        private void Menu_Connect_Click(object sender, EventArgs e)
        {
            Form_Authentication form_Authentication = new Form_Authentication();
            form_Authentication.ShowDialog();

            if (form_Authentication.DialogResult == DialogResult.OK)
            {
                Menu_ClienteCadastro.Enabled = true;
                Menu_Connect.Enabled = false;
                Menu_Disconnect.Enabled = true;
            }
        }

        private void Menu_Disconnect_Click(object sender, EventArgs e)
        {
            for (int i = Tbc_FinTracker.TabPages.Count - 1; i >= 0; i--)
            {
                Tbc_FinTracker.TabPages.Remove(Tbc_FinTracker.TabPages[i]);
            }

            Menu_Connect.Enabled = true;
            Menu_Disconnect.Enabled = false;
            Menu_ClienteCadastro.Enabled = false;
        }

        private void Tbc_FinTracker_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var contextMenu = new ContextMenuStrip();
                var firstOption = ContextMenuDrawing("Fechar guia atual");
                contextMenu.Items.Add(firstOption);
                var secondOption = ContextMenuDrawing("Fechar todas guias");
                contextMenu.Items.Add(secondOption);
                contextMenu.Show(this, new Point(e.X, e.Y));
                firstOption.Click += new System.EventHandler(this.FirstOption_Click);
                secondOption.Click += new System.EventHandler(this.SecondOption_Click);
            }
        }

        private void FirstOption_Click(object sender, EventArgs e)
        {
            if (!(Tbc_FinTracker.SelectedTab is null))
            {
                Tbc_FinTracker.TabPages.Remove(Tbc_FinTracker.SelectedTab);
            }
        }

        private void SecondOption_Click(object sender, EventArgs e)
        {
            if (!(Tbc_FinTracker.SelectedTab is null))
            {
                for (int i = Tbc_FinTracker.TabPages.Count - 1; i >= 0; i += -1)
                {
                    Tbc_FinTracker.TabPages.Remove(Tbc_FinTracker.TabPages[i]);
                }
            }
        }

        private ToolStripMenuItem ContextMenuDrawing(string text)
        {
            var toolStrip = new ToolStripMenuItem
            {
                Text = text
            };
            return toolStrip;
        }
    }
}