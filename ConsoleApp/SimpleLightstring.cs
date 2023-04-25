using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class SimpleLightstring : Lightstring
    {
        public SimpleLightstring(int quantity) : base(quantity)
        {
        }

        public void GetState()
        {   
            base.GetState();
            foreach (Bulb bulb in this.bulbs) {
                if(bulb.GetState())
                {
                    Console.WriteLine("ON");
                } else
                {
                    Console.WriteLine("OFF");
                }
            }
        }
    }
}