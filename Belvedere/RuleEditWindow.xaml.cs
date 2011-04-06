using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Belvedere
{
    /// <summary>
    /// Interaction logic for RuleEditWindow.xaml
    /// </summary>
    public partial class RuleEditWindow : Window
    {
        private BelevdereRule br;
        private StackPanel conditions;
        public RuleEditWindow()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            conditions = new StackPanel();
            foreach(BelvedereCondition bc in br.Conditions)
            {
                conditions.Children.Add(bc);
            }
    }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        
        }
}
