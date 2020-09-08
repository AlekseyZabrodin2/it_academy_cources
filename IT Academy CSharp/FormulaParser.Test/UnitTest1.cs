using NUnit.Framework;
using System.Collections.Generic;

namespace FormulaParser.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string formula = "2 *[BankRate] *[Period]+ [Price]+ 5";
            Dictionary<string, double> dic = new Dictionary<string, double>();
            dic.Add("Price", 10);
            dic.Add("BankRate", 12);
            dic.Add("Period", 2);
            FormulaParser formulaParser = new FormulaParser();
            var result = formulaParser.CalculateFormula(formula, dic);
            Assert.AreEqual(63, result);
        }
        [Test]
        public void Test2()
        {
            string formula = "2 *[BankRate] *10/[Period]+ [Price]+ 5-10";
            Dictionary<string, double> dic = new Dictionary<string, double>();
            dic.Add("Price", 10);
            dic.Add("BankRate", 5);
            dic.Add("Period", 5);
            FormulaParser formulaParser = new FormulaParser();
            var result = formulaParser.CalculateFormula(formula, dic);
            Assert.AreEqual(25, result);
        }
    }
}