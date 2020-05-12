using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CuttingRodApp
{
    public class RodCuttingManager
    {
        int rodSize;
        int[] sellingPrice;

        public RodCuttingManager(int rodSize, int[] sellingPrice)
        {
            this.rodSize = rodSize;
            this.sellingPrice = sellingPrice;
        }

        public string GetRusult()
        {
            string result = String.Empty;
            object obj = ButtomUpCutRodExtendedMethod(rodSize, sellingPrice);
            PropertyInfo[] infos = obj.GetType().GetProperties();

            foreach (PropertyInfo p in infos)
            {
                result += string.Format("{0}: {1}\n\n", p.Name, p.GetValue(obj));
            }
            return result;
        }

        private object ButtomUpCutRodExtendedMethod(int rodSize, int[] sellingPrice)
        {
            int[] results = new int[rodSize + 1];
            int[] subProblems = new int[rodSize + 1];

            for (int i = 1; i <= rodSize; i++)
            {
                int maxProfit = Int32.MinValue;
                for (int j = 0; j <= i; j++)
                {
                    if (results[i - j] + sellingPrice[j] > maxProfit)
                    {
                        maxProfit = results[i - j] + sellingPrice[j];
                        subProblems[i] = j;
                    }
                }
                results[i] = maxProfit;
            }

            return new { MaxProfit = results[rodSize], Solution = RodCutSolution(rodSize, subProblems)};
        }

        private string RodCutSolution(int rodSize, int[] subProblems)
        {
            string solution = string.Empty;
            int i = rodSize;

            while (i >= 1)
            {
                solution += subProblems[i];
                i -= subProblems[i];
                if (i >= 1)
                {
                    solution += " + ";
                }
            }
            return solution;
        }
    }
}
