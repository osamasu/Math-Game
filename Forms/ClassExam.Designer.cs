namespace Math_Game.Forms
{
    partial class ClassExam
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.LB_CorrectAnswersCounter = new FontAwesome.Sharp.IconButton();
            this.LB_WrongAnswerCounter = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_GameTimer = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.LB_NumberOfAnsweredQuestions = new System.Windows.Forms.Label();
            this.LB_Question = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.Khaki;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Unispace", 10.5F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(260, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 61);
            this.button1.TabIndex = 0;
            this.button1.Tag = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Unispace", 10.5F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(433, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 61);
            this.button2.TabIndex = 1;
            this.button2.Tag = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.Khaki;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Unispace", 10.5F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(433, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 61);
            this.button3.TabIndex = 3;
            this.button3.Tag = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button4.BackColor = System.Drawing.Color.Khaki;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Unispace", 10.5F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(260, 418);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 61);
            this.button4.TabIndex = 2;
            this.button4.Tag = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // LB_CorrectAnswersCounter
            // 
            this.LB_CorrectAnswersCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_CorrectAnswersCounter.BackColor = System.Drawing.Color.Transparent;

            this.LB_CorrectAnswersCounter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LB_CorrectAnswersCounter.FlatAppearance.BorderSize = 0;
            this.LB_CorrectAnswersCounter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LB_CorrectAnswersCounter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LB_CorrectAnswersCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_CorrectAnswersCounter.Font = new System.Drawing.Font("Unispace", 13F);
            this.LB_CorrectAnswersCounter.ForeColor = System.Drawing.Color.Lime;
            this.LB_CorrectAnswersCounter.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.LB_CorrectAnswersCounter.IconColor = System.Drawing.Color.Lime;
            this.LB_CorrectAnswersCounter.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.LB_CorrectAnswersCounter.Location = new System.Drawing.Point(723, 35);
            this.LB_CorrectAnswersCounter.Name = "LB_CorrectAnswersCounter";
            this.LB_CorrectAnswersCounter.Size = new System.Drawing.Size(95, 48);
            this.LB_CorrectAnswersCounter.TabIndex = 4;
            this.LB_CorrectAnswersCounter.Text = "0";
            this.LB_CorrectAnswersCounter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LB_CorrectAnswersCounter.UseVisualStyleBackColor = false;
            // 
            // LB_WrongAnswerCounter
            // 
            this.LB_WrongAnswerCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LB_WrongAnswerCounter.BackColor = System.Drawing.Color.Transparent;
            this.LB_WrongAnswerCounter.FlatAppearance.BorderSize = 0;
            this.LB_WrongAnswerCounter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LB_WrongAnswerCounter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LB_WrongAnswerCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_WrongAnswerCounter.Font = new System.Drawing.Font("Unispace", 13F);
            this.LB_WrongAnswerCounter.ForeColor = System.Drawing.Color.Crimson;
            this.LB_WrongAnswerCounter.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            this.LB_WrongAnswerCounter.IconColor = System.Drawing.Color.Crimson;
            this.LB_WrongAnswerCounter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LB_WrongAnswerCounter.Location = new System.Drawing.Point(723, 89);
            this.LB_WrongAnswerCounter.Name = "LB_WrongAnswerCounter";
            this.LB_WrongAnswerCounter.Size = new System.Drawing.Size(95, 48);
            this.LB_WrongAnswerCounter.TabIndex = 5;
            this.LB_WrongAnswerCounter.Text = "0";
            this.LB_WrongAnswerCounter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LB_WrongAnswerCounter.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Math_Game.Properties.Resources.timer;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(36, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 59);
            this.panel1.TabIndex = 6;
            // 
            // LB_GameTimer
            // 
            this.LB_GameTimer.AutoSize = true;
            this.LB_GameTimer.BackColor = System.Drawing.Color.Transparent;
            this.LB_GameTimer.Font = new System.Drawing.Font("Unispace", 12F);
            this.LB_GameTimer.ForeColor = System.Drawing.Color.White;
            this.LB_GameTimer.Location = new System.Drawing.Point(93, 211);
            this.LB_GameTimer.Name = "LB_GameTimer";
            this.LB_GameTimer.Size = new System.Drawing.Size(22, 24);
            this.LB_GameTimer.TabIndex = 7;
            this.LB_GameTimer.Text = "0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 140;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // LB_NumberOfAnsweredQuestions
            // 
            this.LB_NumberOfAnsweredQuestions.AutoSize = true;
            this.LB_NumberOfAnsweredQuestions.BackColor = System.Drawing.Color.Transparent;
            this.LB_NumberOfAnsweredQuestions.Font = new System.Drawing.Font("Unispace", 18F);
            this.LB_NumberOfAnsweredQuestions.ForeColor = System.Drawing.Color.White;
            this.LB_NumberOfAnsweredQuestions.Location = new System.Drawing.Point(65, 69);
            this.LB_NumberOfAnsweredQuestions.Name = "LB_NumberOfAnsweredQuestions";
            this.LB_NumberOfAnsweredQuestions.Size = new System.Drawing.Size(69, 36);
            this.LB_NumberOfAnsweredQuestions.TabIndex = 8;
            this.LB_NumberOfAnsweredQuestions.Text = "0/0";
            // 
            // LB_Question
            // 
            this.LB_Question.AutoSize = true;
            this.LB_Question.BackColor = System.Drawing.Color.Transparent;
            this.LB_Question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LB_Question.Font = new System.Drawing.Font("Unispace", 20F);
            this.LB_Question.ForeColor = System.Drawing.Color.White;
            this.LB_Question.Location = new System.Drawing.Point(294, 201);
            this.LB_Question.Name = "LB_Question";
            this.LB_Question.Size = new System.Drawing.Size(0, 41);
            this.LB_Question.TabIndex = 9;
            // 
            // ClassExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Math_Game.Properties.Resources.Mathmatics_Class;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 521);
            this.Controls.Add(this.LB_Question);
            this.Controls.Add(this.LB_NumberOfAnsweredQuestions);
            this.Controls.Add(this.LB_GameTimer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LB_WrongAnswerCounter);
            this.Controls.Add(this.LB_CorrectAnswersCounter);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "ClassExam";
            this.Text = "Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private FontAwesome.Sharp.IconButton LB_CorrectAnswersCounter;
        private FontAwesome.Sharp.IconButton LB_WrongAnswerCounter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LB_GameTimer;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label LB_NumberOfAnsweredQuestions;
        private System.Windows.Forms.Label LB_Question;
    }
}