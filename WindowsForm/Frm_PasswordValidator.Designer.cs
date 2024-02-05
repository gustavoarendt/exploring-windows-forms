namespace WindowsForm
{
    partial class Frm_PasswordValidator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Level = new System.Windows.Forms.Label();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Btn_TooglePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Level
            // 
            this.Lbl_Level.AutoSize = true;
            this.Lbl_Level.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Level.Location = new System.Drawing.Point(12, 39);
            this.Lbl_Level.Name = "Lbl_Level";
            this.Lbl_Level.Size = new System.Drawing.Size(0, 20);
            this.Lbl_Level.TabIndex = 0;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(397, 10);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(107, 23);
            this.Btn_Clear.TabIndex = 1;
            this.Btn_Clear.Text = "Limpar";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(12, 12);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '*';
            this.Txt_Password.Size = new System.Drawing.Size(379, 20);
            this.Txt_Password.TabIndex = 2;
            this.Txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Password_KeyDown);
            // 
            // Btn_TooglePassword
            // 
            this.Btn_TooglePassword.Location = new System.Drawing.Point(397, 39);
            this.Btn_TooglePassword.Name = "Btn_TooglePassword";
            this.Btn_TooglePassword.Size = new System.Drawing.Size(107, 23);
            this.Btn_TooglePassword.TabIndex = 3;
            this.Btn_TooglePassword.Text = "Mostrar Senha";
            this.Btn_TooglePassword.UseVisualStyleBackColor = true;
            this.Btn_TooglePassword.Click += new System.EventHandler(this.Btn_TooglePassword_Click);
            // 
            // Frm_PasswordValidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 127);
            this.Controls.Add(this.Btn_TooglePassword);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Lbl_Level);
            this.Name = "Frm_PasswordValidator";
            this.Text = "Validador de Senhas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Level;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Button Btn_TooglePassword;
    }
}