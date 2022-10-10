﻿using System;
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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Trpo_2_laba
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Water> waterCol = new List<Water>();
        public static Water curWater;
        public static int curPrice = 0;
        public static int Change;
        private DispatcherTimer timer = null;

        public MainWindow()
        {
            InitializeComponent();
            waterCol.AddRange(new List<Water>() {
            new Water("Вода газ. 0.5л",0.5, 10),
            new Water("Вода негаз. 0.5л",0.5, 5),
            new Water("Вода газ. 1л",1, 50),
            new Water("Вода негаз. 1л",1, 30)
            });
            timer = null;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void water_gas_5_Click(object sender, RoutedEventArgs e)
        {
            dispTB.Text = waterCol[0].Name + $"\n К оплате: {waterCol[0].Price}₽";
            curWater = waterCol[0];
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(curWater == null)
            {
                MessageBox.Show("Выберите товар!");
                return;
            }
            switch ((sender as Button).Content.ToString())
            {
                case "100₽":
                    curPrice += 100;
                    Change = curPrice - curWater.Price;
                    disp_rubTB.Text = curPrice.ToString() + $"\n Сдача: {Change}₽";
                    break;
                case "50₽":
                    curPrice += 50;
                    Change = curPrice - curWater.Price;
                    disp_rubTB.Text = curPrice.ToString() + $"\n Сдача: {Change}₽";
                    break;
                case "10₽":
                    curPrice += 10;
                    Change = curPrice - curWater.Price;
                    disp_rubTB.Text = curPrice.ToString() + $"\n Сдача: {Change}₽";
                    break;
                case "5₽":
                    curPrice += 5;
                    Change = curPrice - curWater.Price;
                    disp_rubTB.Text = curPrice.ToString() + $"\n Сдача: {Change}₽";
                    break;
                case "2₽":
                    curPrice += 2;
                    Change = curPrice - curWater.Price;
                    disp_rubTB.Text = curPrice.ToString() + $"\n Сдача: {Change}₽";
                    break;
                case "1₽":
                    curPrice += 1;
                    Change = curPrice - curWater.Price;
                    disp_rubTB.Text = curPrice.ToString() + $"\n Сдача: {Change}₽";
                    break;
                default:
                    break;
            }
            
        }
        
       
        private void clearBTN_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private string Change_Calc(int change)
        {
            int main_counter = 0;

            int chg_temp = change;

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

            string str = "";
            for(int i = 0; i < main_counter; i--)
            {
                if (chg_temp_counter_100 > 0)
                {
                    str += "+100";
                    chg_temp_counter_100--;
                }
                if (chg_temp_counter_50 > 0)
                {
                    str += "+50";
                    chg_temp_counter_50--;
                }
                if (chg_temp_counter_10 > 0)
                {
                    str += "+10";
                    chg_temp_counter_10--;
                }
                if (chg_temp_counter_5 > 0)
                {
                    str += "+5";
                    chg_temp_counter_5--;
                }
                if (chg_temp_counter_2 > 0)
                {
                    str += "+2";
                    chg_temp_counter_2--;
                }
                if (chg_temp_counter_1 > 0)
                {
                    str += "+1";
                    chg_temp_counter_1--;
                }
            }

            return str;


        }
        private void payBTN_Click(object sender, RoutedEventArgs e)
        {
            if (curWater == null)
            {
                MessageBox.Show("Выберите товар!");
                return;
            }
            if (Change < 0)
            {
                MessageBox.Show("Недостаточно средств!");
                return;
            }
            Working_Window working_Window = new Working_Window();
            working_Window.Show();
            this.Hide();
            MessageBox.Show($"Спасибо за покупку!\nВаша сдача: {Change_Calc(Change)}₽");
            working_Window.Close();
            this.Show();
            Clear();
        }
        private void Clear()
        {
            curPrice = 0;
            Change = 0;
            curWater = null;
            dispTB.Text = "Выберите товар...";
            disp_rubTB.Text = "Баланс...";
        }

        private void water_ungas_5_Click(object sender, RoutedEventArgs e)
        {
            dispTB.Text = waterCol[1].Name + $"\n К оплате: {waterCol[1].Price}₽";
            curWater = waterCol[1];
        }

        private void water_gas_1_Click(object sender, RoutedEventArgs e)
        {
            dispTB.Text = waterCol[2].Name + $"\n К оплате: {waterCol[2].Price}₽";
            curWater = waterCol[2];
        }

        private void water_ungas_1_Click(object sender, RoutedEventArgs e)
        {
            dispTB.Text = waterCol[3].Name + $"\n К оплате: {waterCol[3].Price}₽";
            curWater = waterCol[3];
        }
    }
}
