using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml.Markup;
 


namespace Marshell
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
    //public class CategoryBase { }



//            public class Category : CategoryBase
//    {
//        public string Name { get; set; }
//        public string Tooltip { get; set; }
//        public Symbol Glyph { get; set; }
//}


//        public class Separator : CategoryBase { }

//        public class Header : CategoryBase
//        {
//            public string Name { get; set; }
//        }

//        [ContentProperty(Name = "ItemTemplate")]
//        class MenuItemTemplateSelector : DataTemplateSelector
//        {
//            public DataTemplate ItemTemplate { get; set; }
//            protected override DataTemplate SelectTemplateCore(object item) => item is Separator ? SeparatorTemplate : item is Header ? HeaderTemplate : ItemTemplate;
        }
        public MainWindow()
        {
            this.InitializeComponent(); 
            this.ExtendsContentIntoTitleBar = true;
            //C# code behind
            //Categories = new ObservableCollection<CategoryBase>();
            //Categories.Add(new Category { Name = "Category 1", Glyph = Symbol.Home, Tooltip = "This is category 1" });
            //Categories.Add(new Category { Name = "Category 2", Glyph = Symbol.Keyboard, Tooltip = "This is category 2" });
            //Categories.Add(new Category { Name = "Category 3", Glyph = Symbol.Library, Tooltip = "This is category 3" });
            //Categories.Add(new Category { Name = "Category 4", Glyph = Symbol.Mail, Tooltip = "This is category 4" });
            
           
        }
        

private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "Clicked";
        }
    }
}
 