﻿using System;
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

namespace Assignment_97_Rawipote_P
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataAccess.InitializeDatabase();
        }

        private void Add_Data_bt_Click(object sender, RoutedEventArgs e)
        {
            DataAccess.AddData(Text_input.Text);
            MessageBox.Show(Text_input.Text + " has been add into your list.");
        }

        private void Show_Data_bt_Click(object sender, RoutedEventArgs e)
        {
            string Dataresult = "";
            foreach (string data in DataAccess.GetData())
            {
                Dataresult = Dataresult + data + "\n";
            }
            MessageBox.Show(Dataresult);
        }

        private void Text_input_GotFocus(object sender, RoutedEventArgs e)
        {
            Text_input.Text = "";
        }
    }
}
