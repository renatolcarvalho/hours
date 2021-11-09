using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace HoursCalculation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDoThat_Click(object sender, RoutedEventArgs e)
        {
            var monday = TimeSpan.Parse(txtMonday.Text).TotalHours;
            var tuesday = TimeSpan.Parse(txtTuesday.Text).TotalHours;
            var wednesday = TimeSpan.Parse(txtWednesday.Text).TotalHours;
            var thursday = TimeSpan.Parse(txtThursday.Text).TotalHours;

            var totalHours = int.Parse(txtWeekHours.Text) - (monday + tuesday + wednesday + thursday);

            txtRemainHours.Text = TimeSpan.FromHours(totalHours).ToString();
        }
    }
}