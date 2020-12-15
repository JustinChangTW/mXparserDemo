using Scriban;
using System;

namespace mXparserDemo.Utilites
{
    public class TextRenderUtil
    {
        public string Render(string template, Func<Object> func)
        {
            return Template.Parse(template).Render(func());
        }
    }
}
