using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment_84_Rawipote_P
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            arrayList.Add(TextBox_Data.Text);
            MessageBox.Show("Add : " + TextBox_Data.Text + " was go into your list");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            arrayList.Remove(TextBox_Data.Text);
            MessageBox.Show("Delete : " + TextBox_Data.Text + " gotaway from your list");

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            foreach (string data in arrayList)
            {
                MessageBox.Show(data);
            }
            MessageBox.Show("Count : " + arrayList.Count);
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox_Data.Text = "";
        }
    }
}
