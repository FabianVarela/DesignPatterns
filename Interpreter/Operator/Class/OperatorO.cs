using Interpreter.Operator.Abstract;

namespace Interpreter.Operator.Class
{
    public class OperatorO : BinaryOperator
    {
        public OperatorO(Expression.Expression leftOperator, Expression.Expression rightOperator)
            : base(leftOperator, rightOperator) { }

        public override bool Evaulate(string description)
        {
            return leftOperator.Evaulate(description) || rightOperator.Evaulate(description);
        }

        public static new Expression.Expression Parse()
        {
            Expression.Expression leftResult, rightResult;

            leftResult = OperatorY.Parse();

            while ((piece != null) && (piece == "o"))
            {
                NextPiece();

                rightResult = OperatorY.Parse();
                leftResult = new OperatorO(leftResult, rightResult);
            }

            return leftResult;
        }
    }
}
