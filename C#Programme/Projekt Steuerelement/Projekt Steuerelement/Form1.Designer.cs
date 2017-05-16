namespace Projekt_Steuerelement
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
            this.cmdPositionRel = new System.Windows.Forms.Button();
            this.cmdPositionAbs = new System.Windows.Forms.Button();
            this.cmdGroeßeRel = new System.Windows.Forms.Button();
            this.cmdGroeßeAbs = new System.Windows.Forms.Button();
            this.cmdTest = new System.Windows.Forms.Button();
            this.cmdAnzeige = new System.Windows.Forms.Button();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdPositionRel
            // 
            this.cmdPositionRel.Location = new System.Drawing.Point(39, 49);
            this.cmdPositionRel.Name = "cmdPositionRel";
            this.cmdPositionRel.Size = new System.Drawing.Size(96, 23);
            this.cmdPositionRel.TabIndex = 0;
            this.cmdPositionRel.Text = "Position Rel";
            this.cmdPositionRel.UseVisualStyleBackColor = true;
            this.cmdPositionRel.Click += new System.EventHandler(this.cmdPositionRel_Click);
            // 
            // cmdPositionAbs
            // 
            this.cmdPositionAbs.Location = new System.Drawing.Point(235, 48);
            this.cmdPositionAbs.Name = "cmdPositionAbs";
            this.cmdPositionAbs.Size = new System.Drawing.Size(100, 23);
            this.cmdPositionAbs.TabIndex = 1;
            this.cmdPositionAbs.Text = "Position Abs";
            this.cmdPositionAbs.UseVisualStyleBackColor = true;
            this.cmdPositionAbs.Click += new System.EventHandler(this.cmdPositionAbs_Click);
            // 
            // cmdGroeßeRel
            // 
            this.cmdGroeßeRel.Location = new System.Drawing.Point(39, 128);
            this.cmdGroeßeRel.Name = "cmdGroeßeRel";
            this.cmdGroeßeRel.Size = new System.Drawing.Size(96, 23);
            this.cmdGroeßeRel.TabIndex = 2;
            this.cmdGroeßeRel.Text = "Größe Rel";
            this.cmdGroeßeRel.UseVisualStyleBackColor = true;
            this.cmdGroeßeRel.Click += new System.EventHandler(this.cmdGroeßeRel_Click);
            // 
            // cmdGroeßeAbs
            // 
            this.cmdGroeßeAbs.Location = new System.Drawing.Point(235, 127);
            this.cmdGroeßeAbs.Name = "cmdGroeßeAbs";
            this.cmdGroeßeAbs.Size = new System.Drawing.Size(100, 23);
            this.cmdGroeßeAbs.TabIndex = 3;
            this.cmdGroeßeAbs.Text = "Größe Abs";
            this.cmdGroeßeAbs.UseVisualStyleBackColor = true;
            this.cmdGroeßeAbs.Click += new System.EventHandler(this.cmdGroeßeAbs_Click);
            // 
            // cmdTest
            // 
            this.cmdTest.Location = new System.Drawing.Point(39, 266);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(96, 23);
            this.cmdTest.TabIndex = 4;
            this.cmdTest.Text = "Test";
            this.cmdTest.UseVisualStyleBackColor = true;
            // 
            // cmdAnzeige
            // 
            this.cmdAnzeige.Location = new System.Drawing.Point(235, 186);
            this.cmdAnzeige.Name = "cmdAnzeige";
            this.cmdAnzeige.Size = new System.Drawing.Size(100, 23);
            this.cmdAnzeige.TabIndex = 5;
            this.cmdAnzeige.Text = "Anzeigen";
            this.cmdAnzeige.UseVisualStyleBackColor = true;
            this.cmdAnzeige.Click += new System.EventHandler(this.cmdAnzeige_Click);
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Location = new System.Drawing.Point(235, 236);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(0, 17);
            this.lblAnzeige.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 363);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.cmdAnzeige);
            this.Controls.Add(this.cmdTest);
            this.Controls.Add(this.cmdGroeßeAbs);
            this.Controls.Add(this.cmdGroeßeRel);
            this.Controls.Add(this.cmdPositionAbs);
            this.Controls.Add(this.cmdPositionRel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdPositionRel;
        private System.Windows.Forms.Button cmdPositionAbs;
        private System.Windows.Forms.Button cmdGroeßeRel;
        private System.Windows.Forms.Button cmdGroeßeAbs;
        private System.Windows.Forms.Button cmdTest;
        private System.Windows.Forms.Button cmdAnzeige;
        private System.Windows.Forms.Label lblAnzeige;
    }
}

