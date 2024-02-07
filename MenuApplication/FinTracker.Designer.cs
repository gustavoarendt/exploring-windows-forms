namespace MenuApplication
{
    partial class Form_FinTracker
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_FinTracker));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_Arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Cliente = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ClienteCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.Tbc_FinTracker = new System.Windows.Forms.TabControl();
            this.Img_List = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Arquivo,
            this.Menu_Cliente});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_Arquivo
            // 
            this.Menu_Arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Connect,
            this.Menu_Disconnect,
            this.Menu_Exit});
            this.Menu_Arquivo.Name = "Menu_Arquivo";
            this.Menu_Arquivo.Size = new System.Drawing.Size(61, 20);
            this.Menu_Arquivo.Text = "Arquivo";
            // 
            // Menu_Connect
            // 
            this.Menu_Connect.Name = "Menu_Connect";
            this.Menu_Connect.Size = new System.Drawing.Size(180, 22);
            this.Menu_Connect.Text = "Conectar";
            this.Menu_Connect.Click += new System.EventHandler(this.Menu_Connect_Click);
            // 
            // Menu_Disconnect
            // 
            this.Menu_Disconnect.Name = "Menu_Disconnect";
            this.Menu_Disconnect.Size = new System.Drawing.Size(180, 22);
            this.Menu_Disconnect.Text = "Desconectar";
            this.Menu_Disconnect.Click += new System.EventHandler(this.Menu_Disconnect_Click);
            // 
            // Menu_Exit
            // 
            this.Menu_Exit.Name = "Menu_Exit";
            this.Menu_Exit.Size = new System.Drawing.Size(180, 22);
            this.Menu_Exit.Text = "Sair";
            this.Menu_Exit.Click += new System.EventHandler(this.Menu_Exit_Click);
            // 
            // Menu_Cliente
            // 
            this.Menu_Cliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_ClienteCadastro});
            this.Menu_Cliente.Image = global::MenuApplication.Properties.Resources.user1;
            this.Menu_Cliente.Name = "Menu_Cliente";
            this.Menu_Cliente.Size = new System.Drawing.Size(72, 20);
            this.Menu_Cliente.Text = "Cliente";
            // 
            // Menu_ClienteCadastro
            // 
            this.Menu_ClienteCadastro.Image = global::MenuApplication.Properties.Resources.plus1;
            this.Menu_ClienteCadastro.Name = "Menu_ClienteCadastro";
            this.Menu_ClienteCadastro.Size = new System.Drawing.Size(180, 22);
            this.Menu_ClienteCadastro.Text = "Cadastrar";
            this.Menu_ClienteCadastro.Click += new System.EventHandler(this.Menu_ClienteCadastro_Click);
            // 
            // Tbc_FinTracker
            // 
            this.Tbc_FinTracker.ImageList = this.Img_List;
            this.Tbc_FinTracker.Location = new System.Drawing.Point(12, 27);
            this.Tbc_FinTracker.Name = "Tbc_FinTracker";
            this.Tbc_FinTracker.SelectedIndex = 0;
            this.Tbc_FinTracker.Size = new System.Drawing.Size(728, 411);
            this.Tbc_FinTracker.TabIndex = 1;
            this.Tbc_FinTracker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tbc_FinTracker_MouseDown);
            // 
            // Img_List
            // 
            this.Img_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img_List.ImageStream")));
            this.Img_List.TransparentColor = System.Drawing.Color.Transparent;
            this.Img_List.Images.SetKeyName(0, "keys.png");
            this.Img_List.Images.SetKeyName(1, "money.png");
            this.Img_List.Images.SetKeyName(2, "plus.png");
            this.Img_List.Images.SetKeyName(3, "sheets.png");
            this.Img_List.Images.SetKeyName(4, "user.png");
            // 
            // Form_FinTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.Tbc_FinTracker);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_FinTracker";
            this.Text = "FinTracker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_Arquivo;
        private System.Windows.Forms.ToolStripMenuItem Menu_Cliente;
        private System.Windows.Forms.ToolStripMenuItem Menu_ClienteCadastro;
        private System.Windows.Forms.ToolStripMenuItem Menu_Connect;
        private System.Windows.Forms.ToolStripMenuItem Menu_Disconnect;
        private System.Windows.Forms.ToolStripMenuItem Menu_Exit;
        private System.Windows.Forms.TabControl Tbc_FinTracker;
        private System.Windows.Forms.ImageList Img_List;
    }
}

