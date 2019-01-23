using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class SniperTower : Tower
    {
        protected override double Accuracy { get; } = .9;

        public SniperTower(MapLocation location) : base(location)
        { }
    }
}
