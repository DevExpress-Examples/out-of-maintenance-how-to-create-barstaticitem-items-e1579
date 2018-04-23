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

namespace BarStaticItemEx {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            rtfEditor.SelectionChanged += new RoutedEventHandler(rtfEditor_SelectionChanged);
        }

        void rtfEditor_SelectionChanged(object sender, RoutedEventArgs e) {
            int line = 0;
            int col = 0;
            rtfEditor.CaretPosition.GetLineStartPosition(-100000, out line);
            col = rtfEditor.CaretPosition.GetOffsetToPosition(rtfEditor.CaretPosition.GetLineStartPosition(0));
            staticItemLine.Content = "Line: " + (-line).ToString() + "  Position: " + (-col).ToString();
        }
    }
}
