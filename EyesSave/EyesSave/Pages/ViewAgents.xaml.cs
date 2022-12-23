using System.Linq;
using System.Windows.Controls;
using EyesSave.Entities;

namespace EyesSave.Pages
{
    /// <summary>
    /// Логика взаимодействия для ViewAgents.xaml
    /// </summary>
    public partial class ViewAgents : Page
    {

        public ViewAgents()
        {
            InitializeComponent();
            SetTypeBox();
            SetSortBox();
            UpdateSource();
        }

        private void SetTypeBox()
        {
            var types = EyesSaveEntities.GetConnect().AgentType.ToList();

            types.Insert(0, new AgentType()
            {
                Title = "Все типы"
            });

            TypeBox.ItemsSource = types;

            TypeBox.SelectedIndex = 0;
        }
        private void SetSortBox()
        {
            var source = new string[] { "Приоритет(убыв.)", "Приоритет(возв.)" };

            SortBox.ItemsSource = source;
            SortBox.SelectedIndex = 0;
        }

        private void UpdateSource()
        {
            var agents = EyesSaveEntities.GetConnect().Agent.ToList();

            if (TypeBox.SelectedIndex > 0)
            {
                agents = agents.Where(x => x.AgentType.Equals(TypeBox.SelectedItem as AgentType)).ToList();
            }

            if (!string.IsNullOrWhiteSpace(SearchBox.Text))
            {
                agents = agents.Where(x => x.Title.ToLower().Contains(SearchBox.Text.ToLower()) || x.Phone.ToLower().Contains(SearchBox.Text.ToLower())).ToList();
            }

            switch (SortBox.SelectedValue)
            {
                case "Приоритет(убыв.)":
                    agents = agents.OrderByDescending(x => x.Priority).ToList();
                    break;
                case "Приоритет(возв.)":
                    agents = agents.OrderBy(x => x.Priority).ToList();
                    break;
            }

            AgentsLV.ItemsSource = agents;
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateSource();
        }

        private void TypeBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateSource();
        }

        private void SortBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateSource();
        }

        private void BtnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Windows.AddEditPage addEditPage = new Windows.AddEditPage();
            addEditPage.ShowDialog();
        }
    }
}
