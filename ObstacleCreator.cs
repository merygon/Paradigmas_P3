using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    abstract class ObstacleCreator
    {
        protected bool chasing;
        protected bool isSolid;
        protected int lifePoints;
        protected float velocityMultiplier;
        protected int timeEffect;

        public ObstacleCreator(bool isSolid, int lifePoints, float velocityMultiplier, int timeEffect)
        {
            this.isSolid = isSolid;
            this.lifePoints = lifePoints;
            this.velocityMultiplier = velocityMultiplier;
            this.timeEffect = timeEffect;
        }
        public abstract Obstacle CreateObstacle();
    }
}
