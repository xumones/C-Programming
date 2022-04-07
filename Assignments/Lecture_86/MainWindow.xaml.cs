using System;
using System.Collections;
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

namespace Assignment_86_Rawipote_P
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedlist;
        public MainWindow()
        {
            InitializeComponent();
            sortedlist = new SortedList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)    
        {
            sortedlist.Add(int.Parse(KeyTxt.Text) , ValueTxt.Text);
            string alldata = "";
            ICollection collection = sortedlist.Keys;
            foreach(int key in collection)
            {
                alldata = alldata + sortedlist[key].ToString() + ",";
            }
            MessageBox.Show(alldata);
        }

        private void KeyTxt_GotFocus(object sender, RoutedEventArgs e)
        {
            KeyTxt.Text = "";
        }

        private void ValueTxt_GotFocus(object sender, RoutedEventArgs e)
        {
            ValueTxt.Text = "";
        }
    }
}
