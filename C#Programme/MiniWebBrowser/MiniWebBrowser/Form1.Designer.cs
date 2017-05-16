namespace MiniWebBrowser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSort = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLoeschen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNavigationsliste = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNavi = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRueck = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNeu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbbrechen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVoll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNavigation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLeiste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAdresse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNavi2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.contextMenuStripAktievieren1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAktivieren = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRueck = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonVor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNeu = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAbbrechen = new System.Windows.Forms.ToolStripButton();
            this.toolStripAdresse = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonLosGehts = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.contextMenuStripAktievieren1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStripAdresse.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Panel2.Controls.Add(this.menuStrip2);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(996, 363);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 336);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSort,
            this.toolStripMenuItemLoeschen});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 52);
            // 
            // toolStripMenuItemSort
            // 
            this.toolStripMenuItemSort.CheckOnClick = true;
            this.toolStripMenuItemSort.Name = "toolStripMenuItemSort";
            this.toolStripMenuItemSort.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuItemSort.Text = "&Sortieren";
            this.toolStripMenuItemSort.Click += new System.EventHandler(this.toolStripMenuItemSort_Click);
            // 
            // toolStripMenuItemLoeschen
            // 
            this.toolStripMenuItemLoeschen.CheckOnClick = true;
            this.toolStripMenuItemLoeschen.Name = "toolStripMenuItemLoeschen";
            this.toolStripMenuItemLoeschen.Size = new System.Drawing.Size(138, 24);
            this.toolStripMenuItemLoeschen.Text = "&Löschen";
            this.toolStripMenuItemLoeschen.Click += new System.EventHandler(this.toolStripMenuItemLoeschen_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNavigationsliste,
            this.toolStripButtonClose});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(182, 27);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonNavigationsliste
            // 
            this.toolStripButtonNavigationsliste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNavigationsliste.Image")));
            this.toolStripButtonNavigationsliste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNavigationsliste.Name = "toolStripButtonNavigationsliste";
            this.toolStripButtonNavigationsliste.Size = new System.Drawing.Size(139, 24);
            this.toolStripButtonNavigationsliste.Text = "Navigationsliste";
            this.toolStripButtonNavigationsliste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonClose.Checked = true;
            this.toolStripButtonClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClose.Image")));
            this.toolStripButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonClose.Text = "schließen";
            this.toolStripButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 24);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(810, 314);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.google.de", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(810, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip2.Location = new System.Drawing.Point(0, 338);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(810, 25);
            this.statusStrip2.TabIndex = 5;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 19);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItemNavi,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 24);
            this.toolStripMenuItem1.Text = "&Datei";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(191, 24);
            this.toolStripMenuItem2.Text = "Ö&ffnen";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(191, 24);
            this.toolStripMenuItem3.Text = "&Beenden";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItemNavi
            // 
            this.toolStripMenuItemNavi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemVor,
            this.toolStripMenuItemRueck,
            this.toolStripMenuItemNeu,
            this.toolStripMenuItemAbbrechen});
            this.toolStripMenuItemNavi.Name = "toolStripMenuItemNavi";
            this.toolStripMenuItemNavi.Size = new System.Drawing.Size(94, 24);
            this.toolStripMenuItemNavi.Text = "&Navigation";
            // 
            // toolStripMenuItemVor
            // 
            this.toolStripMenuItemVor.Name = "toolStripMenuItemVor";
            this.toolStripMenuItemVor.Size = new System.Drawing.Size(194, 24);
            this.toolStripMenuItemVor.Text = "V&orwärts";
            this.toolStripMenuItemVor.Click += new System.EventHandler(this.toolStripMenuItemVor_Click);
            // 
            // toolStripMenuItemRueck
            // 
            this.toolStripMenuItemRueck.Name = "toolStripMenuItemRueck";
            this.toolStripMenuItemRueck.Size = new System.Drawing.Size(194, 24);
            this.toolStripMenuItemRueck.Text = "&Rückwärts";
            this.toolStripMenuItemRueck.Click += new System.EventHandler(this.toolStripMenuItemRueck_Click);
            // 
            // toolStripMenuItemNeu
            // 
            this.toolStripMenuItemNeu.Name = "toolStripMenuItemNeu";
            this.toolStripMenuItemNeu.Size = new System.Drawing.Size(194, 24);
            this.toolStripMenuItemNeu.Text = "&Neu Laden";
            this.toolStripMenuItemNeu.Click += new System.EventHandler(this.toolStripMenuItemNeu_Click);
            // 
            // toolStripMenuItemAbbrechen
            // 
            this.toolStripMenuItemAbbrechen.Name = "toolStripMenuItemAbbrechen";
            this.toolStripMenuItemAbbrechen.Size = new System.Drawing.Size(194, 24);
            this.toolStripMenuItemAbbrechen.Text = "Laden &Abbrechen";
            this.toolStripMenuItemAbbrechen.Click += new System.EventHandler(this.toolStripMenuItemAbbrechen_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Checked = true;
            this.toolStripMenuItem4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemVoll,
            this.toolStripMenuItemNavigation,
            this.toolStripMenuItemLeiste});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(69, 24);
            this.toolStripMenuItem4.Text = "&Ansicht";
            // 
            // toolStripMenuItemVoll
            // 
            this.toolStripMenuItemVoll.CheckOnClick = true;
            this.toolStripMenuItemVoll.Name = "toolStripMenuItemVoll";
            this.toolStripMenuItemVoll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.V)));
            this.toolStripMenuItemVoll.Size = new System.Drawing.Size(184, 26);
            this.toolStripMenuItemVoll.Text = "&Vollbild";
            this.toolStripMenuItemVoll.Click += new System.EventHandler(this.toolStripMenuItemVoll_Click);
            // 
            // toolStripMenuItemNavigation
            // 
            this.toolStripMenuItemNavigation.Checked = true;
            this.toolStripMenuItemNavigation.CheckOnClick = true;
            this.toolStripMenuItemNavigation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemNavigation.Name = "toolStripMenuItemNavigation";
            this.toolStripMenuItemNavigation.Size = new System.Drawing.Size(184, 26);
            this.toolStripMenuItemNavigation.Text = "&Navigationsliste";
            this.toolStripMenuItemNavigation.Click += new System.EventHandler(this.toolStripMenuItemNavigation_Click);
            // 
            // toolStripMenuItemLeiste
            // 
            this.toolStripMenuItemLeiste.CheckOnClick = true;
            this.toolStripMenuItemLeiste.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdresse,
            this.toolStripMenuItemNavi2});
            this.toolStripMenuItemLeiste.Name = "toolStripMenuItemLeiste";
            this.toolStripMenuItemLeiste.Size = new System.Drawing.Size(184, 26);
            this.toolStripMenuItemLeiste.Text = "&Symbolleiste";
            // 
            // toolStripMenuItemAdresse
            // 
            this.toolStripMenuItemAdresse.Checked = true;
            this.toolStripMenuItemAdresse.CheckOnClick = true;
            this.toolStripMenuItemAdresse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemAdresse.Name = "toolStripMenuItemAdresse";
            this.toolStripMenuItemAdresse.Size = new System.Drawing.Size(151, 26);
            this.toolStripMenuItemAdresse.Text = "Ad&resse";
            this.toolStripMenuItemAdresse.Click += new System.EventHandler(this.toolStripMenuItemAdresse_Click);
            // 
            // toolStripMenuItemNavi2
            // 
            this.toolStripMenuItemNavi2.Checked = true;
            this.toolStripMenuItemNavi2.CheckOnClick = true;
            this.toolStripMenuItemNavi2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemNavi2.Name = "toolStripMenuItemNavi2";
            this.toolStripMenuItemNavi2.Size = new System.Drawing.Size(151, 26);
            this.toolStripMenuItemNavi2.Text = "Na&vigation";
            this.toolStripMenuItemNavi2.Click += new System.EventHandler(this.toolStripMenuItemNavi2_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemInfo});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(53, 24);
            this.toolStripMenuItem5.Text = "&Hilfe";
            // 
            // toolStripMenuItemInfo
            // 
            this.toolStripMenuItemInfo.Name = "toolStripMenuItemInfo";
            this.toolStripMenuItemInfo.Size = new System.Drawing.Size(104, 24);
            this.toolStripMenuItemInfo.Text = "&Info";
            this.toolStripMenuItemInfo.Click += new System.EventHandler(this.toolStripMenuItemInfo_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(996, 363);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(996, 418);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.ContextMenuStrip = this.contextMenuStripAktievieren1;
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripAdresse);
            // 
            // contextMenuStripAktievieren1
            // 
            this.contextMenuStripAktievieren1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripAktievieren1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAktivieren,
            this.toolStripMenuItem6});
            this.contextMenuStripAktievieren1.Name = "contextMenuStripAktievieren1";
            this.contextMenuStripAktievieren1.Size = new System.Drawing.Size(218, 56);
            this.contextMenuStripAktievieren1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripAktievieren1_Opening);
            // 
            // toolStripMenuItemAktivieren
            // 
            this.toolStripMenuItemAktivieren.Checked = true;
            this.toolStripMenuItemAktivieren.CheckOnClick = true;
            this.toolStripMenuItemAktivieren.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemAktivieren.Name = "toolStripMenuItemAktivieren";
            this.toolStripMenuItemAktivieren.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItemAktivieren.Text = "AdresseAktivieren";
            this.toolStripMenuItemAktivieren.Click += new System.EventHandler(this.toolStripMenuItemAktivieren_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Checked = true;
            this.toolStripMenuItem6.CheckOnClick = true;
            this.toolStripMenuItem6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(217, 26);
            this.toolStripMenuItem6.Text = "NavigationAktivieren";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ContextMenuStrip = this.contextMenuStripAktievieren1;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRueck,
            this.toolStripButtonVor,
            this.toolStripButtonNeu,
            this.toolStripButtonAbbrechen});
            this.toolStrip1.Location = new System.Drawing.Point(3, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(108, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Click += new System.EventHandler(this.toolStripMenuItemVorwaerts_Click);
            // 
            // toolStripButtonRueck
            // 
            this.toolStripButtonRueck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRueck.Enabled = false;
            this.toolStripButtonRueck.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRueck.Image")));
            this.toolStripButtonRueck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRueck.Name = "toolStripButtonRueck";
            this.toolStripButtonRueck.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonRueck.Text = "Rückwärts";
            this.toolStripButtonRueck.Click += new System.EventHandler(this.toolStripMenuItemRueckwaerts_Click);
            // 
            // toolStripButtonVor
            // 
            this.toolStripButtonVor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonVor.Enabled = false;
            this.toolStripButtonVor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonVor.Image")));
            this.toolStripButtonVor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonVor.Name = "toolStripButtonVor";
            this.toolStripButtonVor.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonVor.Text = "Vorwärts";
            // 
            // toolStripButtonNeu
            // 
            this.toolStripButtonNeu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNeu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNeu.Image")));
            this.toolStripButtonNeu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNeu.Name = "toolStripButtonNeu";
            this.toolStripButtonNeu.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonNeu.Text = "Neu Laden";
            this.toolStripButtonNeu.Click += new System.EventHandler(this.toolStripMenuItemNeuLaden_Click);
            // 
            // toolStripButtonAbbrechen
            // 
            this.toolStripButtonAbbrechen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbbrechen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbbrechen.Image")));
            this.toolStripButtonAbbrechen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbbrechen.Name = "toolStripButtonAbbrechen";
            this.toolStripButtonAbbrechen.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAbbrechen.Text = "Laden Abbrechen";
            this.toolStripButtonAbbrechen.Click += new System.EventHandler(this.toolStripMenuItemLadenabbrechen_Click);
            // 
            // toolStripAdresse
            // 
            this.toolStripAdresse.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripAdresse.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripAdresse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripButtonLosGehts});
            this.toolStripAdresse.Location = new System.Drawing.Point(111, 28);
            this.toolStripAdresse.Name = "toolStripAdresse";
            this.toolStripAdresse.Size = new System.Drawing.Size(603, 27);
            this.toolStripAdresse.TabIndex = 1;
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AcceptsReturn = true;
            this.toolStripTextBox1.AcceptsTab = true;
            this.toolStripTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.toolStripTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(450, 27);
            this.toolStripTextBox1.Text = "Geben Sie eine Adresse ein";
            this.toolStripTextBox1.Enter += new System.EventHandler(this.toolStripButtonLosGehts_Click);
            this.toolStripTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyDown);
            // 
            // toolStripButtonLosGehts
            // 
            this.toolStripButtonLosGehts.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLosGehts.Image")));
            this.toolStripButtonLosGehts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLosGehts.Name = "toolStripButtonLosGehts";
            this.toolStripButtonLosGehts.Size = new System.Drawing.Size(100, 24);
            this.toolStripButtonLosGehts.Text = "Los Geht´s";
            this.toolStripButtonLosGehts.Click += new System.EventHandler(this.toolStripButtonLosGehts_Click);
            this.toolStripButtonLosGehts.MouseEnter += new System.EventHandler(this.toolStripButtonLosGehts_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 418);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MiniWebBrowser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.contextMenuStripAktievieren1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripAdresse.ResumeLayout(false);
            this.toolStripAdresse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNavi;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRueck;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNeu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbbrechen;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStripAdresse;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonVor;
        private System.Windows.Forms.ToolStripButton toolStripButtonNeu;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbbrechen;
        private System.Windows.Forms.ToolStripButton toolStripButtonRueck;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButtonLosGehts;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNavigation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLeiste;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdresse;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNavi2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonNavigationsliste;
        private System.Windows.Forms.ToolStripButton toolStripButtonClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSort;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoeschen;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInfo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVoll;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAktievieren1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAktivieren;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    }
}

