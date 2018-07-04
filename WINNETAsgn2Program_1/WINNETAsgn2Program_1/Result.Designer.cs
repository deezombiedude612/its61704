namespace WINNETAsgn2Program_1
{
    partial class Result
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
            this.cbName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.labPercent = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labCorrect = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listAnswers = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.pbResultCountry = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnWinner = new System.Windows.Forms.Button();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // cbName
            // 
            this.cbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(245, 79);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(304, 46);
            this.cbName.TabIndex = 0;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(142, 30);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(96, 36);
            this.labName.TabIndex = 2;
            this.labName.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Country";
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.labPercent);
            this.gbResult.Controls.Add(this.label7);
            this.gbResult.Controls.Add(this.labCorrect);
            this.gbResult.Controls.Add(this.label5);
            this.gbResult.Controls.Add(this.listAnswers);
            this.gbResult.Controls.Add(this.label2);
            this.gbResult.Controls.Add(this.pbResultCountry);
            this.gbResult.Controls.Add(this.label1);
            this.gbResult.Controls.Add(this.label3);
            this.gbResult.Controls.Add(this.labName);
            this.gbResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbResult.Location = new System.Drawing.Point(168, 152);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(454, 731);
            this.gbResult.TabIndex = 4;
            this.gbResult.TabStop = false;
            // 
            // labPercent
            // 
            this.labPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPercent.ForeColor = System.Drawing.Color.Firebrick;
            this.labPercent.Location = new System.Drawing.Point(191, 648);
            this.labPercent.Name = "labPercent";
            this.labPercent.Size = new System.Drawing.Size(239, 60);
            this.labPercent.TabIndex = 15;
            this.labPercent.Text = "100%";
            this.labPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(307, 588);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 60);
            this.label7.TabIndex = 11;
            this.label7.Text = "/ 20";
            // 
            // labCorrect
            // 
            this.labCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCorrect.ForeColor = System.Drawing.Color.Firebrick;
            this.labCorrect.Location = new System.Drawing.Point(254, 588);
            this.labCorrect.Name = "labCorrect";
            this.labCorrect.Size = new System.Drawing.Size(67, 60);
            this.labCorrect.TabIndex = 12;
            this.labCorrect.Text = "20";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 620);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Score";
            // 
            // listAnswers
            // 
            this.listAnswers.Location = new System.Drawing.Point(148, 280);
            this.listAnswers.Name = "listAnswers";
            this.listAnswers.Size = new System.Drawing.Size(259, 254);
            this.listAnswers.TabIndex = 6;
            this.listAnswers.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Answers";
            // 
            // pbResultCountry
            // 
            this.pbResultCountry.Location = new System.Drawing.Point(148, 113);
            this.pbResultCountry.Name = "pbResultCountry";
            this.pbResultCountry.Size = new System.Drawing.Size(259, 139);
            this.pbResultCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResultCountry.TabIndex = 4;
            this.pbResultCountry.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(307, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 54);
            this.label4.TabIndex = 9;
            this.label4.Text = "RESULT";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(414, 903);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(208, 43);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnWinner
            // 
            this.btnWinner.Location = new System.Drawing.Point(168, 903);
            this.btnWinner.Name = "btnWinner";
            this.btnWinner.Size = new System.Drawing.Size(208, 43);
            this.btnWinner.TabIndex = 14;
            this.btnWinner.Text = "Who\'s the Winner ?";
            this.btnWinner.UseVisualStyleBackColor = true;
            this.btnWinner.Click += new System.EventHandler(this.btnWinner_Click);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 980);
            this.Controls.Add(this.btnWinner);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.cbName);
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultCountry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbResultCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listAnswers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labCorrect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labPercent;
        private System.Windows.Forms.Button btnWinner;
    }
}