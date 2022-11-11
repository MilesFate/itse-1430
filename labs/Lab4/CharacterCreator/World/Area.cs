// Luisalberto Castaneda
// ITSE 1430
// 11/12/2021
// AdventureGame Lab 4

using System;

namespace LuisalbertoCastaneda.AdventureGame.World
{
    public class Area
    {
        #region Getters and Setters
        public string RoomName
        {
            get => _roomName ?? ""; 
            set => _roomName = (value != null) ? value.Trim() : null; 
        }

        public string Description
        {
            get => _description ?? ""; 
            set => _description = (value != null) ? value.Trim() : null; 
        }

        
        public int RoomId { get; set; }
        public bool NorthAvalable { get; set; }
        public bool SouthAvalable { get; set; }
        public bool EastAvalable { get; set; }
        public bool WestAvalable { get; set; }

        #endregion

        private string _roomName;
        private string _description;

        public Area RoomsDef ()
        {
            var room = new Area();

            room.RoomName = RoomName;
            room.Description = Description;
            room.NorthAvalable = NorthAvalable;
            room.SouthAvalable = SouthAvalable;
            room.EastAvalable = EastAvalable;
            room.WestAvalable = WestAvalable;

            return room;
        }       
    }
}
