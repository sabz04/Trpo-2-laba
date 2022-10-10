using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Trpo_2_laba
{
    /// <summary>
    /// Логика взаимодействия для Working_Window.xaml
    /// </summary>
    public partial class Working_Window : Window
    {
        private DispatcherTimer timer = null;
        public Working_Window()
        {
            
            InitializeComponent();
            Timer();
        }
        private void Disp()
        {

        }
        void Timer()
        {
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(Print);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            timer.Start();
        }
        private void Print(object sender, EventArgs e)
        {
            prgBar.Value += 3;
        }
    }
}
