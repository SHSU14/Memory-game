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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_ShowCardTimer = new System.Windows.Forms.NumericUpDown();
            this.nud_PlayerTurnTimer = new System.Windows.Forms.NumericUpDown();
            this.num_Cardnumber = new System.Windows.Forms.NumericUpDown();
            this.cmb_spelare = new System.Windows.Forms.ComboBox();
            this.cmb_AI = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_starta = new System.Windows.Forms.Button();
            this.Tema = new System.Windows.Forms.Label();
            this.cmb_Level = new System.Windows.Forms.ComboBox();
            this.cmb_Themes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ShowCardTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PlayerTurnTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Cardnumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Visningstid (sec):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Betänketid (sec):";
            // 
            // nud_ShowCardTimer
            // 
            this.nud_ShowCardTimer.Location = new System.Drawing.Point(195, 234);
            this.nud_ShowCardTimer.Margin = new System.Windows.Forms.Padding(2);
            this.nud_ShowCardTimer.Name = "nud_ShowCardTimer";
            this.nud_ShowCardTimer.Size = new System.Drawing.Size(53, 23);
            this.nud_ShowCardTimer.TabIndex = 20;
            this.nud_ShowCardTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_PlayerTurnTimer
            // 
            this.nud_PlayerTurnTimer.Location = new System.Drawing.Point(195, 209);
            this.nud_PlayerTurnTimer.Margin = new System.Windows.Forms.Padding(2);
            this.nud_PlayerTurnTimer.Name = "nud_PlayerTurnTimer";
            this.nud_PlayerTurnTimer.Size = new System.Drawing.Size(53, 23);
            this.nud_PlayerTurnTimer.TabIndex = 19;
            this.nud_PlayerTurnTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_Cardnumber
            // 
            this.num_Cardnumber.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.num_Cardnumber.Location = new System.Drawing.Point(159, 142);
            this.num_Cardnumber.Margin = new System.Windows.Forms.Padding(2);
            this.num_Cardnumber.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.num_Cardnumber.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.num_Cardnumber.Name = "num_Cardnumber";
            this.num_Cardnumber.Size = new System.Drawing.Size(49, 23);
            this.num_Cardnumber.TabIndex = 18;
            this.num_Cardnumber.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.num_Cardnumber.ValueChanged += new System.EventHandler(this.num_Cardnumber_ValueChanged);
            // 
            // cmb_spelare
            // 
            this.cmb_spelare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_spelare.FormattingEnabled = true;
            this.cmb_spelare.ItemHeight = 17;
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
            this.cmb_spelare.Location = new System.Drawing.Point(159, 34);
            this.cmb_spelare.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_spelare.Name = "cmb_spelare";
            this.cmb_spelare.Size = new System.Drawing.Size(49, 25);
            this.cmb_spelare.TabIndex = 17;
            this.cmb_spelare.SelectedIndexChanged += new System.EventHandler(this.cmb_spelare_SelectedIndexChanged);
            this.cmb_spelare.Validated += new System.EventHandler(this.cmb_spelare_Validated);
            // 
            // cmb_AI
            // 
            this.cmb_AI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AI.Enabled = false;
            this.cmb_AI.FormattingEnabled = true;
            this.cmb_AI.ItemHeight = 17;
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
            this.cmb_AI.Location = new System.Drawing.Point(159, 76);
            this.cmb_AI.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_AI.Name = "cmb_AI";
            this.cmb_AI.Size = new System.Drawing.Size(49, 25);
            this.cmb_AI.TabIndex = 16;
            this.cmb_AI.SelectedIndexChanged += new System.EventHandler(this.cmb_AI_SelectedIndexChanged);
            this.cmb_AI.Validated += new System.EventHandler(this.cmb_AI_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Antal Kort:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "AI Spelare:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Spelare:";
            // 
            // btn_starta
            // 
            this.btn_starta.Location = new System.Drawing.Point(159, 275);
            this.btn_starta.Margin = new System.Windows.Forms.Padding(2);
            this.btn_starta.Name = "btn_starta";
            this.btn_starta.Size = new System.Drawing.Size(100, 33);
            this.btn_starta.TabIndex = 26;
            this.btn_starta.Text = "Starta";
            this.btn_starta.UseVisualStyleBackColor = true;
            this.btn_starta.Click += new System.EventHandler(this.btn_starta_Click);
            // 
            // Tema
            // 
            this.Tema.AutoSize = true;
            this.Tema.Location = new System.Drawing.Point(79, 180);
            this.Tema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tema.Name = "Tema";
            this.Tema.Size = new System.Drawing.Size(48, 17);
            this.Tema.TabIndex = 30;
            this.Tema.Text = "Tema:";
            // 
            // cmb_Level
            // 
            this.cmb_Level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Level.Enabled = false;
            this.cmb_Level.FormattingEnabled = true;
            this.cmb_Level.Items.AddRange(new object[] {
            "Lätt",
            "Medel ",
            "Svår"});
            this.cmb_Level.Location = new System.Drawing.Point(159, 105);
            this.cmb_Level.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_Level.Name = "cmb_Level";
            this.cmb_Level.Size = new System.Drawing.Size(89, 25);
            this.cmb_Level.TabIndex = 31;
            // 
            // cmb_Themes
            // 
            this.cmb_Themes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Themes.FormattingEnabled = true;
            this.cmb_Themes.Items.AddRange(new object[] {
            "Frukt",
            "Vägmärken",
            "Djur"});
            this.cmb_Themes.Location = new System.Drawing.Point(159, 176);
            this.cmb_Themes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_Themes.Name = "cmb_Themes";
            this.cmb_Themes.Size = new System.Drawing.Size(89, 25);
            this.cmb_Themes.TabIndex = 32;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 361);
            this.Controls.Add(this.cmb_Themes);
            this.Controls.Add(this.cmb_Level);
            this.Controls.Add(this.Tema);
            this.Controls.Add(this.btn_starta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nud_ShowCardTimer);
            this.Controls.Add(this.nud_PlayerTurnTimer);
            this.Controls.Add(this.num_Cardnumber);
            this.Controls.Add(this.cmb_spelare);
            this.Controls.Add(this.cmb_AI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StartForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory ";
            ((System.ComponentModel.ISupportInitialize)(this.nud_ShowCardTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PlayerTurnTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Cardnumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_ShowCardTimer;
        private System.Windows.Forms.NumericUpDown nud_PlayerTurnTimer;
        private System.Windows.Forms.NumericUpDown num_Cardnumber;
        private System.Windows.Forms.ComboBox cmb_spelare;
        private System.Windows.Forms.ComboBox cmb_AI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_starta;
        private System.Windows.Forms.Label Tema;
        private System.Windows.Forms.ComboBox cmb_Level;
        private System.Windows.Forms.ComboBox cmb_Themes;
    }
}