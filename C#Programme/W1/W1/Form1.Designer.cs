namespace W1
{
    partial class ÜName
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
            this.MyName = new System.Windows.Forms.Button();
            this.cmdEnde = new System.Windows.Forms.Button();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MyName
            // 
            this.MyName.Location = new System.Drawing.Point(12, 207);
            this.MyName.Name = "MyName";
            this.MyName.Size = new System.Drawing.Size(106, 23);
            this.MyName.TabIndex = 0;
            this.MyName.Text = "Mein Name";
            this.MyName.UseVisualStyleBackColor = true;
            this.MyName.Click += new System.EventHandler(this.MyName_Click);
            // 
            // cmdEnde
            // 
            this.cmdEnde.Location = new System.Drawing.Point(195, 207);
            this.cmdEnde.Name = "cmdEnde";
            this.cmdEnde.Size = new System.Drawing.Size(75, 23);
            this.cmdEnde.TabIndex = 1;
            this.cmdEnde.Text = "Ende";
            this.cmdEnde.UseVisualStyleBackColor = true;
            this.cmdEnde.Click += new System.EventHandler(this.cmdEnde_Click);
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(12, 75);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 17);
            this.lblAnzeige.TabIndex = 2;
            // 
            // ÜName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdEnde);
            this.Controls.Add(this.MyName);
            this.Name = "ÜName";
            this.Text = "ÜName";
            this.Load += new System.EventHandler(this.ÜName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MyName;
        private System.Windows.Forms.Button cmdEnde;
        private System.Windows.Forms.Label lblAnzeige;
    }
}

