﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page376v2
{
    class OutsideWithHidingPlace: Outside , IHidingPlace
    {
        public OutsideWithHidingPlace(string name , bool hot , string hidingPlaceName): base (name,hot)
        {
            HidingPlaceName = hidingPlaceName;
        }

        public string HidingPlaceName { get; }

        public override string Description
        {
            get
            {
                return base.Description + " Ktoś może ukrywać się " + HidingPlaceName + ".";
            }
        }

    }
}