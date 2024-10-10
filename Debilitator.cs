using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    internal class Debilitator : Obstacle
    {
        private const string typeObstacle = "Debilitator";
        public Debilitator(bool isSolid, int lifePoints, float velocityMultiplier, int timeEffect) : base(isSolid, lifePoints, velocityMultiplier, timeEffect)
        {
            isSolid = false;
            lifePoints = 0;
            velocityMultiplier = 0.5f;
            timeEffect = 30;
        }
    }
}
