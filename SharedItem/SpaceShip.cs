using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedItems {
    public class SpaceShip<PILT,PAST,TT> : IFlyable<PAST> {
        private TT _Title;
        //private Engine _Motor;
        private  PILT _Pilot; 
        private List<PAST> _Passengers = new List<PAST>();

        public TT Title {
            get { return _Title; }
            set { _Title = value; }
        }


        public string Fly() {
            return  "Zoom Zoom";
        }

        public string Land() {
            return  "Landing gear down";
        }

        public PILT Pilot {
            get { return _Pilot; }
            set { _Pilot = value; }
        }

        public List<PAST> Passengers {
            get { return _Passengers; }
        }



        public void AddPassengers(PAST pass) {
                           //    // Added people to ship.
        //    for (int i = 0; i < people; i++) {
        //        _Passengers.Add(new Citizen("Person",i.ToString()));
        //    }
        }
    }
}
