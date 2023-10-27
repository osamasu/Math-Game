using Math_Game.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Math_Game.Forms
{
    public partial class ClassExam : Form
    {
        public clsGameSettings GameSettings;

        public ClassExam(clsGameSettings _GameSettings)
        {
            InitializeComponent();


            GameSettings = _GameSettings;

            LB_NumberOfAnsweredQuestions.Text = $"{CurrentQuestion}/{clsGameSettings.NumberOfQuestions}";
            _GenerateQuestions();

            initQuestion();
        }

        float _Generate_IncorrectNumber()
        {
            float GeneratedNumber;
            //do
            //{
            //    GeneratedNumber = _GenerateNumber();

            //} while (GeneratedNumber == _QuestionsQueue.Peek().RightAnswer);


            if (Rnd.Next(0, 2) == 1)
            {
                GeneratedNumber = _QuestionsQueue.Peek().RightAnswer + Rnd.Next(1, 3);
            }
            else
            {
                GeneratedNumber = _QuestionsQueue.Peek().RightAnswer - Rnd.Next(1, 3);
            }

            return GeneratedNumber;
        }

        private void _FillButtonsWithChoiceValues()
        {
            if (button1 != _QuestionsQueue.Peek().Btn_RightAnswer)
            {
                button1.Text = _Generate_IncorrectNumber().ToString();
            }
            if (button2 != _QuestionsQueue.Peek().Btn_RightAnswer)
            {
                button2.Text = _Generate_IncorrectNumber().ToString();
            }
            if (button3 != _QuestionsQueue.Peek().Btn_RightAnswer)
            {
                button3.Text = _Generate_IncorrectNumber().ToString();
            }
            if (button4 != _QuestionsQueue.Peek().Btn_RightAnswer)
            {
                button4.Text = _Generate_IncorrectNumber().ToString();
            }
        }

        private void initQuestion()
        {
            LB_Question.Text = _QuestionsQueue.Peek().QuestionString;
            LB_Question.Text += "?";

            _FillButtonsWithChoiceValues();
            _QuestionsQueue.Peek().Btn_RightAnswer.Text = _QuestionsQueue.Peek().RightAnswer.ToString();


        }


        private Random Rnd = new Random();


        private Queue<clsQuestionInfo> _QuestionsInfoDetailes = new Queue<clsQuestionInfo>();


        //----------------------------- To Generate Questions 
        public class clsQuestionInfo
        {
            public clsGameSettings.enOperationType[] QuestionOperations;
            public float[] QuestionNumbers;
            public Button Btn_RightAnswer;
            public float RightAnswer = new float();
            public String QuestionString = String.Empty;
            public float UserAnswerChoice;

            public bool IsRightAnswer()
            {
                return (UserAnswerChoice == RightAnswer);
            }

            public clsQuestionInfo(byte NumberOfFieldsInEveryQuestion)
            {
                QuestionOperations = new clsGameSettings.enOperationType[NumberOfFieldsInEveryQuestion - 1];
                QuestionNumbers = new float[NumberOfFieldsInEveryQuestion];
            }
        }
        private Queue<clsQuestionInfo> _QuestionsQueue = new Queue<clsQuestionInfo>();

        private float _GenerateNumber()
        {
            switch (clsGameSettings.QuizzLevel)
            {
                case clsGameSettings.enQuizzLevel.Easy:
                    return Rnd.Next(1, 12);

                case clsGameSettings.enQuizzLevel.Medium:
                    return Rnd.Next(12, 25);

                case clsGameSettings.enQuizzLevel.Hard:
                    return Rnd.Next(26, 80);

                case clsGameSettings.enQuizzLevel.Mixed:
                    return Rnd.Next(1, 80);

                default:
                    return 0;
            }
        }
        private clsGameSettings.enOperationType _DicadeOperation()
        {
            switch (clsGameSettings.OperationType)
            {
                case clsGameSettings.enOperationType.Addition:
                    return clsGameSettings.enOperationType.Addition;

                case clsGameSettings.enOperationType.Subtraction:
                    return clsGameSettings.enOperationType.Subtraction;

                case clsGameSettings.enOperationType.Multiplication:
                    return clsGameSettings.enOperationType.Multiplication;

                case clsGameSettings.enOperationType.Division:
                    return clsGameSettings.enOperationType.Division;

                default:
                    return (clsGameSettings.enOperationType)Rnd.Next(4);
            }
        }
        private Button _GetRandomButton()
        {
            Byte ButtonNumber = (byte)Rnd.Next(1, 5);
            return (ButtonNumber == 1) ? button1 : ((ButtonNumber == 2) ? button2 : (ButtonNumber == 3) ? button3 : button4);
        }
        private void _CalcRightAnswer(ref clsQuestionInfo Question)
        {
            float Result = Question.QuestionNumbers[0];

            for (Byte i = 0; i < clsGameSettings.NumberOfFieldsInEveryQuestion - 1; i++)
            {
                switch (Question.QuestionOperations[i])
                {
                    case clsGameSettings.enOperationType.Addition:
                        Result += Question.QuestionNumbers[i + 1];
                        break;

                    case clsGameSettings.enOperationType.Subtraction:
                        Result -= Question.QuestionNumbers[i + 1];
                        break;

                    case clsGameSettings.enOperationType.Multiplication:
                        Result *= Question.QuestionNumbers[i + 1];
                        break;

                    case clsGameSettings.enOperationType.Division:
                        Result /= Question.QuestionNumbers[i + 1];
                        break;
                }
            }

            Question.RightAnswer = Result;
        }
        private char _GetOperationPrefix(clsGameSettings.enOperationType OperationType)
        {
            switch (OperationType)
            {
                case clsGameSettings.enOperationType.Addition:
                    return '+';

                case clsGameSettings.enOperationType.Subtraction:
                    return '-';

                case clsGameSettings.enOperationType.Multiplication:
                    return '*';
                case clsGameSettings.enOperationType.Division:
                    return '/';

                default:
                    return '\0';
            }
        }
        public clsQuestionInfo _GenerateQuestion()
        {
            clsQuestionInfo Question = new clsQuestionInfo(clsGameSettings.NumberOfFieldsInEveryQuestion);

            for (byte i = 1; i <= clsGameSettings.NumberOfFieldsInEveryQuestion; i++)
            {
                Question.QuestionNumbers[i - 1] = _GenerateNumber();
                Question.QuestionString += " " + Question.QuestionNumbers[i - 1];

                if (i != clsGameSettings.NumberOfFieldsInEveryQuestion)
                {
                    Question.QuestionOperations[i - 1] = _DicadeOperation();
                    Question.QuestionString += $" {_GetOperationPrefix(Question.QuestionOperations[i - 1])}";
                }
            }

            Question.QuestionString += " = ";
            Question.Btn_RightAnswer = _GetRandomButton();

            _CalcRightAnswer(ref Question);
            return Question;
        }
        public void _GenerateQuestions()
        {
            for (int i = 0; i < clsGameSettings.NumberOfQuestions; i++)
            {
                _QuestionsQueue.Enqueue(_GenerateQuestion());
            }

        }

        //-----------------------------------------------------


        byte ComletedQuestionsCounter = 1;
        private void _NextQuestion()
        {



            if (ComletedQuestionsCounter != clsGameSettings.NumberOfQuestions)
            {
                _QuestionsInfoDetailes.Enqueue(_QuestionsQueue.Peek());
                _QuestionsQueue.Dequeue();
                initQuestion();
                ComletedQuestionsCounter++;

            }
            else
            {
                _QuestionsInfoDetailes.Enqueue(_QuestionsQueue.Peek());
                Form GameOverForm = new Form_EndGameStatus(ref _QuestionsInfoDetailes);
                GameOverForm.ShowDialog();
                EndExam();
                return;
            }


            button1.BackColor = Color.Khaki;
            button2.BackColor = Color.Khaki;
            button3.BackColor = Color.Khaki;
            button4.BackColor = Color.Khaki;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

        }






        private float GameTime = new float();
        int CurrentQuestion = 1;
        private void GameTimer_Tick(object sender, System.EventArgs e)
        {
            GameTime += 0.130f;
            LB_GameTimer.Text = GameTime.ToString().Substring(0, GameTime.ToString().IndexOf('.') + 2);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button ClickedButton = (Button)sender;

            _QuestionsQueue.Peek().UserAnswerChoice = float.Parse(ClickedButton.Text);


            _QuestionsQueue.Peek().Btn_RightAnswer.BackColor = Color.Lime;

            if (!_QuestionsQueue.Peek().IsRightAnswer())
            {
                ClickedButton.BackColor = Color.Crimson;
                clsGameSettings.WrongAnswersCounter++;

                LB_WrongAnswerCounter.Text = clsGameSettings.WrongAnswersCounter.ToString();
            }

            else
            {
                clsGameSettings.RightAnswersCounter++;
                LB_CorrectAnswersCounter.Text = clsGameSettings.RightAnswersCounter.ToString();

            }

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;



            Thread.Sleep(1000);
            _NextQuestion();
            LB_NumberOfAnsweredQuestions.Text = $"{++CurrentQuestion}/{clsGameSettings.NumberOfQuestions}";
        }

        private void EndExam()
        {

            GameTimer.Enabled = false;

            GameTimer.Stop();
            this.Close();
        }

        private void WaitToNextQuestion_Tick(object sender, EventArgs e)
        {




        }
    }
}