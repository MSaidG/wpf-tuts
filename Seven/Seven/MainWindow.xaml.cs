using System.Collections;
using System.Windows;

namespace Seven
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lvEntries.Items.Add("a");
            lvEntries.Items.Add("b");
            lvEntries.Items.Add("c");
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(txtEntry.Text);
            txtEntry.Clear();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            // SINGLE ITEM
            // int index = lvEntries.SelectedIndex;
            // lvEntries.Items.RemoveAt(index);

            // SINGLE ITEM
            //object item = lvEntries.SelectedItem;
            //var result = MessageBox.Show($"Are you sure you want ot delete: {(string)item}?", "Sure?",
            //    MessageBoxButton.YesNo);
            //if (result == MessageBoxResult.Yes)
            //{
            //    lvEntries.Items.Remove(item);
            //}

            // MULTIPLE ITEMS
            var items = lvEntries.SelectedItems;
            var result = MessageBox.Show($"Are you sure you want ot delete {items.Count} items?", "Sure?",
                MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                var itemList = new ArrayList(items);
                foreach (var item in itemList)
                {
                    lvEntries.Items.Remove(item);
                }
            }
        }
    }
}