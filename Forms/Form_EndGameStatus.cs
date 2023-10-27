using Math_Game.Classes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Math_Game.Forms.ClassExam;

namespace Math_Game.Forms
{
    public partial class Form_EndGameStatus : Form
    {

        private String _isPass()
        {
            return (clsGameSettings.RightAnswersCounter > clsGameSettings.WrongAnswersCounter) ? "Pass" : "Fail";
        }

        private Queue<clsQuestionInfo> _QuestionsQueue;
        int k;
        public Form_EndGameStatus(ref Queue<clsQuestionInfo> QuestionsQueue)
        {
            InitializeComponent();


            LB_RightAnswersReult.Text = clsGameSettings.RightAnswersCounter.ToString();
            LB_WrongAnswersResult.Text = clsGameSettings.WrongAnswersCounter.ToString();

            LB_OperationType.Text = clsGameSettings.OperationType.ToString();
            LB_QuestionLevelResult.Text = clsGameSettings.QuizzLevel.ToString();
            LB_FinalResult.Text = _isPass();
            LB_Percentage.Text = ((clsGameSettings.RightAnswersCounter * 100) / clsGameSettings.NumberOfQuestions).ToString() + "%";

            this._QuestionsQueue = QuestionsQueue;



            ww();
        }

        byte NumberOfQuestionCounter = 1;

        string ConvertQuestionInfoToStringRecord()
        {
            string QuestionInfoStringRecord = "";

            if (_QuestionsQueue.Peek().IsRightAnswer())//✅
                QuestionInfoStringRecord += $"Question {NumberOfQuestionCounter++}/{clsGameSettings.NumberOfQuestions} {Environment.NewLine}" +
                    $"{_QuestionsQueue.Peek().QuestionString} {_QuestionsQueue.Peek().RightAnswer}  ✅";

            else
                QuestionInfoStringRecord += $"Question {NumberOfQuestionCounter++}/{clsGameSettings.NumberOfQuestions} {Environment.NewLine}" +
                     $"{_QuestionsQueue.Peek().QuestionString} {_QuestionsQueue.Peek().UserAnswerChoice} ❌  = {_QuestionsQueue.Peek().RightAnswer}";

            return QuestionInfoStringRecord;
        }

        private void ww()
        {
            LB_QuestionResult.Text = ConvertQuestionInfoToStringRecord();
            _QuestionsQueue.Dequeue();
            LB_QuestionResult.Margin = new System.Windows.Forms.Padding(0);
            if (_QuestionsQueue.Count > 0)
            {
                for (int i = 1; i < clsGameSettings.NumberOfQuestions; i++)
                {
                    Label QInfoLabel = new Label();

                    QInfoLabel.Size = LB_QuestionResult.Size;
                    QInfoLabel.Font = LB_QuestionResult.Font;




                    this.panel1.Controls.Add(QInfoLabel);
                    QInfoLabel.Dock = DockStyle.Top;

                    QInfoLabel.Text = ConvertQuestionInfoToStringRecord();
                    _QuestionsQueue.Dequeue();


                }
            }
        }
    }
}
