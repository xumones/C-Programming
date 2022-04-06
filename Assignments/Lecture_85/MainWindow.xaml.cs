using System;
using System.Collections.Generic;
using System.Collections;
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

namespace Assignment_85_Rawipote_P
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Add(TextBoxKey.Text.ToString(), TextBoxValue.Text.ToString());
            MessageBox.Show("Add : " + TextBoxKey.Text + " = " + TextBoxValue.Text + " into your list");
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Remove(TextBoxKey.Text);
            MessageBox.Show("Delete : " + TextBoxKey.Text + " from your list");
        }

        private void ShowBtn_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;
            foreach(string key in icollection)
            {
                MessageBox.Show(hashtable[key].ToString());
            }
            MessageBox.Show("Count : " + hashtable.Count.ToString());
        }

        private void TextBoxKey_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxKey.Text = "";
        }

        private void TextBoxValue_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxValue.Text = "";
        }
    }
}
