namespace MemoryGame
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Score_label = new System.Windows.Forms.Label();
            this.Player_label = new System.Windows.Forms.Label();
            this.winner_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(39, 388);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Spela igen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(156, 388);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Huvudmeny";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(282, 388);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "Avsluta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Score_label
            // 
            this.Score_label.AutoSize = true;
            this.Score_label.BackColor = System.Drawing.Color.Transparent;
            this.Score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_label.Location = new System.Drawing.Point(321, 56);
            this.Score_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Score_label.Name = "Score_label";
            this.Score_label.Size = new System.Drawing.Size(61, 16);
            this.Score_label.TabIndex = 16;
            this.Score_label.Text = "POÄNG";
            // 
            // Player_label
            // 
            this.Player_label.AutoSize = true;
            this.Player_label.BackColor = System.Drawing.Color.Transparent;
            this.Player_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_label.Location = new System.Drawing.Point(36, 56);
            this.Player_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player_label.Name = "Player_label";
            this.Player_label.Size = new System.Drawing.Size(77, 16);
            this.Player_label.TabIndex = 18;
            this.Player_label.Text = "SPELARE";
            // 
            // winner_label
            // 
            this.winner_label.BackColor = System.Drawing.Color.Transparent;
            this.winner_label.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winner_label.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.winner_label.Location = new System.Drawing.Point(1, 9);
            this.winner_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.winner_label.Name = "winner_label";
            this.winner_label.Size = new System.Drawing.Size(426, 30);
            this.winner_label.TabIndex = 28;
            this.winner_label.Text = "Spelare X vann!!";
            this.winner_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(426, 427);
            this.ControlBox = false;
            this.Controls.Add(this.winner_label);
            this.Controls.Add(this.Player_label);
            this.Controls.Add(this.Score_label);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Score_label;
        private System.Windows.Forms.Label Player_label;
        private System.Windows.Forms.Label winner_label;
    }
}