namespace Interpreter.TerminalElement.Class
{
    public class KeyWord : Expression.Expression
    {
        protected string keyWord;

        public KeyWord(string keyWord) => this.keyWord = keyWord;

        public override bool Evaulate(string description) => description.IndexOf(description) != -1;

        public static new Expression.Expression Parse()
        {
            Expression.Expression result = new KeyWord(piece);
            NextPiece();

            return result;
        }
    }
}
