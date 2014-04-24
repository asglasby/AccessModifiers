using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modifiers.Models
{
    public abstract class Vehicle
    {
        public Passenger passenger = new Passenger();
        protected int wheels { get; set; }
        public string license { get; set; }
        public int passengers { get; set; }

        
        public virtual int getWheels()
        {
            return this.wheels;
        }
        public virtual void setWheels(int x)
        {
            this.wheels = x;
        }

        public abstract string move();
        //{
        //    return "The vehicle is moving!";
        //}
    }
}