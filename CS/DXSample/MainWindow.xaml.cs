using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Xpf.Core;

namespace DXSample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DXWindow {
        public MainWindow() {
            InitializeComponent();
        }
    }

    public class GridViewModel : ViewModelBase {
        public ObservableCollection<ItemViewModel> Items {
            get { return GetProperty(() => Items); }
            set { SetProperty(() => Items, value); }
        }
        public GridViewModel() {
            Items = new ObservableCollection<ItemViewModel>();
            for (int i = 0; i < 50; i++) {
                Items.Add(new ItemViewModel() { Number = i, Text = "Text" + i });
            }
        }

    }
    public class ItemViewModel : ViewModelBase {
        public string Text {
            get { return GetProperty(() => Text); }
            set { SetProperty(() => Text, value); }
        }
        public int Number {
            get { return GetProperty(() => Number); }
            set { SetProperty(() => Number, value); }
        }
    }
}
