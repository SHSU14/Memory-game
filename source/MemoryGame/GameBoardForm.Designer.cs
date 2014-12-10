using System.Linq;

namespace MemoryGame
{
    partial class GameBoardForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startaOmSpeletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjälpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instruktionerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omMemorySpelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.hjälpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyttToolStripMenuItem,
            this.startaOmSpeletToolStripMenuItem,
            this.avslutaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fileToolStripMenuItem.Text = "&Arkiv";
            // 
            // nyttToolStripMenuItem
            // 
            this.nyttToolStripMenuItem.Name = "nyttToolStripMenuItem";
            this.nyttToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.nyttToolStripMenuItem.Text = "&Nytt Spel";
            this.nyttToolStripMenuItem.Click += new System.EventHandler(this.nyttToolStripMenuItem_Click);
            // 
            // startaOmSpeletToolStripMenuItem
            // 
            this.startaOmSpeletToolStripMenuItem.Name = "startaOmSpeletToolStripMenuItem";
            this.startaOmSpeletToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.startaOmSpeletToolStripMenuItem.Text = "&Starta om Spelet";
            this.startaOmSpeletToolStripMenuItem.Click += new System.EventHandler(this.startaOmSpeletToolStripMenuItem_Click);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.avslutaToolStripMenuItem.Text = "&Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // hjälpToolStripMenuItem
            // 
            this.hjälpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instruktionerToolStripMenuItem,
            this.omMemorySpelToolStripMenuItem});
            this.hjälpToolStripMenuItem.Name = "hjälpToolStripMenuItem";
            this.hjälpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hjälpToolStripMenuItem.Text = "&Hjälp";
            // 
            // instruktionerToolStripMenuItem
            // 
            this.instruktionerToolStripMenuItem.Name = "instruktionerToolStripMenuItem";
            this.instruktionerToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.instruktionerToolStripMenuItem.Text = "Instruktioner och regler";
            this.instruktionerToolStripMenuItem.Click += new System.EventHandler(this.instruktionerToolStripMenuItem_Click);
            // 
            // omMemorySpelToolStripMenuItem
            // 
            this.omMemorySpelToolStripMenuItem.Name = "omMemorySpelToolStripMenuItem";
            this.omMemorySpelToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.omMemorySpelToolStripMenuItem.Text = "Om Memory Spel";
            this.omMemorySpelToolStripMenuItem.Click += new System.EventHandler(this.omMemorySpelToolStripMenuItem_Click);
            // 
            // GameBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(660, 460);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameBoardForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyttToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startaOmSpeletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjälpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instruktionerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omMemorySpelToolStripMenuItem;
    }
}