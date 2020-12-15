using mXparserDemo.Utilites;
using System;
using System.Collections.Generic;
using System.Text;

namespace mXparserDemo.Service
{
    public class CalculateService
    {
        private readonly TextCalculateUtil _textCalculateUtil;
        private readonly TextRenderUtil _textRenderUtil;

        public CalculateService()
        {
            _textCalculateUtil = new TextCalculateUtil();
            _textRenderUtil = new TextRenderUtil();
        }

        public double Calculate(string formula, Func<Object> func)
        {
            return _textCalculateUtil.Calculate(_textRenderUtil.Render(formula, func));
        }
    }
}
