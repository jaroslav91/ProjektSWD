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
            this.components = new System.ComponentModel.Container();
            this._chblRecognitions = new System.Windows.Forms.CheckedListBox();
            this._btnAnalyze = new System.Windows.Forms.Button();
            this._btnSuggestTreatment = new System.Windows.Forms.Button();
            this._lRecognitions = new System.Windows.Forms.Label();
            this._chblTreatmentGoals = new System.Windows.Forms.CheckedListBox();
            this._lTreatmentGoal = new System.Windows.Forms.Label();
            this._tbResult = new System.Windows.Forms.TextBox();
            this._lResult = new System.Windows.Forms.Label();
            this._btnClear = new System.Windows.Forms.Button();
            this._chblSymptoms = new System.Windows.Forms.CheckedListBox();
            this._lSymptoms = new System.Windows.Forms.Label();
            this._bsSympthons = new System.Windows.Forms.BindingSource(this.components);
            this._bsRecognitions = new System.Windows.Forms.BindingSource(this.components);
            this._bsTreatmentGoals = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._bsSympthons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsRecognitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsTreatmentGoals)).BeginInit();
            this.SuspendLayout();
            // 
            // _chblRecognitions
            // 
            this._chblRecognitions.FormattingEnabled = true;
            this._chblRecognitions.Items.AddRange(new object[] {
            "Uczulenia na paracetamol",
            "Uczulenia na ibuprofen",
            "Niewydolność wątroby",
            "Uczulenie na loperamid",
            "Uczulenie na diosmektyt",
            "Choroba wrzodowa żołądka",
            "Ciąża"});
            this._chblRecognitions.Location = new System.Drawing.Point(205, 31);
            this._chblRecognitions.Name = "_chblRecognitions";
            this._chblRecognitions.Size = new System.Drawing.Size(199, 259);
            this._chblRecognitions.TabIndex = 0;
            // 
            // _btnAnalyze
            // 
            this._btnAnalyze.Location = new System.Drawing.Point(285, 296);
            this._btnAnalyze.Name = "_btnAnalyze";
            this._btnAnalyze.Size = new System.Drawing.Size(119, 23);
            this._btnAnalyze.TabIndex = 1;
            this._btnAnalyze.Text = "Analizuj";
            this._btnAnalyze.UseVisualStyleBackColor = true;
            this._btnAnalyze.Click += new System.EventHandler(this._btnAnalyze_Click);
            // 
            // _btnSuggestTreatment
            // 
            this._btnSuggestTreatment.Location = new System.Drawing.Point(487, 296);
            this._btnSuggestTreatment.Name = "_btnSuggestTreatment";
            this._btnSuggestTreatment.Size = new System.Drawing.Size(154, 23);
            this._btnSuggestTreatment.TabIndex = 3;
            this._btnSuggestTreatment.Text = "Zaproponuj leczenie";
            this._btnSuggestTreatment.UseVisualStyleBackColor = true;
            this._btnSuggestTreatment.Click += new System.EventHandler(this._btnSuggestTreatment_Click);
            // 
            // _lRecognitions
            // 
            this._lRecognitions.AutoSize = true;
            this._lRecognitions.Location = new System.Drawing.Point(251, 15);
            this._lRecognitions.Name = "_lRecognitions";
            this._lRecognitions.Size = new System.Drawing.Size(72, 13);
            this._lRecognitions.TabIndex = 4;
            this._lRecognitions.Text = "Rozpoznanie:";
            // 
            // _chblTreatmentGoals
            // 
            this._chblTreatmentGoals.FormattingEnabled = true;
            this._chblTreatmentGoals.Items.AddRange(new object[] {
            "Zmniejszenie temperatury",
            "Elimnacja bólu głowy",
            "Elimnacja bólu brzucha",
            "Elimnacja bólu zęba"});
            this._chblTreatmentGoals.Location = new System.Drawing.Point(423, 31);
            this._chblTreatmentGoals.Name = "_chblTreatmentGoals";
            this._chblTreatmentGoals.Size = new System.Drawing.Size(218, 259);
            this._chblTreatmentGoals.TabIndex = 6;
            // 
            // _lTreatmentGoal
            // 
            this._lTreatmentGoal.AutoSize = true;
            this._lTreatmentGoal.Location = new System.Drawing.Point(504, 15);
            this._lTreatmentGoal.Name = "_lTreatmentGoal";
            this._lTreatmentGoal.Size = new System.Drawing.Size(67, 13);
            this._lTreatmentGoal.TabIndex = 8;
            this._lTreatmentGoal.Text = "Cel leczenia:";
            // 
            // _tbResult
            // 
            this._tbResult.Location = new System.Drawing.Point(27, 351);
            this._tbResult.Multiline = true;
            this._tbResult.Name = "_tbResult";
            this._tbResult.Size = new System.Drawing.Size(614, 120);
            this._tbResult.TabIndex = 9;
            // 
            // _lResult
            // 
            this._lResult.AutoSize = true;
            this._lResult.Location = new System.Drawing.Point(24, 335);
            this._lResult.Name = "_lResult";
            this._lResult.Size = new System.Drawing.Size(48, 13);
            this._lResult.TabIndex = 10;
            this._lResult.Text = "Decyzja:";
            // 
            // _btnClear
            // 
            this._btnClear.Location = new System.Drawing.Point(566, 477);
            this._btnClear.Name = "_btnClear";
            this._btnClear.Size = new System.Drawing.Size(75, 23);
            this._btnClear.TabIndex = 11;
            this._btnClear.Text = "Wyczyść";
            this._btnClear.UseVisualStyleBackColor = true;
            this._btnClear.Click += new System.EventHandler(this._btnClear_Click);
            // 
            // _chblSymptoms
            // 
            this._chblSymptoms.FormattingEnabled = true;
            this._chblSymptoms.Location = new System.Drawing.Point(27, 31);
            this._chblSymptoms.Name = "_chblSymptoms";
            this._chblSymptoms.Size = new System.Drawing.Size(165, 259);
            this._chblSymptoms.TabIndex = 12;
            // 
            // _lSymptoms
            // 
            this._lSymptoms.AutoSize = true;
            this._lSymptoms.Location = new System.Drawing.Point(76, 15);
            this._lSymptoms.Name = "_lSymptoms";
            this._lSymptoms.Size = new System.Drawing.Size(45, 13);
            this._lSymptoms.TabIndex = 13;
            this._lSymptoms.Text = "Obiawy:";
            // 
            // _bsSympthons
            // 
            this._bsSympthons.DataSource = typeof(SWD.Common.ListItem);
            // 
            // _bsRecognitions
            // 
            this._bsRecognitions.DataSource = typeof(SWD.Common.ListItem);
            // 
            // _bsTreatmentGoals
            // 
            this._bsTreatmentGoals.DataSource = typeof(SWD.Common.ListItem);
            // 
            // ProjectSWD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 513);
            this.Controls.Add(this._lSymptoms);
            this.Controls.Add(this._chblSymptoms);
            this.Controls.Add(this._btnClear);
            this.Controls.Add(this._lResult);
            this.Controls.Add(this._tbResult);
            this.Controls.Add(this._lTreatmentGoal);
            this.Controls.Add(this._chblTreatmentGoals);
            this.Controls.Add(this._lRecognitions);
            this.Controls.Add(this._btnSuggestTreatment);
            this.Controls.Add(this._btnAnalyze);
            this.Controls.Add(this._chblRecognitions);
            this.Name = "ProjectSWD";
            this.Text = "Projekt SWD";
            ((System.ComponentModel.ISupportInitialize)(this._bsSympthons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsRecognitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bsTreatmentGoals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox _chblRecognitions;
        private System.Windows.Forms.Button _btnAnalyze;
        private System.Windows.Forms.Button _btnSuggestTreatment;
        private System.Windows.Forms.Label _lRecognitions;
        private System.Windows.Forms.CheckedListBox _chblTreatmentGoals;
        private System.Windows.Forms.Label _lTreatmentGoal;
        private System.Windows.Forms.TextBox _tbResult;
        private System.Windows.Forms.Label _lResult;
        private System.Windows.Forms.Button _btnClear;
        private System.Windows.Forms.CheckedListBox _chblSymptoms;
        private System.Windows.Forms.Label _lSymptoms;
        private System.Windows.Forms.BindingSource _bsSympthons;
        private System.Windows.Forms.BindingSource _bsRecognitions;
        private System.Windows.Forms.BindingSource _bsTreatmentGoals;
    }
}

