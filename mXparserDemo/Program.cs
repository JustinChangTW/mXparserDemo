using mXparserDemo.Model;
using mXparserDemo.Service;
using org.mariuszgromada.math.mxparser;
using Scriban;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace mXparserDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculateService = new CalculateService();

            string formulaTemple = "{{arg.a}}+{{arg.b}}";

            var arg = new ParaModel() { a = 1, b = 2 };
            var arg2 = new ParaModel() { a = 1, b = 2 };


            var result = calculateService.Calculate(formulaTemple,()=> new {arg,arg2});
            Console.WriteLine(result);
        }
    }
}
