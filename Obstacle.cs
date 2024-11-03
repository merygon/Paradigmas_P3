using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Practica_3
{
    abstract class Obstacle
    {
        /*Los obstáculos comparten los siguientes atributos:
        ● Puede o no perseguir al Taxi.
        */

        private Taxi taxi;
        private bool chasing;
        private bool isSolid;
        private int lifePoints;
        private float velocityMultiplier;
        private int timeEffect;

        public Obstacle(bool isSolid, int lifePoints, float velocityMultiplier, int timeEffect)
        {
            this.isSolid = isSolid;
            this.lifePoints = lifePoints;
            this.velocityMultiplier = velocityMultiplier;
            this.timeEffect = timeEffect;
        }

        public int GetTimeEffect() 
        {
            return timeEffect; 
        }
        public bool GetChasing() 
        {
            return chasing; 
        }

        public bool GetSolid()
        {
            return isSolid;
        }

        public void RestLife(Taxi taxi)
        {
            int taxiLife = taxi.GetLife();
            int newLife = taxiLife - lifePoints;
            taxi.SetLife(newLife);
        }

        public void Multiplier(Taxi taxi)
        {
            float taxiSpeed = taxi.GetSpeed();
            float newSpeed = taxiSpeed*velocityMultiplier;
            taxi.SetSpeed(newSpeed);

        }
    }
}
