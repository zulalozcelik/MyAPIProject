﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class Room
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        public int Price { get; set; }
        public int Title { get; set; }
        public int BedCount { get; set; }
        public int BathCount { get; set; }
        public int Wifi { get; set; }
        public int Description  { get; set; }
    }
}
