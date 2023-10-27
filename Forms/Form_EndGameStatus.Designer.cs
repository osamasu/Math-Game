namespace Math_Game.Forms
{
    partial class Form_EndGameStatus
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_QuestionResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_RightAnswersReult = new System.Windows.Forms.Label();
            this.LB_WrongAnswersResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LB_OperationType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_QuestionLevelResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LB_FinalResult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LB_Percentage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question List";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.LB_QuestionResult);
            this.panel1.Location = new System.Drawing.Point(12, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 363);
            this.panel1.TabIndex = 1;
            // 
            // LB_QuestionResult
            // 
            this.LB_QuestionResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.LB_QuestionResult.Font = new System.Drawing.Font("Unispace", 13F, System.Drawing.FontStyle.Bold);
            this.LB_QuestionResult.Location = new System.Drawing.Point(0, 0);
            this.LB_QuestionResult.Name = "LB_QuestionResult";
            this.LB_QuestionResult.Size = new System.Drawing.Size(409, 79);
            this.LB_QuestionResult.TabIndex = 0;
            this.LB_QuestionResult.Text = "LB_QuestionInfo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(436, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Right Answers";
            // 
            // LB_RightAnswersReult
            // 
            this.LB_RightAnswersReult.AutoSize = true;
            this.LB_RightAnswersReult.BackColor = System.Drawing.Color.Transparent;
            this.LB_RightAnswersReult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_RightAnswersReult.Font = new System.Drawing.Font("Verdana", 22F, System.Drawing.FontStyle.Bold);
            this.LB_RightAnswersReult.ForeColor = System.Drawing.Color.DarkGreen;
            this.LB_RightAnswersReult.Location = new System.Drawing.Point(667, 65);
            this.LB_RightAnswersReult.Name = "LB_RightAnswersReult";
            this.LB_RightAnswersReult.Size = new System.Drawing.Size(46, 45);
            this.LB_RightAnswersReult.TabIndex = 3;
            this.LB_RightAnswersReult.Text = "0";
            // 
            // LB_WrongAnswersResult
            // 
            this.LB_WrongAnswersResult.AutoSize = true;
            this.LB_WrongAnswersResult.BackColor = System.Drawing.Color.Transparent;
            this.LB_WrongAnswersResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_WrongAnswersResult.Font = new System.Drawing.Font("Verdana", 22F, System.Drawing.FontStyle.Bold);
            this.LB_WrongAnswersResult.ForeColor = System.Drawing.Color.Crimson;
            this.LB_WrongAnswersResult.Location = new System.Drawing.Point(667, 126);
            this.LB_WrongAnswersResult.Name = "LB_WrongAnswersResult";
            this.LB_WrongAnswersResult.Size = new System.Drawing.Size(46, 45);
            this.LB_WrongAnswersResult.TabIndex = 5;
            this.LB_WrongAnswersResult.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(436, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Wrong Answers";
            // 
            // LB_OperationType
            // 
            this.LB_OperationType.AutoSize = true;
            this.LB_OperationType.BackColor = System.Drawing.Color.Transparent;
            this.LB_OperationType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_OperationType.Font = new System.Drawing.Font("Verdana", 22F, System.Drawing.FontStyle.Bold);
            this.LB_OperationType.ForeColor = System.Drawing.SystemColors.MenuText;
            this.LB_OperationType.Location = new System.Drawing.Point(667, 187);
            this.LB_OperationType.Name = "LB_OperationType";
            this.LB_OperationType.Size = new System.Drawing.Size(46, 45);
            this.LB_OperationType.TabIndex = 7;
            this.LB_OperationType.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(436, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Operation Type";
            // 
            // LB_QuestionLevelResult
            // 
            this.LB_QuestionLevelResult.AutoSize = true;
            this.LB_QuestionLevelResult.BackColor = System.Drawing.Color.Transparent;
            this.LB_QuestionLevelResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_QuestionLevelResult.Font = new System.Drawing.Font("Verdana", 22F, System.Drawing.FontStyle.Bold);
            this.LB_QuestionLevelResult.ForeColor = System.Drawing.Color.MidnightBlue;
            this.LB_QuestionLevelResult.Location = new System.Drawing.Point(667, 248);
            this.LB_QuestionLevelResult.Name = "LB_QuestionLevelResult";
            this.LB_QuestionLevelResult.Size = new System.Drawing.Size(46, 45);
            this.LB_QuestionLevelResult.TabIndex = 9;
            this.LB_QuestionLevelResult.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(436, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Question Level";
            // 
            // LB_FinalResult
            // 
            this.LB_FinalResult.AutoSize = true;
            this.LB_FinalResult.BackColor = System.Drawing.Color.Transparent;
            this.LB_FinalResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_FinalResult.Font = new System.Drawing.Font("Verdana", 22F, System.Drawing.FontStyle.Bold);
            this.LB_FinalResult.ForeColor = System.Drawing.Color.OrangeRed;
            this.LB_FinalResult.Location = new System.Drawing.Point(667, 309);
            this.LB_FinalResult.Name = "LB_FinalResult";
            this.LB_FinalResult.Size = new System.Drawing.Size(46, 45);
            this.LB_FinalResult.TabIndex = 11;
            this.LB_FinalResult.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(441, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Final Ruselt";
            // 
            // LB_Percentage
            // 
            this.LB_Percentage.AutoSize = true;
            this.LB_Percentage.BackColor = System.Drawing.Color.Transparent;
            this.LB_Percentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_Percentage.Font = new System.Drawing.Font("Verdana", 22F, System.Drawing.FontStyle.Bold);
            this.LB_Percentage.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LB_Percentage.Location = new System.Drawing.Point(667, 370);
            this.LB_Percentage.Name = "LB_Percentage";
            this.LB_Percentage.Size = new System.Drawing.Size(46, 45);
            this.LB_Percentage.TabIndex = 13;
            this.LB_Percentage.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(441, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Percentage";
            // 
            // Form_EndGameStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Math_Game.Properties.Resources.MathBackGround100;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.LB_Percentage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LB_FinalResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LB_QuestionLevelResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LB_OperationType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LB_WrongAnswersResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LB_RightAnswersReult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form_EndGameStatus";
            this.Text = "Form_EndGameStatus";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LB_QuestionResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_RightAnswersReult;
        private System.Windows.Forms.Label LB_WrongAnswersResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LB_OperationType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LB_QuestionLevelResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LB_FinalResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LB_Percentage;
        private System.Windows.Forms.Label label8;
    }
}