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

namespace Lab1Pt2
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

        public DateTime date_1;
        public DateTime date_2;

        private void BtnCalc_OnClick(object sender, RoutedEventArgs e)
        {
            if (Date1.SelectedDate != null && Date2.SelectedDate != null)
            {
                date_1 = Date1.SelectedDate.Value.Date;
                date_2 = Date2.SelectedDate.Value.Date;
                Console.WriteLine(date_1 + " and " + date_2);

                //long diffTicks = (date_2 - date_1).Ticks;
                //Console.WriteLine(diffTicks);

                TimeSpan span = date_2.Subtract(date_1);
                Console.WriteLine(span.TotalMinutes + " minutes");
                Console.WriteLine(span.TotalHours + " hours");
                Console.WriteLine(span.Days + " days");
            }
            else
            {
                Console.WriteLine("Please enter dates in the provided fields.");
            }
        }
    }
}
