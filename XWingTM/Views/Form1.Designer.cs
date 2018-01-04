namespace XWingTM
{
    partial class torunamentManager
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
            this.menuStrip = new System.Windows.Forms.ToolStrip();
            this.playerMenuStrip = new System.Windows.Forms.ToolStripButton();
            this.tournamentMenuStrip = new System.Windows.Forms.ToolStripButton();
            this.reportMenuStrip = new System.Windows.Forms.ToolStripButton();
            this.exitMenuStrip = new System.Windows.Forms.ToolStripButton();
            this.infoMenuStrip = new System.Windows.Forms.ToolStripButton();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerMenuStrip,
            this.tournamentMenuStrip,
            this.reportMenuStrip,
            this.exitMenuStrip,
            this.infoMenuStrip});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1008, 55);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "toolStrip1";
            // 
            // playerMenuStrip
            // 
            this.playerMenuStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playerMenuStrip.Image = global::XWingTM.Properties.Resources.players;
            this.playerMenuStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playerMenuStrip.Name = "playerMenuStrip";
            this.playerMenuStrip.Size = new System.Drawing.Size(52, 52);
            this.playerMenuStrip.Text = "Manage Players";
            this.playerMenuStrip.Click += new System.EventHandler(this.playerMenuStrip_Click);
            // 
            // tournamentMenuStrip
            // 
            this.tournamentMenuStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tournamentMenuStrip.Image = global::XWingTM.Properties.Resources.tournament;
            this.tournamentMenuStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tournamentMenuStrip.Name = "tournamentMenuStrip";
            this.tournamentMenuStrip.Size = new System.Drawing.Size(52, 52);
            this.tournamentMenuStrip.Text = "Manage Tournaments";
            this.tournamentMenuStrip.Click += new System.EventHandler(this.tournamentMenuStrip_Click);
            // 
            // reportMenuStrip
            // 
            this.reportMenuStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reportMenuStrip.Image = global::XWingTM.Properties.Resources.print;
            this.reportMenuStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reportMenuStrip.Name = "reportMenuStrip";
            this.reportMenuStrip.Size = new System.Drawing.Size(52, 52);
            this.reportMenuStrip.Text = "Print reports";
            this.reportMenuStrip.Click += new System.EventHandler(this.reportMenuStrip_Click);
            // 
            // exitMenuStrip
            // 
            this.exitMenuStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitMenuStrip.Image = global::XWingTM.Properties.Resources.exit;
            this.exitMenuStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitMenuStrip.Margin = new System.Windows.Forms.Padding(710, 1, 0, 2);
            this.exitMenuStrip.Name = "exitMenuStrip";
            this.exitMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitMenuStrip.Size = new System.Drawing.Size(52, 52);
            this.exitMenuStrip.Text = "Exit";
            this.exitMenuStrip.Click += new System.EventHandler(this.exitMenuStrip_Click);
            // 
            // infoMenuStrip
            // 
            this.infoMenuStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.infoMenuStrip.Image = global::XWingTM.Properties.Resources.info;
            this.infoMenuStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infoMenuStrip.Name = "infoMenuStrip";
            this.infoMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.infoMenuStrip.Size = new System.Drawing.Size(52, 52);
            this.infoMenuStrip.Text = "Info & Credits";
            this.infoMenuStrip.Click += new System.EventHandler(this.infoMenuStrip_Click);
            // 
            // torunamentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.menuStrip);
            this.Name = "torunamentManager";
            this.Text = "Tournament Manager";
            this.Load += new System.EventHandler(this.torunamentManager_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menuStrip;
        private System.Windows.Forms.ToolStripButton playerMenuStrip;
        private System.Windows.Forms.ToolStripButton tournamentMenuStrip;
        private System.Windows.Forms.ToolStripButton reportMenuStrip;
        private System.Windows.Forms.ToolStripButton exitMenuStrip;
        private System.Windows.Forms.ToolStripButton infoMenuStrip;

    }
}

