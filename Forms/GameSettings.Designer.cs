namespace Math_Game
{
    partial class SettingsGame_Form
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.NumericUD_NumberOfQuestions = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_QuizzLevel = new System.Windows.Forms.ComboBox();
            this.CB_OperationType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_FieldsNumber = new System.Windows.Forms.NumericUpDown();
            this.BT_StartQuizz = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUD_NumberOfQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FieldsNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Wheat;
            this.iconButton1.FlatAppearance.BorderSize = 3;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Unispace", 15F);
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ChalkboardTeacher;
            this.iconButton1.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 50;
            this.iconButton1.Location = new System.Drawing.Point(-11, 30);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(276, 78);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Game Settings";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // NumericUD_NumberOfQuestions
            // 
            this.NumericUD_NumberOfQuestions.Font = new System.Drawing.Font("Unispace", 11F, System.Drawing.FontStyle.Bold);
            this.NumericUD_NumberOfQuestions.Location = new System.Drawing.Point(441, 142);
            this.NumericUD_NumberOfQuestions.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.NumericUD_NumberOfQuestions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUD_NumberOfQuestions.Name = "NumericUD_NumberOfQuestions";
            this.NumericUD_NumberOfQuestions.Size = new System.Drawing.Size(106, 29);
            this.NumericUD_NumberOfQuestions.TabIndex = 1;
            this.NumericUD_NumberOfQuestions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(122, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number Of Question :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(167, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quizz Level :";
            // 
            // CB_QuizzLevel
            // 
            this.CB_QuizzLevel.DisplayMember = "1";
            this.CB_QuizzLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_QuizzLevel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CB_QuizzLevel.Font = new System.Drawing.Font("Unispace", 11F);
            this.CB_QuizzLevel.FormattingEnabled = true;
            this.CB_QuizzLevel.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Mixed"});
            this.CB_QuizzLevel.Location = new System.Drawing.Point(381, 224);
            this.CB_QuizzLevel.Name = "CB_QuizzLevel";
            this.CB_QuizzLevel.Size = new System.Drawing.Size(164, 29);
            this.CB_QuizzLevel.TabIndex = 4;
            // 
            // CB_OperationType
            // 
            this.CB_OperationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_OperationType.Font = new System.Drawing.Font("Unispace", 10F);
            this.CB_OperationType.FormattingEnabled = true;
            this.CB_OperationType.Items.AddRange(new object[] {
            "+ Addition",
            "- Subtraction",
            "* Multiplication",
            "/ Division",
            "Mixed"});
            this.CB_OperationType.Location = new System.Drawing.Point(381, 302);
            this.CB_OperationType.Name = "CB_OperationType";
            this.CB_OperationType.Size = new System.Drawing.Size(198, 28);
            this.CB_OperationType.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(122, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Operation Type :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Unispace", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(37, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number Of Parts In Ques :";
            // 
            // numericUpDown_FieldsNumber
            // 
            this.numericUpDown_FieldsNumber.Font = new System.Drawing.Font("Unispace", 11F, System.Drawing.FontStyle.Bold);
            this.numericUpDown_FieldsNumber.Location = new System.Drawing.Point(441, 382);
            this.numericUpDown_FieldsNumber.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_FieldsNumber.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_FieldsNumber.Name = "numericUpDown_FieldsNumber";
            this.numericUpDown_FieldsNumber.Size = new System.Drawing.Size(106, 29);
            this.numericUpDown_FieldsNumber.TabIndex = 7;
            this.numericUpDown_FieldsNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // BT_StartQuizz
            // 
            this.BT_StartQuizz.BackColor = System.Drawing.Color.Wheat;
            this.BT_StartQuizz.FlatAppearance.BorderSize = 4;
            this.BT_StartQuizz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.BT_StartQuizz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.BT_StartQuizz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_StartQuizz.Font = new System.Drawing.Font("Kelson Sans RU Normal", 19F);
            this.BT_StartQuizz.ForeColor = System.Drawing.Color.Black;
            this.BT_StartQuizz.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.BT_StartQuizz.IconColor = System.Drawing.Color.CornflowerBlue;
            this.BT_StartQuizz.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BT_StartQuizz.Location = new System.Drawing.Point(287, 464);
            this.BT_StartQuizz.Name = "BT_StartQuizz";
            this.BT_StartQuizz.Size = new System.Drawing.Size(238, 76);
            this.BT_StartQuizz.TabIndex = 9;
            this.BT_StartQuizz.Text = "Start Quizz";
            this.BT_StartQuizz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_StartQuizz.UseVisualStyleBackColor = false;
            this.BT_StartQuizz.Click += new System.EventHandler(this.BT_StartQuizz_Click);
            // 
            // SettingsGame_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Math_Game.Properties.Resources.MathSettings;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 568);
            this.Controls.Add(this.BT_StartQuizz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_FieldsNumber);
            this.Controls.Add(this.CB_OperationType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_QuizzLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericUD_NumberOfQuestions);
            this.Controls.Add(this.iconButton1);
            this.Name = "SettingsGame_Form";
            this.Text = "Math Game";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUD_NumberOfQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FieldsNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.NumericUpDown NumericUD_NumberOfQuestions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_QuizzLevel;
        private System.Windows.Forms.ComboBox CB_OperationType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_FieldsNumber;
        private FontAwesome.Sharp.IconButton BT_StartQuizz;
    }
}

