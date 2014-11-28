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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoardForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nyttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startaOmSpeletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Player1Pointslabel = new System.Windows.Forms.Label();
            this.Player2Pointslabel = new System.Windows.Forms.Label();
            this.Player10Pointslabel = new System.Windows.Forms.Label();
            this.Player3Pointslabel = new System.Windows.Forms.Label();
            this.Player4Pointslabel = new System.Windows.Forms.Label();
            this.Player5Pointslabel = new System.Windows.Forms.Label();
            this.Player6Pointslabel = new System.Windows.Forms.Label();
            this.Player7Pointslabel = new System.Windows.Forms.Label();
            this.Player8Pointslabel = new System.Windows.Forms.Label();
            this.Player9Pointslabel = new System.Windows.Forms.Label();
            this.CurrentGametimelabel = new System.Windows.Forms.Label();
            this.memoryCardControl1 = new MemoryGame.MemoryCardControl();
            this.memoryCardControl2 = new MemoryGame.MemoryCardControl();
            this.memoryCardControl3 = new MemoryGame.MemoryCardControl();
            this.memoryCardControl4 = new MemoryGame.MemoryCardControl();
            this.memoryCardControl5 = new MemoryGame.MemoryCardControl();
            this.memoryCardControl6 = new MemoryGame.MemoryCardControl();
            this.memoryCardControl7 = new MemoryGame.MemoryCardControl();
            this.memoryCardControl8 = new MemoryGame.MemoryCardControl();
            this.memoryCardControl9 = new MemoryGame.MemoryCardControl();
            this.memoryCardControl10 = new MemoryGame.MemoryCardControl();
            this.memoryCardControl11 = new MemoryGame.MemoryCardControl();
            this.memoryCardControl12 = new MemoryGame.MemoryCardControl();
            this.btnDone = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl12)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(880, 28);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.fileToolStripMenuItem.Text = "&Arkiv";
            // 
            // nyttToolStripMenuItem
            // 
            this.nyttToolStripMenuItem.Name = "nyttToolStripMenuItem";
            this.nyttToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.nyttToolStripMenuItem.Text = "&Nytt Spel";
            this.nyttToolStripMenuItem.Click += new System.EventHandler(this.nyttToolStripMenuItem_Click);
            // 
            // startaOmSpeletToolStripMenuItem
            // 
            this.startaOmSpeletToolStripMenuItem.Name = "startaOmSpeletToolStripMenuItem";
            this.startaOmSpeletToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.startaOmSpeletToolStripMenuItem.Text = "&Starta om Spelet";
            this.startaOmSpeletToolStripMenuItem.Click += new System.EventHandler(this.startaOmSpeletToolStripMenuItem_Click);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.avslutaToolStripMenuItem.Text = "&Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaToolStripMenuItem_Click);
            // 
            // Player1Pointslabel
            // 
            this.Player1Pointslabel.AutoSize = true;
            this.Player1Pointslabel.Location = new System.Drawing.Point(773, 103);
            this.Player1Pointslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player1Pointslabel.Name = "Player1Pointslabel";
            this.Player1Pointslabel.Size = new System.Drawing.Size(69, 17);
            this.Player1Pointslabel.TabIndex = 1;
            this.Player1Pointslabel.Text = "Spelare 1";
            // 
            // Player2Pointslabel
            // 
            this.Player2Pointslabel.AutoSize = true;
            this.Player2Pointslabel.Location = new System.Drawing.Point(773, 123);
            this.Player2Pointslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player2Pointslabel.Name = "Player2Pointslabel";
            this.Player2Pointslabel.Size = new System.Drawing.Size(69, 17);
            this.Player2Pointslabel.TabIndex = 2;
            this.Player2Pointslabel.Text = "Spelare 2";
            // 
            // Player10Pointslabel
            // 
            this.Player10Pointslabel.AutoSize = true;
            this.Player10Pointslabel.Location = new System.Drawing.Point(773, 310);
            this.Player10Pointslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player10Pointslabel.Name = "Player10Pointslabel";
            this.Player10Pointslabel.Size = new System.Drawing.Size(77, 17);
            this.Player10Pointslabel.TabIndex = 3;
            this.Player10Pointslabel.Text = "Spelare 10";
            // 
            // Player3Pointslabel
            // 
            this.Player3Pointslabel.AutoSize = true;
            this.Player3Pointslabel.Location = new System.Drawing.Point(773, 148);
            this.Player3Pointslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player3Pointslabel.Name = "Player3Pointslabel";
            this.Player3Pointslabel.Size = new System.Drawing.Size(69, 17);
            this.Player3Pointslabel.TabIndex = 4;
            this.Player3Pointslabel.Text = "Spelare 3";
            // 
            // Player4Pointslabel
            // 
            this.Player4Pointslabel.AutoSize = true;
            this.Player4Pointslabel.Location = new System.Drawing.Point(773, 172);
            this.Player4Pointslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player4Pointslabel.Name = "Player4Pointslabel";
            this.Player4Pointslabel.Size = new System.Drawing.Size(69, 17);
            this.Player4Pointslabel.TabIndex = 5;
            this.Player4Pointslabel.Text = "Spelare 4";
            // 
            // Player5Pointslabel
            // 
            this.Player5Pointslabel.AutoSize = true;
            this.Player5Pointslabel.Location = new System.Drawing.Point(773, 197);
            this.Player5Pointslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player5Pointslabel.Name = "Player5Pointslabel";
            this.Player5Pointslabel.Size = new System.Drawing.Size(69, 17);
            this.Player5Pointslabel.TabIndex = 6;
            this.Player5Pointslabel.Text = "Spelare 5";
            // 
            // Player6Pointslabel
            // 
            this.Player6Pointslabel.AutoSize = true;
            this.Player6Pointslabel.Location = new System.Drawing.Point(773, 217);
            this.Player6Pointslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player6Pointslabel.Name = "Player6Pointslabel";
            this.Player6Pointslabel.Size = new System.Drawing.Size(69, 17);
            this.Player6Pointslabel.TabIndex = 7;
            this.Player6Pointslabel.Text = "Spelare 6";
            // 
            // Player7Pointslabel
            // 
            this.Player7Pointslabel.AutoSize = true;
            this.Player7Pointslabel.Location = new System.Drawing.Point(773, 241);
            this.Player7Pointslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player7Pointslabel.Name = "Player7Pointslabel";
            this.Player7Pointslabel.Size = new System.Drawing.Size(69, 17);
            this.Player7Pointslabel.TabIndex = 8;
            this.Player7Pointslabel.Text = "Spelare 7";
            // 
            // Player8Pointslabel
            // 
            this.Player8Pointslabel.AutoSize = true;
            this.Player8Pointslabel.Location = new System.Drawing.Point(773, 266);
            this.Player8Pointslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player8Pointslabel.Name = "Player8Pointslabel";
            this.Player8Pointslabel.Size = new System.Drawing.Size(69, 17);
            this.Player8Pointslabel.TabIndex = 9;
            this.Player8Pointslabel.Text = "Spelare 8";
            // 
            // Player9Pointslabel
            // 
            this.Player9Pointslabel.AutoSize = true;
            this.Player9Pointslabel.Location = new System.Drawing.Point(773, 290);
            this.Player9Pointslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player9Pointslabel.Name = "Player9Pointslabel";
            this.Player9Pointslabel.Size = new System.Drawing.Size(69, 17);
            this.Player9Pointslabel.TabIndex = 10;
            this.Player9Pointslabel.Text = "Spelare 9";
            // 
            // CurrentGametimelabel
            // 
            this.CurrentGametimelabel.AutoSize = true;
            this.CurrentGametimelabel.Location = new System.Drawing.Point(773, 44);
            this.CurrentGametimelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentGametimelabel.Name = "CurrentGametimelabel";
            this.CurrentGametimelabel.Size = new System.Drawing.Size(75, 17);
            this.CurrentGametimelabel.TabIndex = 12;
            this.CurrentGametimelabel.Text = "Betänketid";
            // 
            // memoryCardControl1
            // 
            this.memoryCardControl1.Image = ((System.Drawing.Image)(resources.GetObject("memoryCardControl1.Image")));
            this.memoryCardControl1.Location = new System.Drawing.Point(25, 29);
            this.memoryCardControl1.Name = "memoryCardControl1";
            this.memoryCardControl1.Size = new System.Drawing.Size(160, 160);
            this.memoryCardControl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.memoryCardControl1.TabIndex = 13;
            this.memoryCardControl1.TabStop = false;
            // 
            // memoryCardControl2
            // 
            this.memoryCardControl2.Image = ((System.Drawing.Image)(resources.GetObject("memoryCardControl2.Image")));
            this.memoryCardControl2.Location = new System.Drawing.Point(200, 29);
            this.memoryCardControl2.Name = "memoryCardControl2";
            this.memoryCardControl2.Size = new System.Drawing.Size(160, 160);
            this.memoryCardControl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.memoryCardControl2.TabIndex = 14;
            this.memoryCardControl2.TabStop = false;
            // 
            // memoryCardControl3
            // 
            this.memoryCardControl3.Image = ((System.Drawing.Image)(resources.GetObject("memoryCardControl3.Image")));
            this.memoryCardControl3.Location = new System.Drawing.Point(380, 29);
            this.memoryCardControl3.Name = "memoryCardControl3";
            this.memoryCardControl3.Size = new System.Drawing.Size(160, 160);
            this.memoryCardControl3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.memoryCardControl3.TabIndex = 15;
            this.memoryCardControl3.TabStop = false;
            // 
            // memoryCardControl4
            // 
            this.memoryCardControl4.Image = ((System.Drawing.Image)(resources.GetObject("memoryCardControl4.Image")));
            this.memoryCardControl4.Location = new System.Drawing.Point(567, 29);
            this.memoryCardControl4.Name = "memoryCardControl4";
            this.memoryCardControl4.Size = new System.Drawing.Size(160, 160);
            this.memoryCardControl4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.memoryCardControl4.TabIndex = 16;
            this.memoryCardControl4.TabStop = false;
            // 
            // memoryCardControl5
            // 
            this.memoryCardControl5.Image = ((System.Drawing.Image)(resources.GetObject("memoryCardControl5.Image")));
            this.memoryCardControl5.Location = new System.Drawing.Point(25, 206);
            this.memoryCardControl5.Name = "memoryCardControl5";
            this.memoryCardControl5.Size = new System.Drawing.Size(160, 160);
            this.memoryCardControl5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.memoryCardControl5.TabIndex = 17;
            this.memoryCardControl5.TabStop = false;
            // 
            // memoryCardControl6
            // 
            this.memoryCardControl6.Image = ((System.Drawing.Image)(resources.GetObject("memoryCardControl6.Image")));
            this.memoryCardControl6.Location = new System.Drawing.Point(200, 206);
            this.memoryCardControl6.Name = "memoryCardControl6";
            this.memoryCardControl6.Size = new System.Drawing.Size(160, 160);
            this.memoryCardControl6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.memoryCardControl6.TabIndex = 18;
            this.memoryCardControl6.TabStop = false;
            // 
            // memoryCardControl7
            // 
            this.memoryCardControl7.Image = ((System.Drawing.Image)(resources.GetObject("memoryCardControl7.Image")));
            this.memoryCardControl7.Location = new System.Drawing.Point(380, 206);
            this.memoryCardControl7.Name = "memoryCardControl7";
            this.memoryCardControl7.Size = new System.Drawing.Size(160, 160);
            this.memoryCardControl7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.memoryCardControl7.TabIndex = 19;
            this.memoryCardControl7.TabStop = false;
            // 
            // memoryCardControl8
            // 
            this.memoryCardControl8.Image = ((System.Drawing.Image)(resources.GetObject("memoryCardControl8.Image")));
            this.memoryCardControl8.Location = new System.Drawing.Point(567, 206);
            this.memoryCardControl8.Name = "memoryCardControl8";
            this.memoryCardControl8.Size = new System.Drawing.Size(160, 160);
            this.memoryCardControl8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.memoryCardControl8.TabIndex = 20;
            this.memoryCardControl8.TabStop = false;
            // 
            // memoryCardControl9
            // 
            this.memoryCardControl9.Image = ((System.Drawing.Image)(resources.GetObject("memoryCardControl9.Image")));
            this.memoryCardControl9.Location = new System.Drawing.Point(25, 386);
            this.memoryCardControl9.Name = "memoryCardControl9";
            this.memoryCardControl9.Size = new System.Drawing.Size(160, 160);
            this.memoryCardControl9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.memoryCardControl9.TabIndex = 21;
            this.memoryCardControl9.TabStop = false;
            // 
            // memoryCardControl10
            // 
            this.memoryCardControl10.Image = ((System.Drawing.Image)(resources.GetObject("memoryCardControl10.Image")));
            this.memoryCardControl10.Location = new System.Drawing.Point(200, 386);
            this.memoryCardControl10.Name = "memoryCardControl10";
            this.memoryCardControl10.Size = new System.Drawing.Size(160, 160);
            this.memoryCardControl10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.memoryCardControl10.TabIndex = 22;
            this.memoryCardControl10.TabStop = false;
            // 
            // memoryCardControl11
            // 
            this.memoryCardControl11.Image = ((System.Drawing.Image)(resources.GetObject("memoryCardControl11.Image")));
            this.memoryCardControl11.Location = new System.Drawing.Point(380, 386);
            this.memoryCardControl11.Name = "memoryCardControl11";
            this.memoryCardControl11.Size = new System.Drawing.Size(160, 160);
            this.memoryCardControl11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.memoryCardControl11.TabIndex = 23;
            this.memoryCardControl11.TabStop = false;
            // 
            // memoryCardControl12
            // 
            this.memoryCardControl12.Image = ((System.Drawing.Image)(resources.GetObject("memoryCardControl12.Image")));
            this.memoryCardControl12.Location = new System.Drawing.Point(567, 386);
            this.memoryCardControl12.Name = "memoryCardControl12";
            this.memoryCardControl12.Size = new System.Drawing.Size(160, 160);
            this.memoryCardControl12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.memoryCardControl12.TabIndex = 24;
            this.memoryCardControl12.TabStop = false;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(759, 520);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(91, 26);
            this.btnDone.TabIndex = 25;
            this.btnDone.Text = "Klar";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // GameBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 566);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.memoryCardControl12);
            this.Controls.Add(this.memoryCardControl11);
            this.Controls.Add(this.memoryCardControl10);
            this.Controls.Add(this.memoryCardControl9);
            this.Controls.Add(this.memoryCardControl8);
            this.Controls.Add(this.memoryCardControl7);
            this.Controls.Add(this.memoryCardControl6);
            this.Controls.Add(this.memoryCardControl5);
            this.Controls.Add(this.memoryCardControl4);
            this.Controls.Add(this.memoryCardControl3);
            this.Controls.Add(this.memoryCardControl2);
            this.Controls.Add(this.memoryCardControl1);
            this.Controls.Add(this.CurrentGametimelabel);
            this.Controls.Add(this.Player9Pointslabel);
            this.Controls.Add(this.Player8Pointslabel);
            this.Controls.Add(this.Player7Pointslabel);
            this.Controls.Add(this.Player6Pointslabel);
            this.Controls.Add(this.Player5Pointslabel);
            this.Controls.Add(this.Player4Pointslabel);
            this.Controls.Add(this.Player3Pointslabel);
            this.Controls.Add(this.Player10Pointslabel);
            this.Controls.Add(this.Player2Pointslabel);
            this.Controls.Add(this.Player1Pointslabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameBoardForm";
            this.Text = "GameBoardForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nyttToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startaOmSpeletToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.Label Player1Pointslabel;
        private System.Windows.Forms.Label Player2Pointslabel;
        private System.Windows.Forms.Label Player10Pointslabel;
        private System.Windows.Forms.Label Player3Pointslabel;
        private System.Windows.Forms.Label Player4Pointslabel;
        private System.Windows.Forms.Label Player5Pointslabel;
        private System.Windows.Forms.Label Player6Pointslabel;
        private System.Windows.Forms.Label Player7Pointslabel;
        private System.Windows.Forms.Label Player8Pointslabel;
        private System.Windows.Forms.Label Player9Pointslabel;
        private System.Windows.Forms.Label CurrentGametimelabel;
        private MemoryCardControl memoryCardControl1;
        private MemoryCardControl memoryCardControl2;
        private MemoryCardControl memoryCardControl3;
        private MemoryCardControl memoryCardControl4;
        private MemoryCardControl memoryCardControl5;
        private MemoryCardControl memoryCardControl6;
        private MemoryCardControl memoryCardControl7;
        private MemoryCardControl memoryCardControl8;
        private MemoryCardControl memoryCardControl9;
        private MemoryCardControl memoryCardControl10;
        private MemoryCardControl memoryCardControl11;
        private MemoryCardControl memoryCardControl12;
        private System.Windows.Forms.Button btnDone;
    }
}