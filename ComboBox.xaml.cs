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
using System.Windows.Shapes;

namespace MyWPFApp
{
    /// <summary>
    /// Interaction logic for ComboBox.xaml
    /// </summary>
    public partial class ComboBox : Window
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void cboColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var stackPannel = (StackPanel) cboColor.SelectedItem;
            var label = stackPannel.Children[1] as Label;
            string color = label.Content.ToString();
            lbMsg.Content = "Your color is " + color;
        }
    }
}
