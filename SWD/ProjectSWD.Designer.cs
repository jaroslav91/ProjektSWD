namespace SWD
{
    partial class ProjectSWD
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this._btnSuggestTreatment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._decision = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Uczulenia na paracetamol",
            "Uczulenia na ibuprofen",
            "Niewydolność wątroby",
            "Uczulenie na loperamid",
            "Uczulenie na diosmektyt",
            "Choroba wrzodowa żołądka",
            "Ciąża"});
            this.checkedListBox1.Location = new System.Drawing.Point(205, 31);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(199, 259);
            this.checkedListBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Analizuj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // _btnSuggestTreatment
            // 
            this._btnSuggestTreatment.Location = new System.Drawing.Point(487, 296);
            this._btnSuggestTreatment.Name = "_btnSuggestTreatment";
            this._btnSuggestTreatment.Size = new System.Drawing.Size(154, 23);
            this._btnSuggestTreatment.TabIndex = 3;
            this._btnSuggestTreatment.Text = "Zaproponuj leczenie";
            this._btnSuggestTreatment.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rozpoznanie:";
            // 
            // _decision
            // 
            this._decision.FormattingEnabled = true;
            this._decision.Items.AddRange(new object[] {
            "Zmniejszenie temperatury",
            "Elimnacja bólu głowy",
            "Elimnacja bólu brzucha",
            "Elimnacja bólu zęba"});
            this._decision.Location = new System.Drawing.Point(423, 31);
            this._decision.Name = "_decision";
            this._decision.Size = new System.Drawing.Size(218, 259);
            this._decision.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cel leczenia:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(27, 351);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(614, 120);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Lek z ibuprofenem (Ibuprom, Gripex)\r\nUnikaj alkoholu, napojów gazowanych, soków i" +
    " kawy\r\nPij dużo płynów";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Decyzja:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(566, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Wyczyść";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Biegunka",
            "Ból brzucha",
            "Ból głowy",
            "Ból zęba",
            "Kaszel",
            "Katar",
            "Ból mięśni",
            "Gorączka"});
            this.checkedListBox2.Location = new System.Drawing.Point(13, 31);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(165, 259);
            this.checkedListBox2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Obiawy:";
            // 
            // ProjectSWD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 513);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._decision);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnSuggestTreatment);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "ProjectSWD";
            this.Text = "Projekt SWD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button _btnSuggestTreatment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox _decision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label2;
    }
}

