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

namespace Lec85
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
        private void btRemove_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Remove(txtKey.Tag);
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Add(txtKey.Text, txtValue.Text);
        }

        private void btShow_Click(object sender, RoutedEventArgs e)
        {
            int i = 1;
            if (hashtable.Count == 0)
            {
                MessageBox.Show("No Data");
            }
            else
            {
                MessageBox.Show("Data " + hashtable.Count.ToString() + " item.");
            }

            ICollection icollection = hashtable.Keys;
            foreach (string key in icollection)
            {

                MessageBox.Show(hashtable[key].ToString(), "Data Number " + i.ToString());
                i++;
            }
        }
    }
}
