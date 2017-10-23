using Interpreter.Operator.Class;
using Interpreter.TerminalElement.Class;
using System;

namespace Interpreter.Expression
{
    public abstract class Expression
    {
        public abstract bool Evaulate(string description);

        protected static string source;
        protected static int index;
        protected static string piece;

        protected static void NextPiece()
        {
            while ((index < source.Length) && (source[index] == ' '))
                index++;

            if (index == source.Length)
                piece = null;
            else if ((source[index] == '(') || (source[index] == ')'))
            {
                piece = source.Substring(index, 1);
                index++;
            }
            else
            {
                int start = index;

                while ((index < source.Length) && (source[index] != ' ') && (source[index] != ')'))
                    index++;

                piece = source.Substring(start, index - start);
            }
        }

        public static Expression Analize(string source)
        {
            Expression.source = source;
            index = 0;
            NextPiece();

            return OperatorO.Parse();
        }

        public static Expression Parse()
        {
            Expression result;

            if (piece == "(")
            {
                NextPiece();

                result = OperatorO.Parse();

                if (piece == null)
                    throw new Exception("Sintax Error");

                if (piece != ")")
                    throw new Exception("Sintax Error");

                NextPiece();
            }
            else
                result = KeyWord.Parse();

            return result;
        }
    }
}
