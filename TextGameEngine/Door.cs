using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGameEngine
{
    class Door
    {
        /// <summary>
        /// True if the door is open (default: true)
        /// </summary>
        public bool IsOpen { get; set; }

        /// <summary>
        /// Index of the destination room inside the MapManager rooms vector
        /// </summary>
        public int DestinationIndex { get; private set; }

        /// <summary>
        /// The title of the door
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="tit">Door title</param>
        /// <param name="dest">Destination index</param>
        public Door(string tit, int dest)
        {
            IsOpen = true;
            Title = tit;
            DestinationIndex = dest;
        }
    }
}
