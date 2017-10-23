namespace Interpreter.Operator.Abstract
{
    public abstract class BinaryOperator : Expression.Expression
    {
        protected Expression.Expression leftOperator, rightOperator;

        public BinaryOperator(Expression.Expression leftOperator, Expression.Expression rightOperator)
        {
            this.leftOperator = leftOperator;
            this.rightOperator = rightOperator;
        }
    }
}
