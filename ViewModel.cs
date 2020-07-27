using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SideMenuListControl
{
    class ViewModel
    {
        //To call resource dictionary in our codebehind
        ResourceDictionary dict = Application.LoadComponent(new Uri("/SideMenuListControl;component/IconDictionary.xaml", UriKind.RelativeOrAbsolute)) as ResourceDictionary;

        //Source list for our Menu Items Listbox
        public List<MenuItemsData> ItemsList
        {
            get {
                return new List<MenuItemsData> { 
                new MenuItemsData(){ PathData= (PathGeometry)dict["HomeIcon"], MenuText="Home" },
                new MenuItemsData(){ PathData = (PathGeometry)dict["MailIcon"], MenuText="Mail" } };
            }}
    }

    public class MenuItemsData {
        public PathGeometry PathData { get; set; }
        public bool IsItemSelected { get; set; }
        public string MenuText { get; set; }
    }
}
