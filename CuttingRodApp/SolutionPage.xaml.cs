using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CuttingRodApp
{
    /// <summary>
    /// Interaction logic for SolutionPage.xaml
    /// </summary>
    public partial class SolutionPage : Page
    {
        RodCuttingManager rodCuttingManager;
        private List<DataImput> listDI;

        public SolutionPage(List<DataImput> listDI, int size)
        {
            InitializeComponent();

            this.listDI = listDI;
            int[] sellingPrices = GetSellingPrices(listDI);
            rodCuttingManager = new RodCuttingManager(size, sellingPrices);
            resultLabel.Content = rodCuttingManager.GetRusult();

            titileLabel.Content = string.Format("Result for rod length: {0}", size);
        }

        private int[] GetSellingPrices(List<DataImput> listDI)
        {
            int[] result = new int[listDI.Count + 1];
            result[0] = 0;

            for (int i = 1; i <= listDI.Count; i++)
            {
                result[i] = listDI[i - 1].RodsPrice;
            }

            return result;
        }
    }
}
