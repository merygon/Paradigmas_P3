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

        public Taxi(int life, float speed) 
        {
            this.life = 100;
            this.speed = 1f;
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
        }

        public void TaxiValues()
        {
            float speed = GetSpeed();
            int life = GetLife();
            Console.WriteLine($"Taxi values: speed: {speed}, life points: {life}");
        }
    }
}
