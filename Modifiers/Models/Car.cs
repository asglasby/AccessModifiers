using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modifiers.Models
{
    public class Car: Vehicle
    {

        public string model { get; set; }
        public string make { get; set; }
        public int year { get; set; }

        public virtual void setWheels(int x)
        {
            if (x > 4)
            {
                this.wheels = 4;
            }
            else 
            {
                this.wheels = x;
            }
        }

        public override string move()
        {
            return "The car is driving";
        }

    }
}