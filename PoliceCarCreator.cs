using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    internal class PoliceCarCreator : ObstacleCreator
    {
        public PoliceCarCreator(bool isSolid, int lifePoints, float velocityMultiplier, int timeEffect) : base(isSolid, lifePoints, velocityMultiplier, timeEffect)
        {

        }
        public override PoliceCar CreateObstacle()
        {
            return new PoliceCar(isSolid, lifePoints, velocityMultiplier, timeEffect);
        }
    }
}
