using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    internal class Fence : Obstacle
    {
        private const string typeObstacle = "Fence";

        public Fence(bool isSolid, int lifePoints, float velocityMultiplier, int timeEffect) : base(isSolid, lifePoints, velocityMultiplier, timeEffect)
        {
            isSolid = true;
            lifePoints = 10;
            velocityMultiplier = 0.8f;
            timeEffect = 1;
        }
    }
}
