using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedyCars
{
    public class Car
    {
        float Velocity = 0.0f;
        float Acceleration = 0.0f;
        float DeAcceleration = 0.0f;
        float Length = 0.0f;

        public Car(float velocity, float acceleration, float deacceleration, float length)
        {
            Velocity = velocity;
            Acceleration = acceleration;
            DeAcceleration = deacceleration;
            Length = length;            
        }

        public void updateVelocity(float time, bool accelerate)
        {
            if (accelerate)
            {
                Velocity = Velocity + Acceleration * time;
            }
            else if (!accelerate)
            {
                Velocity = Velocity - DeAcceleration * time;
            }
            else
            {
                throw new Exception("No true or false statement given for accelerate in car.updateVelocity.");
            }
        }

        public float getVelocity()
        {
            return Velocity;
        }
        
        public float getLength()
        {
            return Length;
        }
    }
}
