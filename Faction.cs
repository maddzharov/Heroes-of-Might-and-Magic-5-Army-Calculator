﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes5_ArmyCalc
{
    public class Faction
    {
        public string Name { get; set; }
        public Unit[] Units { get; set; }

        public Faction(string factionName)
        {
            Name = factionName;
            Units = new Unit[8];
            Units[0] = null;
        }

        public //create a method to load all the Faction data and add a public property that is a faction array with all faction data
    }
}
