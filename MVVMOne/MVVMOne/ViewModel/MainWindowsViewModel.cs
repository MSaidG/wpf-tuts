using MVVMOne.Model;
using MVVMOne.MVVM;
using System.Collections.ObjectModel;

namespace MVVMOne.ViewModel
{
    internal class MainWindowsViewModel : ViewModelBase 
    {
        public ObservableCollection<Item> Items { get; set; }
        public MainWindowsViewModel() 
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item
            {
                Name = "Product1",
                SerialNumber = "0001",
                Quantity = 5
            });

            Items.Add(new Item
            {
                Name = "Product2",
                SerialNumber = "0002",
                Quantity = 6
            });
        }


        private Item selectedItem;
        public Item SelectedItem
        {
            get { return selectedItem; }
            set 
            { 
                selectedItem = value; 
                OnPropertChanged();
            }
        }


        
    }
}
