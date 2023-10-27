using Math_Game.Classes;
using Math_Game.Forms;
using System.Windows.Forms;

namespace Math_Game
{
    public partial class SettingsGame_Form : Form
    {
        public SettingsGame_Form()
        {
            InitializeComponent();
            CB_QuizzLevel.SelectedIndex = 0;
            CB_OperationType.SelectedIndex = 0;
        }


        public clsGameSettings GameSettings;

        private void _InitSettingsToGame()
        {
            GameSettings = new clsGameSettings();
            clsGameSettings.NumberOfQuestions = (byte)NumericUD_NumberOfQuestions.Value;
            clsGameSettings.NumberOfFieldsInEveryQuestion = (byte)numericUpDown_FieldsNumber.Value;
            clsGameSettings.QuizzLevel = (clsGameSettings.enQuizzLevel)CB_QuizzLevel.SelectedIndex;
            clsGameSettings.OperationType = (clsGameSettings.enOperationType)CB_OperationType.SelectedIndex;
        }
        private void BT_StartQuizz_Click(object sender, System.EventArgs e)
        {

            _InitSettingsToGame();

            Form Class = new ClassExam(GameSettings);
            this.Visible = false;
            Class.ShowDialog();
            this.Visible = true;
        }
    }
}
