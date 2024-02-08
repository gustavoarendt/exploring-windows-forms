namespace MenuApplication
{
    partial class Form_Question
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
            this.Lbl_Question = new System.Windows.Forms.Label();
            this.Btn_Confirm = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Question
            // 
            this.Lbl_Question.AutoSize = true;
            this.Lbl_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Question.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Question.Name = "Lbl_Question";
            this.Lbl_Question.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_Question.Size = new System.Drawing.Size(0, 20);
            this.Lbl_Question.TabIndex = 0;
            this.Lbl_Question.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Confirm.Location = new System.Drawing.Point(423, 138);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.Btn_Confirm.TabIndex = 1;
            this.Btn_Confirm.Text = "Confirmar";
            this.Btn_Confirm.UseVisualStyleBackColor = true;
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(12, 138);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 2;
            this.Btn_Cancel.Text = "Cancelar";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Form_Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 173);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.Lbl_Question);
            this.Name = "Form_Question";
            this.Text = "Confirmação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Question;
        private System.Windows.Forms.Button Btn_Confirm;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}