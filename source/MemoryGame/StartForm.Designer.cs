namespace MemoryGame
{
    partial class StartForm
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
            this.rBtn_level2 = new System.Windows.Forms.RadioButton();
            this.rBtn_level3 = new System.Windows.Forms.RadioButton();
            this.rBtn_level1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_sec2 = new System.Windows.Forms.NumericUpDown();
            this.nud_sec1 = new System.Windows.Forms.NumericUpDown();
            this.nud_Spelplan = new System.Windows.Forms.NumericUpDown();
            this.cmb_spelare = new System.Windows.Forms.ComboBox();
            this.cmb_AI = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_starta = new System.Windows.Forms.Button();
            this.rBtn_tema1 = new System.Windows.Forms.RadioButton();
            this.rBtn_tema3 = new System.Windows.Forms.RadioButton();
            this.rBtn_tema2 = new System.Windows.Forms.RadioButton();
            this.Tema = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sec2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sec1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Spelplan)).BeginInit();
            this.SuspendLayout();
            // 
            // rBtn_level2
            // 
            this.rBtn_level2.AutoSize = true;
            this.rBtn_level2.Location = new System.Drawing.Point(592, 248);
            this.rBtn_level2.Name = "rBtn_level2";
            this.rBtn_level2.Size = new System.Drawing.Size(104, 29);
            this.rBtn_level2.TabIndex = 25;
            this.rBtn_level2.TabStop = true;
            this.rBtn_level2.Text = "Nivå 2";
            this.rBtn_level2.UseVisualStyleBackColor = true;
            // 
            // rBtn_level3
            // 
            this.rBtn_level3.AutoSize = true;
            this.rBtn_level3.Location = new System.Drawing.Point(704, 248);
            this.rBtn_level3.Name = "rBtn_level3";
            this.rBtn_level3.Size = new System.Drawing.Size(104, 29);
            this.rBtn_level3.TabIndex = 24;
            this.rBtn_level3.TabStop = true;
            this.rBtn_level3.Text = "Nivå 3";
            this.rBtn_level3.UseVisualStyleBackColor = true;
            // 
            // rBtn_level1
            // 
            this.rBtn_level1.AutoSize = true;
            this.rBtn_level1.Location = new System.Drawing.Point(472, 248);
            this.rBtn_level1.Name = "rBtn_level1";
            this.rBtn_level1.Size = new System.Drawing.Size(104, 29);
            this.rBtn_level1.TabIndex = 23;
            this.rBtn_level1.TabStop = true;
            this.rBtn_level1.Text = "Nivå 1";
            this.rBtn_level1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Sekunder 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Sekunder:";
            // 
            // nud_sec2
            // 
            this.nud_sec2.Location = new System.Drawing.Point(472, 480);
            this.nud_sec2.Name = "nud_sec2";
            this.nud_sec2.Size = new System.Drawing.Size(200, 31);
            this.nud_sec2.TabIndex = 20;
            // 
            // nud_sec1
            // 
            this.nud_sec1.Location = new System.Drawing.Point(472, 432);
            this.nud_sec1.Name = "nud_sec1";
            this.nud_sec1.Size = new System.Drawing.Size(200, 31);
            this.nud_sec1.TabIndex = 19;
            // 
            // nud_Spelplan
            // 
            this.nud_Spelplan.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_Spelplan.Location = new System.Drawing.Point(472, 304);
            this.nud_Spelplan.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nud_Spelplan.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nud_Spelplan.Name = "nud_Spelplan";
            this.nud_Spelplan.Size = new System.Drawing.Size(200, 31);
            this.nud_Spelplan.TabIndex = 18;
            this.nud_Spelplan.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // cmb_spelare
            // 
            this.cmb_spelare.FormattingEnabled = true;
            this.cmb_spelare.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_spelare.Location = new System.Drawing.Point(472, 96);
            this.cmb_spelare.Name = "cmb_spelare";
            this.cmb_spelare.Size = new System.Drawing.Size(200, 33);
            this.cmb_spelare.TabIndex = 17;
            this.cmb_spelare.Text = "0 - 10";
            // 
            // cmb_AI
            // 
            this.cmb_AI.FormattingEnabled = true;
            this.cmb_AI.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_AI.Location = new System.Drawing.Point(472, 176);
            this.cmb_AI.Name = "cmb_AI";
            this.cmb_AI.Size = new System.Drawing.Size(200, 33);
            this.cmb_AI.TabIndex = 16;
            this.cmb_AI.Text = "0 - 10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Spelplan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "AI Spelare:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Spelare:";
            // 
            // btn_starta
            // 
            this.btn_starta.Location = new System.Drawing.Point(472, 560);
            this.btn_starta.Name = "btn_starta";
            this.btn_starta.Size = new System.Drawing.Size(200, 64);
            this.btn_starta.TabIndex = 26;
            this.btn_starta.Text = "Starta";
            this.btn_starta.UseVisualStyleBackColor = true;
            // 
            // rBtn_tema1
            // 
            this.rBtn_tema1.AutoSize = true;
            this.rBtn_tema1.Location = new System.Drawing.Point(464, 376);
            this.rBtn_tema1.Name = "rBtn_tema1";
            this.rBtn_tema1.Size = new System.Drawing.Size(109, 29);
            this.rBtn_tema1.TabIndex = 27;
            this.rBtn_tema1.TabStop = true;
            this.rBtn_tema1.Text = "Tema1";
            this.rBtn_tema1.UseVisualStyleBackColor = true;
            // 
            // rBtn_tema3
            // 
            this.rBtn_tema3.AutoSize = true;
            this.rBtn_tema3.Location = new System.Drawing.Point(688, 376);
            this.rBtn_tema3.Name = "rBtn_tema3";
            this.rBtn_tema3.Size = new System.Drawing.Size(109, 29);
            this.rBtn_tema3.TabIndex = 28;
            this.rBtn_tema3.TabStop = true;
            this.rBtn_tema3.Text = "Tema3";
            this.rBtn_tema3.UseVisualStyleBackColor = true;
            // 
            // rBtn_tema2
            // 
            this.rBtn_tema2.AutoSize = true;
            this.rBtn_tema2.Location = new System.Drawing.Point(576, 376);
            this.rBtn_tema2.Name = "rBtn_tema2";
            this.rBtn_tema2.Size = new System.Drawing.Size(109, 29);
            this.rBtn_tema2.TabIndex = 29;
            this.rBtn_tema2.TabStop = true;
            this.rBtn_tema2.Text = "Tema2";
            this.rBtn_tema2.UseVisualStyleBackColor = true;
            // 
            // Tema
            // 
            this.Tema.AutoSize = true;
            this.Tema.Location = new System.Drawing.Point(312, 376);
            this.Tema.Name = "Tema";
            this.Tema.Size = new System.Drawing.Size(72, 25);
            this.Tema.TabIndex = 30;
            this.Tema.Text = "Tema:";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 717);
            this.Controls.Add(this.Tema);
            this.Controls.Add(this.rBtn_tema2);
            this.Controls.Add(this.rBtn_tema3);
            this.Controls.Add(this.rBtn_tema1);
            this.Controls.Add(this.btn_starta);
            this.Controls.Add(this.rBtn_level2);
            this.Controls.Add(this.rBtn_level3);
            this.Controls.Add(this.rBtn_level1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nud_sec2);
            this.Controls.Add(this.nud_sec1);
            this.Controls.Add(this.nud_Spelplan);
            this.Controls.Add(this.cmb_spelare);
            this.Controls.Add(this.cmb_AI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StartForm";
            this.Text = "Memory Spel";
            ((System.ComponentModel.ISupportInitialize)(this.nud_sec2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sec1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Spelplan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBtn_level2;
        private System.Windows.Forms.RadioButton rBtn_level3;
        private System.Windows.Forms.RadioButton rBtn_level1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_sec2;
        private System.Windows.Forms.NumericUpDown nud_sec1;
        private System.Windows.Forms.NumericUpDown nud_Spelplan;
        private System.Windows.Forms.ComboBox cmb_spelare;
        private System.Windows.Forms.ComboBox cmb_AI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_starta;
        private System.Windows.Forms.RadioButton rBtn_tema1;
        private System.Windows.Forms.RadioButton rBtn_tema3;
        private System.Windows.Forms.RadioButton rBtn_tema2;
        private System.Windows.Forms.Label Tema;
    }
}