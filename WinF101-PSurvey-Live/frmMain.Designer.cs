namespace WinF101_PSurvey_Live
{
    partial class frmMain
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
            menuPSurvey = new MenuStrip();
            programToolStripMenuItem = new ToolStripMenuItem();
            kullanıcıKayıtToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            anketCevaplaToolStripMenuItem = new ToolStripMenuItem();
            menuPSurvey.SuspendLayout();
            SuspendLayout();
            // 
            // menuPSurvey
            // 
            menuPSurvey.Items.AddRange(new ToolStripItem[] { programToolStripMenuItem });
            menuPSurvey.Location = new Point(0, 0);
            menuPSurvey.Name = "menuPSurvey";
            menuPSurvey.Size = new Size(800, 24);
            menuPSurvey.TabIndex = 0;
            menuPSurvey.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            programToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kullanıcıKayıtToolStripMenuItem, anketCevaplaToolStripMenuItem, toolStripSeparator1, çıkışToolStripMenuItem });
            programToolStripMenuItem.Name = "programToolStripMenuItem";
            programToolStripMenuItem.Size = new Size(65, 20);
            programToolStripMenuItem.Text = "Program";
            // 
            // kullanıcıKayıtToolStripMenuItem
            // 
            kullanıcıKayıtToolStripMenuItem.Name = "kullanıcıKayıtToolStripMenuItem";
            kullanıcıKayıtToolStripMenuItem.Size = new Size(150, 22);
            kullanıcıKayıtToolStripMenuItem.Text = "Kullanıcı Kayıt";
            kullanıcıKayıtToolStripMenuItem.Click += kullanıcıKayıtToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(147, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(150, 22);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // anketCevaplaToolStripMenuItem
            // 
            anketCevaplaToolStripMenuItem.Name = "anketCevaplaToolStripMenuItem";
            anketCevaplaToolStripMenuItem.Size = new Size(180, 22);
            anketCevaplaToolStripMenuItem.Text = "Anket Cevapla";
            anketCevaplaToolStripMenuItem.Click += anketCevaplaToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(menuPSurvey);
            MainMenuStrip = menuPSurvey;
            Name = "frmMain";
            Text = "PSurvey Desktop v1.0";
            WindowState = FormWindowState.Maximized;
            menuPSurvey.ResumeLayout(false);
            menuPSurvey.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPSurvey;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem kullanıcıKayıtToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem anketCevaplaToolStripMenuItem;
    }
}