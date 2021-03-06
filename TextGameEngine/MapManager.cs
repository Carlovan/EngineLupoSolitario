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
    /// This is the class used for the management of the map
    /// </summary>
    class MapManager
    {
        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="r">Vector containing the rooms into the map</param>
        public MapManager(Room[] r)
        {
            Rooms = (Room[])(r.Clone());
            CurrentRoom = Rooms[0];
        }

        /// <summary>
        /// Index of the current room
        /// </summary>
        public Room CurrentRoom
        {
            get;
            private set;
        }

        /// <summary>
        /// Sets the controls properties regarding the current room
        /// </summary>
        public string GetLogString()
        {
            string logText = "";
            logText += String.Format("----{0}----{1}\nDirections:", CurrentRoom.Title, CurrentRoom.Description);

            if (CurrentRoom.Doors[(int)Direction.North] != null)
                logText += "\nN -> " + CurrentRoom.Doors[(int)Direction.North].Title;
            if (CurrentRoom.Doors[(int)Direction.East] != null)
                logText += "\nE -> " + CurrentRoom.Doors[(int)Direction.East].Title;
            if (CurrentRoom.Doors[(int)Direction.South] != null)
                logText += "\nS -> " + CurrentRoom.Doors[(int)Direction.South].Title;
            if (CurrentRoom.Doors[(int)Direction.West] != null)
                logText += "\nW -> " + CurrentRoom.Doors[(int)Direction.West].Title;

            return logText;
        }

        /// <summary>
        /// List of the rooms inside the map
        /// </summary>
        private Room[] Rooms { get; set; }

        /// <summary>
        /// Moves the player to the specified direction
        /// </summary>
        /// <param name="dir">Direction to move</param>
        /// <returns>False if the player can't move in that direction</returns>
        public bool ChangeRoom(Direction dir)
        {
            if (CurrentRoom.Doors[(int)dir] == null)
            {
                return false;
            }
            CurrentRoom = Rooms[CurrentRoom.Doors[(int)dir].DestinationIndex];
            return true;
        }
    }
}
