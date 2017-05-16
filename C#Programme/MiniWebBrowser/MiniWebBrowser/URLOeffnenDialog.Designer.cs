namespace MiniWebBrowser
{
    partial class URLOeffnenDialog
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelOeffnen = new System.Windows.Forms.Label();
            this.buttonOeffnen = new System.Windows.Forms.Button();
            this.buttonAbrechen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Öffnen);
            // 
            // labelOeffnen
            // 
            this.labelOeffnen.AutoSize = true;
            this.labelOeffnen.Location = new System.Drawing.Point(34, 31);
            this.labelOeffnen.Name = "labelOeffnen";
            this.labelOeffnen.Size = new System.Drawing.Size(55, 17);
            this.labelOeffnen.TabIndex = 1;
            this.labelOeffnen.Text = "Öffnen:";
            // 
            // buttonOeffnen
            // 
            this.buttonOeffnen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOeffnen.Enabled = false;
            this.buttonOeffnen.Location = new System.Drawing.Point(37, 79);
            this.buttonOeffnen.Name = "buttonOeffnen";
            this.buttonOeffnen.Size = new System.Drawing.Size(89, 23);
            this.buttonOeffnen.TabIndex = 2;
            this.buttonOeffnen.Text = "Öffnen";
            this.buttonOeffnen.UseVisualStyleBackColor = true;
            this.buttonOeffnen.Click += new System.EventHandler(this.buttonOeffnen_Click);
            // 
            // buttonAbrechen
            // 
            this.buttonAbrechen.Location = new System.Drawing.Point(174, 78);
            this.buttonAbrechen.Name = "buttonAbrechen";
            this.buttonAbrechen.Size = new System.Drawing.Size(89, 23);
            this.buttonAbrechen.TabIndex = 3;
            this.buttonAbrechen.Text = "Abbrechen";
            this.buttonAbrechen.UseVisualStyleBackColor = true;
            this.buttonAbrechen.Click += new System.EventHandler(this.buttonAbrechen_Click);
            // 
            // URLOeffnenDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 123);
            this.Controls.Add(this.buttonAbrechen);
            this.Controls.Add(this.buttonOeffnen);
            this.Controls.Add(this.labelOeffnen);
            this.Controls.Add(this.textBox1);
            this.Name = "URLOeffnenDialog";
            this.Text = "URLOeffnenDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelOeffnen;
        private System.Windows.Forms.Button buttonOeffnen;
        private System.Windows.Forms.Button buttonAbrechen;
    }
}