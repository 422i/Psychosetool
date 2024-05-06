namespace Dorians_Anus
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.hallobtn = new System.Windows.Forms.Button();
            this.phillcbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hallobtn
            // 
            this.hallobtn.Location = new System.Drawing.Point(225, 225);
            this.hallobtn.Name = "hallobtn";
            this.hallobtn.Size = new System.Drawing.Size(95, 23);
            this.hallobtn.TabIndex = 0;
            this.hallobtn.Text = "check psychose";
            this.hallobtn.UseVisualStyleBackColor = true;
            this.hallobtn.Click += new System.EventHandler(this.hallobtn_Click);
            // 
            // phillcbox
            // 
            this.phillcbox.FormattingEnabled = true;
            this.phillcbox.Items.AddRange(new object[] {
            "Phill",
            "Jeff"});
            this.phillcbox.Location = new System.Drawing.Point(199, 124);
            this.phillcbox.Name = "phillcbox";
            this.phillcbox.Size = new System.Drawing.Size(121, 21);
            this.phillcbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Psychose Calculator!!!!1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 260);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phillcbox);
            this.Controls.Add(this.hallobtn);
            this.Name = "Form1";
            this.Text = "Dorians Anus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hallobtn;
        private System.Windows.Forms.ComboBox phillcbox;
        private System.Windows.Forms.Label label1;
    }
}

