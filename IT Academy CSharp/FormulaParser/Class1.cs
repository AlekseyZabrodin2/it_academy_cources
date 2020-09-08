using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormulaParser
{
    public class FormulaParser
    {
        public double CalculateFormula(string formulaTemplate, Dictionary<string, double> values)
        {
            var formula = formulaTemplate.Replace(" ", "");
            foreach (var pair in values)
            {
                formula = formula.Replace($"[{pair.Key}]", pair.Value.ToString());
            }
            //10+2*12*2+5
            List<string> elements = new List<string>();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < formula.Length; i++)
            {
                if (!IsOperation(formula[i]))
                {
                    stringBuilder.Append(formula[i]);
                }
                else
                {
                    elements.Add(stringBuilder.ToString());
                    elements.Add(formula[i].ToString());
                    stringBuilder.Clear();
                }
            }
            elements.Add(stringBuilder.ToString());

            double result = 0;
            double? operand1 = null;
            double? operand2 = null;
            string operation = "";
            foreach (var element in elements)
            {
                if (!IsOperation(element.ToCharArray()[0]) && operand1 == null)
                {
                    operand1 = double.Parse(element);
                }
                else if (IsOperation(element.ToCharArray()[0]))
                {
                    operation = element;
                }
                else
                {
                    operand2 = double.Parse(element);
                    switch (operation)
                    {
                        case "+":
                            result = operand1.Value + operand2.Value;
                            break;
                        case "-":
                            result = operand1.Value - operand2.Value;
                            break;
                        case "*":
                            result = operand1.Value * operand2.Value;
                            break;
                        case "/":
                            result = operand1.Value / operand2.Value;
                            break;
                    }
                    operand1 = result;
                }
            }

            return result;

        }

        private bool IsOperation(char sumbol)
        {
            char[] operations = new char[] { '+', '-', '*', '/' };
            return (operations.Contains(sumbol));           
        }
    }
}