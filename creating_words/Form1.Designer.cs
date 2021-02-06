namespace creating_words
{
    partial class form1
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
            this.listBox_letters = new System.Windows.Forms.ListBox();
            this.listBox_player2 = new System.Windows.Forms.ListBox();
            this.listBox_player1 = new System.Windows.Forms.ListBox();
            this.start_button = new System.Windows.Forms.Button();
            this.Add_Word = new System.Windows.Forms.Button();
            this.Easy_button = new System.Windows.Forms.Button();
            this.Medium_button = new System.Windows.Forms.Button();
            this.Hard_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Next_Turn = new System.Windows.Forms.Button();
            this.Who_Won = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_letters
            // 
            this.listBox_letters.FormattingEnabled = true;
            this.listBox_letters.ItemHeight = 20;
            this.listBox_letters.Items.AddRange(new object[] {
            "Letters bank:"});
            this.listBox_letters.Location = new System.Drawing.Point(44, 90);
            this.listBox_letters.Name = "listBox_letters";
            this.listBox_letters.Size = new System.Drawing.Size(120, 244);
            this.listBox_letters.TabIndex = 0;
            this.listBox_letters.Visible = false;
            this.listBox_letters.SelectedIndexChanged += new System.EventHandler(this.listBox_letters_SelectedIndexChanged);
            // 
            // listBox_player2
            // 
            this.listBox_player2.FormattingEnabled = true;
            this.listBox_player2.ItemHeight = 20;
            this.listBox_player2.Items.AddRange(new object[] {
            "Player 2 words:"});
            this.listBox_player2.Location = new System.Drawing.Point(540, 60);
            this.listBox_player2.Name = "listBox_player2";
            this.listBox_player2.Size = new System.Drawing.Size(126, 284);
            this.listBox_player2.TabIndex = 1;
            this.listBox_player2.Visible = false;
            // 
            // listBox_player1
            // 
            this.listBox_player1.FormattingEnabled = true;
            this.listBox_player1.ItemHeight = 20;
            this.listBox_player1.Items.AddRange(new object[] {
            "Player 1 words:"});
            this.listBox_player1.Location = new System.Drawing.Point(282, 60);
            this.listBox_player1.Name = "listBox_player1";
            this.listBox_player1.Size = new System.Drawing.Size(132, 284);
            this.listBox_player1.TabIndex = 2;
            this.listBox_player1.Visible = false;
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(295, 350);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(97, 42);
            this.start_button.TabIndex = 3;
            this.start_button.Text = "start";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Visible = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // Add_Word
            // 
            this.Add_Word.Location = new System.Drawing.Point(565, 350);
            this.Add_Word.Name = "Add_Word";
            this.Add_Word.Size = new System.Drawing.Size(101, 42);
            this.Add_Word.TabIndex = 4;
            this.Add_Word.Text = "Add word";
            this.Add_Word.UseVisualStyleBackColor = true;
            this.Add_Word.Visible = false;
            this.Add_Word.Click += new System.EventHandler(this.Add_Word_Click_1);
            // 
            // Easy_button
            // 
            this.Easy_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Easy_button.ForeColor = System.Drawing.Color.Blue;
            this.Easy_button.Location = new System.Drawing.Point(185, 205);
            this.Easy_button.Name = "Easy_button";
            this.Easy_button.Size = new System.Drawing.Size(75, 42);
            this.Easy_button.TabIndex = 5;
            this.Easy_button.Text = "Easy";
            this.Easy_button.UseVisualStyleBackColor = false;
            this.Easy_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Medium_button
            // 
            this.Medium_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Medium_button.ForeColor = System.Drawing.Color.Blue;
            this.Medium_button.Location = new System.Drawing.Point(308, 205);
            this.Medium_button.Name = "Medium_button";
            this.Medium_button.Size = new System.Drawing.Size(106, 42);
            this.Medium_button.TabIndex = 7;
            this.Medium_button.Text = "Medium";
            this.Medium_button.UseVisualStyleBackColor = false;
            this.Medium_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Hard_button
            // 
            this.Hard_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Hard_button.ForeColor = System.Drawing.Color.Blue;
            this.Hard_button.Location = new System.Drawing.Point(459, 205);
            this.Hard_button.Name = "Hard_button";
            this.Hard_button.Size = new System.Drawing.Size(75, 42);
            this.Hard_button.TabIndex = 8;
            this.Hard_button.Text = "Hard";
            this.Hard_button.UseVisualStyleBackColor = false;
            this.Hard_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::creating_words.Properties.Resources.select_level;
            this.pictureBox1.Location = new System.Drawing.Point(188, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 10;
            this.textBox1.Visible = false;
            // 
            // Next_Turn
            // 
            this.Next_Turn.Location = new System.Drawing.Point(30, 393);
            this.Next_Turn.Name = "Next_Turn";
            this.Next_Turn.Size = new System.Drawing.Size(134, 45);
            this.Next_Turn.TabIndex = 11;
            this.Next_Turn.Text = "Next player turn";
            this.Next_Turn.UseVisualStyleBackColor = true;
            this.Next_Turn.Visible = false;
            this.Next_Turn.Click += new System.EventHandler(this.Next_Turn_Click);
            // 
            // Who_Won
            // 
            this.Who_Won.Location = new System.Drawing.Point(20, 393);
            this.Who_Won.Name = "Who_Won";
            this.Who_Won.Size = new System.Drawing.Size(144, 45);
            this.Who_Won.TabIndex = 12;
            this.Who_Won.Text = "Check winner";
            this.Who_Won.UseVisualStyleBackColor = true;
            this.Who_Won.Visible = false;
            this.Who_Won.Click += new System.EventHandler(this.Who_Won_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::creating_words.Properties.Resources.word_game;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Who_Won);
            this.Controls.Add(this.Next_Turn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Hard_button);
            this.Controls.Add(this.Medium_button);
            this.Controls.Add(this.Easy_button);
            this.Controls.Add(this.Add_Word);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.listBox_player1);
            this.Controls.Add(this.listBox_player2);
            this.Controls.Add(this.listBox_letters);
            this.Name = "form1";
            this.Text = "or_and_katz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_letters;
        private System.Windows.Forms.ListBox listBox_player2;
        private System.Windows.Forms.ListBox listBox_player1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button Add_Word;
        private System.Windows.Forms.Button Easy_button;
        private System.Windows.Forms.Button Medium_button;
        private System.Windows.Forms.Button Hard_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Next_Turn;
        private System.Windows.Forms.Button Who_Won;
    }
}

