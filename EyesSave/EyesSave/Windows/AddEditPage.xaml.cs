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
using EyesSave.Entities;

namespace EyesSave.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Window
    {
        private Agent _currentAgent = new Agent();
        public AddEditPage()
        {
            InitializeComponent();
            DataContext = _currentAgent;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EyesSaveEntities.GetConnect().Agent.Add(_currentAgent);
            }
            catch (Exception mes)
            {
                MessageBox.Show(mes.ToString());
            }
        }
    }
}
