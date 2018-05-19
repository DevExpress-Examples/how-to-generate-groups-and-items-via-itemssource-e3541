// Developer Express Code Central Example:
// How to generate groups and items via ItemsSource
// 
// This example demonstrates how to bind NavBarControl with a DataSource.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3541

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
using DevExpress.Xpf.NavBar;

namespace Q346723 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            DataContext = Groups.Create();
            InitializeComponent();
        }
    }
    public class Groups : List<Group> {
        public static Groups Create() {
            Groups res = new Groups();
            for(int i = 0; i < 5; i++) {
                Group gr = new Group() {
                    Header = "Group " + i.ToString(),
                };
                gr.Items = Items.Create(gr.Header);
                res.Add(gr);
            }
            return res;
        }
    }
    public class Group {
        public string Header { get; set; }
        public Items Items { get; set; }
    }
    public class Items : List<Item> {
        public static Items Create(string groupName) {
            Items res = new Items();
            for(int i = 0; i < 10; i++) {
                Item item = new Item() { 
                    Header = groupName + ", Header " + i.ToString(),
                };
                res.Add(item);
            }
            return res;
        }
    }
    public class Item {
        public string Header { get; set; }
    }
}
