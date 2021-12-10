using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SpeedyCars
{
    public class Car
    {
        float Velocity = 0.0f; //Speed car in m/s
        float Acceleration = 0.0f; //Speed change in m/s2
        float DeAcceleration = 0.0f; //Speed change in m/s2
        float Length = 0.0f; //length car in m

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

    public class Road
    {
        float roadLength; //distance in m.
        List<float> stopLights; //distance from start in m.

        public Road(float length, List<float> lights)
        {
            roadLength = length;
            stopLights = lights;
        }

        public List<float> getLights()
        {
            return stopLights;
        }

        public float getNextLightDistance(float distance)
        {
            Debug.WriteLine("getNextLightDistance called:");
            if(distance < roadLength)
            {
                int i = 0;
                float pick = stopLights[i];
                float result;
                foreach (float lightDistance in stopLights)
                {
                    if(lightDistance > distance)
                    {
                        pick = stopLights[i];
                        break;
                    }
                    i += 1;
                }
                result = pick - distance;
                return result;

            }
            else
            {
                throw new Exception("Input distance greater than length of the road.");
            }
        }
    }
}
