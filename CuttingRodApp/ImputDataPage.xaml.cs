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
    /// Interaction logic for ImputDatePage.xaml
    /// </summary>
    public partial class ImputDatePage : Page
    {
        List<DataImput> listDI = new List<DataImput>()
        {
            DataImput.BuildDataImput(1, 1),
            DataImput.BuildDataImput(2, 5),
            DataImput.BuildDataImput(3, 8),
            DataImput.BuildDataImput(4, 9),
            DataImput.BuildDataImput(5, 10),
            DataImput.BuildDataImput(6, 17),
            DataImput.BuildDataImput(7, 17),
            DataImput.BuildDataImput(8, 20),
            DataImput.BuildDataImput(9, 24),
            DataImput.BuildDataImput(10, 30)
        };

        public ImputDatePage()
        {
            InitializeComponent();

            listOfRods.ItemsSource = listDI;
           
        }

        private void ShowResults_Click(object sender, RoutedEventArgs e)
        {
            if (listOfRods.SelectedIndex >= 0)
            {
                SolutionPage solutionPage = new SolutionPage(listDI, listOfRods.SelectedIndex + 1); //dodajemy 1 bo nie ma długości 0
                this.NavigationService.Navigate(solutionPage);
            }
            else
            {
                MessageBox.Show("No rod selected!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }
    }
}
