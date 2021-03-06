﻿using System;
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
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        MapManager map;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void winMain_Loaded(object sender, RoutedEventArgs e)
        {
            map = new MapManager(new Room[]{
                new Room("Laboratorio 13", "", new Door[]{new Door("Al corridoio", 1, null), null, null, null}),
                new Room("Corridoio", "", new Door[]{new Door("Al lab dell'Angela", 2, null), null, new Door("Al lab 13", 0, null), new Door("Al lab chimica", 3, null)}),
                new Room("Laboratorio dell'Angela", "", new Door[]{null, null, new Door("Al corridoio", 1, null), null}),
                new Room("Laboratorio di chimica", "", new Door[]{null, new Door("Al corridoio", 1, null), null, null})
            });

            Console.WriteLine(this.Resources.Count);

            /*MoveModule modMove = new MoveModule();
            modMove.Update += modMove_UpdateLog;
            Control moveControl = modMove.Load(map);
            Grid.SetRow(moveControl, 1);
            grdMain.Children.Add(moveControl);*/
        }

        void modMove_UpdateLog(object sender, EventArgs e)
        {
            txtLog.Text += map.GetLogString() + "\n\n";
            txtLog.Focus();
            txtLog.CaretIndex = txtLog.Text.Length;

            
        }

        



    }
}
