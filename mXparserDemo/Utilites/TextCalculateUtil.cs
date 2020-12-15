using org.mariuszgromada.math.mxparser;

namespace mXparserDemo.Utilites
{
    public class TextCalculateUtil
    {
        public double Calculate(string formula)
        {
            Expression expression = new Expression(formula);
            return expression.calculate();
        }
    }
}
