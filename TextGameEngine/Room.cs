using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameEngine
{
    /// <summary>
    /// Represents a room in the map
    /// </summary>
    class Room
    {
        //TODO: add items property

        /// <summary>
        /// The title of the room
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The description of the room
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The list of doors in the room (North, East, South, West); null = no door
        /// </summary>
        public Door[] Doors { get; private set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="title">Room title</param>
        /// <param name="desc">Description</param>
        /// <param name="doors">List of doors</param>
        public Room(string title, string desc, Door[] doors)            //TODO: add items
        {
            desc = desc.Trim();
            Description = desc + (desc == "" ? "" : "\n");
            Title = title.Trim();
            Doors = (Door[])doors.Clone();
        }
    }
}
