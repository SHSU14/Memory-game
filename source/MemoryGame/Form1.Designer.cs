namespace MemoryGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.memoryCardControl3 = new MemoryGame.MemoryCardControl();
            this.memoryCardControl2 = new MemoryGame.MemoryCardControl();
            this.memoryCardControl1 = new MemoryGame.MemoryCardControl();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // memoryCardControl3
            // 
            this.memoryCardControl3.Image = ((System.Drawing.Image)(resources.GetObject("memoryCardControl3.Image")));
            this.memoryCardControl3.Location = new System.Drawing.Point(450, 55);
            this.memoryCardControl3.Name = "memoryCardControl3";
            this.memoryCardControl3.Size = new System.Drawing.Size(160, 160);
            this.memoryCardControl3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.memoryCardControl3.TabIndex = 2;
            this.memoryCardControl3.TabStop = false;
           
            // 
            // memoryCardControl2
            // 
            this.memoryCardControl2.Image = ((System.Drawing.Image)(resources.GetObject("memoryCardControl2.Image")));
            this.memoryCardControl2.Location = new System.Drawing.Point(247, 55);
            this.memoryCardControl2.Name = "memoryCardControl2";
            this.memoryCardControl2.Size = new System.Drawing.Size(160, 160);
            this.memoryCardControl2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.memoryCardControl2.TabIndex = 1;
            this.memoryCardControl2.TabStop = false;
            // 
            // memoryCardControl1
            // 
            this.memoryCardControl1.Image = ((System.Drawing.Image)(resources.GetObject("memoryCardControl1.Image")));
            this.memoryCardControl1.Location = new System.Drawing.Point(51, 55);
            this.memoryCardControl1.Name = "memoryCardControl1";
            this.memoryCardControl1.Size = new System.Drawing.Size(160, 160);
            this.memoryCardControl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.memoryCardControl1.TabIndex = 0;
            this.memoryCardControl1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 540);
            this.Controls.Add(this.memoryCardControl3);
            this.Controls.Add(this.memoryCardControl2);
            this.Controls.Add(this.memoryCardControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoryCardControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private MemoryCardControl memoryCardControl1;
        private MemoryCardControl memoryCardControl2;
        private MemoryCardControl memoryCardControl3;
    }
}

