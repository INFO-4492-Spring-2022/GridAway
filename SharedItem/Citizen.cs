﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedItems {
    public class Citizen : Person {
        private string _Job;
        private Citizen _Spouse; 

        public Citizen(string fNa, string lNa)
            :base(fNa,lNa){

        }

        public string Job {
            get { return _Job; }
            set { _Job = value; }
        }

        //internal void SetAsPilot(SpaceShip ss) {
        //    ss.Pilot = this;
        //}
    }
}
