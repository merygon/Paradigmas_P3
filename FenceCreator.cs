using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    class FenceCreator : ObstacleCreator
    {
        public FenceCreator(bool isSolid, int lifePoints, float velocityMultiplier, int timeEffect) : base(isSolid, lifePoints, velocityMultiplier, timeEffect)
        {

        }
        public override Fence CreateObstacle()
        {
            return new Fence(isSolid, lifePoints, velocityMultiplier, timeEffect);
        }
    }
}
