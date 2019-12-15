using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using COCOMOCalculator.Core;

namespace COCOMOCalculator.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Core.COCOMOCalculator _calculator;
        public ObservableCollection<CostDriverRow> CostDrivers { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            var costDriversRegistry = new CostDriverRegistry();
            var costDriversList = costDriversRegistry.GetAllCostDrivers();
            this.CostDrivers = new ObservableCollection<CostDriverRow>();
            CostDriverDg.ItemsSource = CostDrivers;
            costDrivers.ItemsSource = costDriversList.Select(i => i.Name).ToList();
        }

        private void AddCostdriver_Click(object sender, RoutedEventArgs e)
        {
            var costDriversRegistry = new CostDriverRegistry();
            if (costDrivers.SelectedIndex != -1 && costDriverRatings.SelectedIndex != -1) {
                CostDrivers.Add(new CostDriverRow()
                {
                    Attribute = costDrivers.SelectedValue.ToString(),
                    Rate = costDriverRatings.SelectedValue.ToString(),
                    Value = costDriversRegistry.GetCostDriver(costDrivers.SelectedValue.ToString())
                    .RatingValue[(CostDriverRating)Enum.Parse(typeof(CostDriverRating), costDriverRatings.SelectedValue.ToString())]
                }); 
            }
        }

        private void CalculateEffort_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var effort = this._calculator.CalculateEffort(int.Parse(projectSizeTextBox.Text));
                effortLabel.Content = effort.ToString();
            }
            catch
            {
                Console.WriteLine("Error occured");
            }
        }

        private void onModeChange(object sender, SelectionChangedEventArgs e)
        {
            var mode = (COCOMOMode)selectedMode.SelectedIndex;
            this._calculator = new Core.COCOMOCalculator(mode);
        }

        private void CalculateDevTime_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var effort = this._calculator.CalculateEffort(int.Parse(projectSizeTextBox.Text));
                var tdev = this._calculator.CalculateTDev(effort);
                devTimeLabel.Content = tdev.ToString();
            }
            catch
            {
                Console.WriteLine("Error occured");
            }
        }

        private void costDrivers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var registry = new CostDriverRegistry();
            var costDriverName = costDrivers.SelectedValue.ToString();
            var costDriver = registry.GetCostDriver(costDriverName);
            costDriverRatings.ItemsSource = costDriver.GetRatings();           
        }

        private void CalculateActualEffort_Click(object sender, RoutedEventArgs e)
        {
            var costDriverValues = CostDriverDg.Items.OfType<CostDriverRow>().ToList().Select(i => i.Value).ToList();
            try
            {
                var eaf = this._calculator.CalculateEAF(costDriverValues);
                var effort = this._calculator.CalculateEffort(int.Parse(projectSizeTextBox.Text));
                var actualEffort = this._calculator.CalculateActualEffort(effort, eaf);
                actualEffortLabel.Content = actualEffort.ToString();

            }
            catch
            {
                Console.WriteLine("Error occured");
            }

        }

        private void CostDriverDg_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }
    }
    public class CostDriverRow
    {
        public string Attribute { get; set; }
        public string Rate { get; set; }
        public double Value { get; set; }

    }
}
