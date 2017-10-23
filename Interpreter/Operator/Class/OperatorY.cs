using Interpreter.Operator.Abstract;

namespace Interpreter.Operator.Class
{
    public class OperatorY : BinaryOperator
    {
        public OperatorY(Expression.Expression leftOperator, Expression.Expression rightOperator)
            : base(leftOperator, rightOperator) { }

        public override bool Evaulate(string description)
        {
            return leftOperator.Evaulate(description) && rightOperator.Evaulate(description);
        }

        public static new Expression.Expression Parse()
        {
            Expression.Expression leftResult, rightResult;

            leftResult = Expression.Expression.Parse();

            while ((piece != null) && (piece == "y"))
            {
                NextPiece();

                rightResult = Expression.Expression.Parse();
                leftResult = new OperatorY(leftResult, rightResult);
            }

            return leftResult;
        }
    }
}
