using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuttingRodApp
{
    public class DataImput
    {
        public int RodsLength { get; private set; }
        public int RodsPrice { get; private set; }
        
        public static DataImput BuildDataImput(int length, int price)
        {
            DataImput dI = new DataImput();
            dI.RodsLength = length;
            dI.RodsPrice = price;

            return dI;
        }
    }
}
