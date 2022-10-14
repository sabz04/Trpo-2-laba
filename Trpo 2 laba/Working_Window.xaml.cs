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
        public static Working_Window wrk;
        public static int Chan = 0;
        public Working_Window(int chg)
        {
            
            InitializeComponent();
            Chan = chg;
            wrk = this;
            Thread myth = new Thread(Change_Calc);
            myth.Start();
        }
        public void Change_Calc()
        {
            
            int main_counter = 0;

            int chg_temp = int.Parse(Chan.ToString());

            List<int> nums = new List<int>();

            int chg_temp_counter_100 = 0;
            int chg_temp_counter_50 = 0;
            int chg_temp_counter_10 = 0;
            int chg_temp_counter_5 = 0;
            int chg_temp_counter_2 = 0;
            int chg_temp_counter_1 = 0;

            while (chg_temp >= 100)
            {
                chg_temp = chg_temp - 100;
                chg_temp_counter_100++;
                main_counter++;
                
            }

            while (chg_temp >= 50)
            {
                chg_temp = chg_temp - 50;
                chg_temp_counter_50++;
                main_counter++;
                
            }

            while (chg_temp >= 10)
            {
                chg_temp = chg_temp - 10;
                chg_temp_counter_10++;
                main_counter++;
            }

            while (chg_temp >= 5)
            {
                chg_temp = chg_temp - 5;
                chg_temp_counter_5++;
                main_counter++;
            }

            while (chg_temp >= 2)
            {
                chg_temp = chg_temp - 2;
                chg_temp_counter_2++;
                main_counter++;
               
            }

            while (chg_temp >= 1)
            {
                chg_temp = chg_temp - 1;
                chg_temp_counter_1++;
                main_counter++;
                
            }
            Dispatcher.Invoke(() => prgBar.Maximum = main_counter);
            Dispatcher.Invoke(() => prgBar.Value = 0);
            Random random = new Random();

            string str = "";
            for (int i = 0; i < main_counter; i++)
            {
                if (chg_temp_counter_100 > 0)
                {
                    str += "+100";
                    chg_temp_counter_100--;
                    Dispatcher.Invoke(() => prgBar.Value++);
                    Thread.Sleep(random.Next(300,2000));
                }
                if (chg_temp_counter_50 > 0)
                {
                    str += "+50";
                    chg_temp_counter_50--;
                    Dispatcher.Invoke(() => prgBar.Value++);
                    Thread.Sleep(random.Next(300, 2000));
                }
                if (chg_temp_counter_10 > 0)
                {
                    str += "+10";
                    chg_temp_counter_10--;
                    Dispatcher.Invoke(() => prgBar.Value++);
                    Thread.Sleep(random.Next(300, 2000));
                }
                if (chg_temp_counter_5 > 0)
                {
                    str += "+5";
                    chg_temp_counter_5--;
                    Dispatcher.Invoke(() => prgBar.Value++);
                    Thread.Sleep(random.Next(300, 2000));
                }
                if (chg_temp_counter_2 > 0)
                {
                    str += "+2";
                    chg_temp_counter_2--;
                    Dispatcher.Invoke(() => prgBar.Value++);
                    Thread.Sleep(random.Next(300, 2000));
                }
                if (chg_temp_counter_1 > 0)
                {
                    str += "+1";
                    chg_temp_counter_1--;
                    Dispatcher.Invoke(() => prgBar.Value++);
                    Thread.Sleep(random.Next(300, 2000));
                }
                
            }
            MessageBox.Show($"Ваша сдача: \n{str} = {Chan}");
            Console.WriteLine(str);
            Dispatcher.Invoke(wrk.Close);
            //return str;

        }
        void Timer()
        {
        }
        private void Print(object sender, EventArgs e)
        {
            
        }
    }
}
