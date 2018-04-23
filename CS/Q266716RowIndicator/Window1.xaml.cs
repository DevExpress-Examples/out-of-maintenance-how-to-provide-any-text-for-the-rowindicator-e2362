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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Q266716RowIndicator
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        List<TestData> list = new List<TestData>();
        public Window1() {
            InitializeComponent();

            for(int i = 0; i < 100; i++)
                list.Add(new TestData() { Text = "Row" + i, Number = i });
            gridControl.DataSource = list;

        }

        void GridControl_CustomUnboundColumnData(object sender, DevExpress.Wpf.Grid.GridColumnDataEventArgs e) {
            if(e.Column.FieldName == "RowNumber") {
                e.Value = gridControl.GetRowVisibleIndexByHandle(gridControl.GetRowHandleByListIndex(e.ListSourceRowIndex));
                //e.Value = e.ListSourceRowIndex;
            }
        }
    }

    public class TestData {
        public string Text { get; set; }
        public int Number { get; set; }
    }
}
