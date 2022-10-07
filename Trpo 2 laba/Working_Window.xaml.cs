using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Trpo_2_laba
{
    /// <summary>
    /// Логика взаимодействия для Working_Window.xaml
    /// </summary>
    public partial class Working_Window : Window
    {
        
        public Working_Window(int change)
        {
            
            InitializeComponent();
            Disp(change);
        }
        private void Disp(int change)
        {

            //for (int i = 0; i <= 10; i++)
            //{
            //    prgBar.Value = i;
            //    //Thread.Sleep(1000);

           
        }
    }
}
