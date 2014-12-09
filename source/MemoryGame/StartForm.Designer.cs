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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_starta = new System.Windows.Forms.Button();
            this.Tema = new System.Windows.Forms.Label();
            this.cmb_Level = new System.Windows.Forms.ComboBox();
            this.cmb_Themes = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.playerListView = new System.Windows.Forms.ListView();
            this.Spelare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ShowCardTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PlayerTurnTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Cardnumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 243);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Visningstid (sec):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Betänketid (sec):";
            // 
            // nud_ShowCardTimer
            // 
            this.nud_ShowCardTimer.Location = new System.Drawing.Point(115, 240);
            this.nud_ShowCardTimer.Margin = new System.Windows.Forms.Padding(2);
            this.nud_ShowCardTimer.Name = "nud_ShowCardTimer";
            this.nud_ShowCardTimer.Size = new System.Drawing.Size(40, 20);
            this.nud_ShowCardTimer.TabIndex = 20;
            this.nud_ShowCardTimer.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nud_PlayerTurnTimer
            // 
            this.nud_PlayerTurnTimer.Location = new System.Drawing.Point(115, 204);
            this.nud_PlayerTurnTimer.Margin = new System.Windows.Forms.Padding(2);
            this.nud_PlayerTurnTimer.Name = "nud_PlayerTurnTimer";
            this.nud_PlayerTurnTimer.Size = new System.Drawing.Size(40, 20);
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
            this.num_Cardnumber.Location = new System.Drawing.Point(88, 118);
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
            this.num_Cardnumber.Size = new System.Drawing.Size(37, 20);
            this.num_Cardnumber.TabIndex = 18;
            this.num_Cardnumber.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.num_Cardnumber.ValueChanged += new System.EventHandler(this.num_Cardnumber_ValueChanged);
            
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Antal Kort:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Spelare:";
            // 
            // btn_starta
            // 
            this.btn_starta.Location = new System.Drawing.Point(155, 292);
            this.btn_starta.Margin = new System.Windows.Forms.Padding(2);
            this.btn_starta.Name = "btn_starta";
            this.btn_starta.Size = new System.Drawing.Size(75, 25);
            this.btn_starta.TabIndex = 26;
            this.btn_starta.Text = "Starta";
            this.btn_starta.UseVisualStyleBackColor = true;
            this.btn_starta.Click += new System.EventHandler(this.btn_starta_Click);
            // 
            // Tema
            // 
            this.Tema.AutoSize = true;
            this.Tema.Location = new System.Drawing.Point(28, 165);
            this.Tema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tema.Name = "Tema";
            this.Tema.Size = new System.Drawing.Size(37, 13);
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
            this.cmb_Level.Location = new System.Drawing.Point(89, 69);
            this.cmb_Level.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Level.Name = "cmb_Level";
            this.cmb_Level.Size = new System.Drawing.Size(68, 21);
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
            this.cmb_Themes.Location = new System.Drawing.Point(88, 162);
            this.cmb_Themes.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Themes.Name = "cmb_Themes";
            this.cmb_Themes.Size = new System.Drawing.Size(68, 21);
            this.cmb_Themes.TabIndex = 32;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 33;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(215, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "AI";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // playerListView
            // 
            this.playerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Spelare});
            this.playerListView.Location = new System.Drawing.Point(245, 66);
            this.playerListView.Name = "playerListView";
            this.playerListView.Size = new System.Drawing.Size(161, 190);
            this.playerListView.TabIndex = 100;
            this.playerListView.UseCompatibleStateImageBehavior = false;
            this.playerListView.View = System.Windows.Forms.View.List;
            this.playerListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Spelare
            // 
            this.Spelare.Text = "Spelare";
            this.Spelare.Width = 180;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nivå";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 365);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.playerListView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmb_Themes);
            this.Controls.Add(this.cmb_Level);
            this.Controls.Add(this.Tema);
            this.Controls.Add(this.btn_starta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nud_ShowCardTimer);
            this.Controls.Add(this.nud_PlayerTurnTimer);
            this.Controls.Add(this.num_Cardnumber);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_starta;
        private System.Windows.Forms.Label Tema;
        private System.Windows.Forms.ComboBox cmb_Level;
        private System.Windows.Forms.ComboBox cmb_Themes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView playerListView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Spelare;
    }
}