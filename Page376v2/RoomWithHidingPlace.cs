﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page376v2
{
    class RoomWithHidingPlace : Room , IHidingPlace
    {
        public RoomWithHidingPlace(string name,string decoration, string hidingPlaceName): base (name,decoration)
        {
            HidingPlaceName = hidingPlaceName;
        }

        public string HidingPlaceName { get; }

        public override string Description
        {
            get
            {
                return base.Description + "Ktoś może ukrywać się " + HidingPlaceName + ".";
            }
        }
        

    }
}
