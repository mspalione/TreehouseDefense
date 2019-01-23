using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class SuperInvader : Invader
    {
        public override int Health { get; protected set; } = 2;
        protected override int StepSize { get; } = 2;

        private static System.Random _random = new System.Random();

        public SuperInvader(Path path) : base(path)
        { }

        public override void DecreaseHealth(int factor)
        {
            if (_random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor);
            }
            else
            {
                Console.WriteLine("Shot at a super invader but it sustained no damage.");
            }
        }
    }
}
