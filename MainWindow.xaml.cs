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
            const int lunchTime = 1;

            //Week days
            var monday = TimeSpan.Parse(txtMonday.Text).TotalHours;
            var tuesday = TimeSpan.Parse(txtTuesday.Text).TotalHours;
            var wednesday = TimeSpan.Parse(txtWednesday.Text).TotalHours;
            var thursday = TimeSpan.Parse(txtThursday.Text).TotalHours;

            //Total values
            var weekHours = int.Parse(txtWeekHours.Text);
            var startHour = TimeSpan.Parse(txtStartHour.Text);

            //Calcs
            var totalHours = weekHours - (monday + tuesday + wednesday + thursday);

            //Print
            lblRemainHours.Content = TimeSpan.FromHours(totalHours).ToString();
            lblEndHour.Content = TimeSpan.FromHours(startHour.TotalHours + totalHours + lunchTime);
        }
    }
}