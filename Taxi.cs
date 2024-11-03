using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    internal class Taxi
    {
        private int life;
        private float speed;
        private static Taxi instance = null;

        public Taxi(int life, float speed)
        {
            this.life = 100;
            this.speed = 1f;
        }

        public static Taxi Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Taxi(100, 1f);
                }
                return instance;
            }
        }

        public int GetLife() 
        {
            return life; 
        }

        public void SetLife(int life)
        {
            this.life = life;
        }

        public float GetSpeed()
        {
            return speed;
        }

        public void SetSpeed(float speed)
        {
            this.speed = speed;
            Console.WriteLine($"La velocidad es: {speed}");
        }

        public void TaxiValues(double time)
        {
            float speed = GetSpeed();
            int life = GetLife();
            Console.WriteLine($"Taxi values at time {time}: speed: {speed}, life points: {life}");
        }

        private double elapsedTime = 0;
        public void EffectTime(double time, Obstacle typeObstacle)
        {
            elapsedTime += time;
            if (elapsedTime >= typeObstacle.GetTimeEffect())
            {
                SetSpeed(1);
            }
        }
    }
}
