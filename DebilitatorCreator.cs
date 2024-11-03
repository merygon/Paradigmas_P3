using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    internal class DebilitatorCreator : ObstacleCreator
    {
        public DebilitatorCreator(bool isSolid, int lifePoints, float velocityMultiplier, int timeEffect) : base(isSolid, lifePoints, velocityMultiplier, timeEffect)
        {

        }
        public override Debilitator CreateObstacle()
        {
            return new Debilitator(isSolid, lifePoints, velocityMultiplier, timeEffect);
        }
    }
}
