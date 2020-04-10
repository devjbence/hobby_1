using System;
using Model.Enums;

namespace Model.MapData
{
    /// <summary>
    /// Térképen megjelenő objektum leíró adatai.
    /// </summary>
    public class MapObject
    {
        public ObjectsDepth ObjectsDepth { get; set; }

        /// <summary>
        /// Objektum színe.
        /// </summary>
        public ConsoleColor Color { get; set; }

        /// <summary>
        /// Az objektum mélységi szintje
        /// </summary>
        public int ZIndex { get; set; }

        public Dimension Dimension { get; set; }

        /// <summary>
        /// Karakterek amelyek az objektumot reprezentálják. 
        /// Ez jelenik meg a térképen.
        /// </summary>
        public char[][] Characters { get; set; }

        public Coordinates Coordinates { get; set; }
    }
}
