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

namespace _1lub3raz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Time time = new Time();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void vsec_Click(object sender, RoutedEventArgs e)
        {
            time.Hours = Convert.ToInt32(Hours.Text);
            time.Minuts = Convert.ToInt32(Minuts.Text);
            time.Seconds = Convert.ToInt32(Seconds.Text);
            int SumSec = time.Hours * 3600 + time.Minuts * 60 + time.Seconds;
            SecAll.Text = Convert.ToString(SumSec);
        }
        private void pat_Click(object sender, RoutedEventArgs e)
        {

            time.Seconds += 5;
            if (time.Seconds >= 60)
            {
                time.Seconds -= 60;
                time.Minuts++;
                if (time.Minuts >= 60)
                {
                    time.Minuts = 0;
                    time.Hours++;
                    if (time.Hours >= 24) time.Hours = 0;
                }

            }
            Pat.Text = Convert.ToString(time.Hours) + ":" + Convert.ToString(time.Minuts) + ":" + Convert.ToString(time.Seconds);
        }
    }
}
