using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    internal class PoliceCar : Obstacle
    {
        private const string typeObstacle = "Police Car";

        public PoliceCar(bool isSolid, int lifePoints, float velocityMultiplier, int timeEffect) : base(isSolid, lifePoints, velocityMultiplier, timeEffect)
        {
            isSolid = true;
            lifePoints = 30;
            velocityMultiplier = 0.8f;
            timeEffect = 1;
        }
    }
}
