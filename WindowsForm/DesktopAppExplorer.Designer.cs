namespace WindowsForm
{
    partial class Frm_DesktopAppExplorer
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(224, 80);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(603, 37);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Aplicação com única função de se fechar";
            // 
            // btn_ExitButton
            // 
            this.btn_ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExitButton.Location = new System.Drawing.Point(368, 318);
            this.btn_ExitButton.Name = "btn_ExitButton";
            this.btn_ExitButton.Size = new System.Drawing.Size(289, 90);
            this.btn_ExitButton.TabIndex = 1;
            this.btn_ExitButton.Text = "Sair";
            this.btn_ExitButton.UseVisualStyleBackColor = true;
            this.btn_ExitButton.Click += new System.EventHandler(this.Btn_ExitButton_Click);
            // 
            // Frm_DesktopAppExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 539);
            this.Controls.Add(this.btn_ExitButton);
            this.Controls.Add(this.lbl_Title);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_DesktopAppExplorer";
            this.Text = "DesktopApp Explorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_ExitButton;
    }
}

