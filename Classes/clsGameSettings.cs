namespace Math_Game.Classes
{
    public class clsGameSettings
    {

        public static byte NumberOfQuestions;

        public static byte NumberOfFieldsInEveryQuestion;

        public enum enQuizzLevel { Easy, Medium, Hard, Mixed };

        public enum enOperationType
        {
            Addition, Subtraction, Multiplication, Division, Mixed
        }

        public static byte RightAnswersCounter = 0;
        public static byte WrongAnswersCounter = 0;

        public static enQuizzLevel QuizzLevel;
        public static enOperationType OperationType;
    }

}
