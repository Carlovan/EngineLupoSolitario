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
    class MoveModule : Module
    {
        string Title = "Move";
        static int buttonWidth = 60;
        static int buttonHeight = 20;
        Button[] buttons = new Button[]
        {
            new Button(){
                Name = "btnNorth",
                Content = "North",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 0, 0, 50),
                Width = buttonWidth,
                Height = buttonHeight
            },
            new Button(){
                Name = "btnEast",
                Content = "East",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(120, 0, 0, 0),
                Width = buttonWidth,
                Height = buttonHeight
            },
            new Button(){
                Name = "btnSouth",
                Content = "South",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 50, 0, 0),
                Width = buttonWidth,
                Height = buttonHeight
            },
            new Button(){
                Name = "btnWest",
                Content = "West",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(0, 0, 120, 0),
                Width = buttonWidth,
                Height = buttonHeight
            }
        };

        public override event EventHandler UpdateLog;

        public override Control Load(MapManager mm)
        {
            GroupBox gb = new GroupBox();
            gb.Header = Title;

            Grid gr = new Grid();

            foreach (var x in buttons)
            {
                x.Click += DirButton_Click;
                gr.Children.Add(x);
            }

            gb.Content = gr;

            return gb;
        }

        public void DirButton_Click(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Name == "btnNorth")
                mapManager.ChangeRoom(Direction.North);
            else if (((Button)sender).Name == "btnEast")
                mapManager.ChangeRoom(Direction.East);
            else if (((Button)sender).Name == "btnSouth")
                mapManager.ChangeRoom(Direction.South);
            else if (((Button)sender).Name == "btnWest")
                mapManager.ChangeRoom(Direction.West);

            var crd = mapManager.CurrentRoom.Doors;

            buttons[(int)Direction.North].IsEnabled = crd[(int)Direction.North] != null && crd[(int)Direction.North].IsOpen;
            buttons[(int)Direction.South].IsEnabled = crd[(int)Direction.South] != null && crd[(int)Direction.South].IsOpen;
            buttons[(int)Direction.East].IsEnabled = crd[(int)Direction.East] != null && crd[(int)Direction.East].IsOpen;
            buttons[(int)Direction.West].IsEnabled = crd[(int)Direction.West] != null && crd[(int)Direction.West].IsOpen;

            UpdateLog(this, new EventArgs());
        }
    }
}
