using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page376v2
{
    class RoomWithDoor : RoomWithHidingPlace , IHasExteriorDoor
    {
        public RoomWithDoor(string name,string decoration,string doorDescription,string hidingPlaceName): base(name,decoration,hidingPlaceName)
        {
            DoorDescription = doorDescription;
        }

        public string DoorDescription { get; private set; }
        public Location DoorLocation { get;set; }
    }
}
