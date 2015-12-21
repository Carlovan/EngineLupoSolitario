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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextGameEngine
{
    static class MoveModule : Module
    {
        //Module name
        static string Title = "Move";

        //Buttons standard size
        static int buttonWidth = 60;
        static int buttonHeight = 20;

        //Controls handled by the module
        static Control[] controls = new Control[]
        {
            new ComboBox(){
                Name = "cbbDirections",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 0, 0, 50)
            },
            new Button(){
                Name = "btnGo",
                Content = "Go",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 50, 0, 0),
                Width = buttonWidth,
                Height = buttonHeight
            }
        };

        static public override event ModuleUpdateHandler Update;

        static public override Control Load(MapManager mm)
        {
            mapManager = mm;

            GroupBox gb = new GroupBox();
            gb.Header = Title;

            Grid gr = new Grid();

            foreach (var x in controls)
            {
                gr.Children.Add(x);
            }

            ((Button)controls[1]).Click += GoButton_Click;

            gb.Content = gr;

            return gb;
        }

        static public void GoButton_Click(object sender, RoutedEventArgs e)
        {
            if (Update == null)
                return;

            Update(this, ((ComboBox)controls[0]).SelectedItem);
        }
    }
}
