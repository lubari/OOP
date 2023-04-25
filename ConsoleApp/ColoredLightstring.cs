using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    internal class ColoredLightstring : Lightstring
    {

        public ColoredLightstring(int quantity) : base(quantity)
        {
            this.SetBublsColors();
        }

        public void GetState()
        {
            base.GetState();
            this.PrintColorState();
        }

        public void PrintColorState()
        {
            foreach (ColoredBulb bulb in this.bulbs)
            {
                if(bulb != null && bulb.GetState()) {
                    Console.WriteLine(bulb.GetColor()); 
                }
                else
                {
                    Console.WriteLine("off");
                }
            }
        }

        private void SetBublsColors()
        {
            ColoredBulb.Color color;
            for (int i = 0; i < bulbs.Length; i++)
            {
                int index = i + 1;
                if ( index % 4 == 0)
                {
                    color = ColoredBulb.Color.Blue;
                }
                else if (index % 3 == 0)
                {
                    color = ColoredBulb.Color.Green;
                }
                else if (index % 2 == 0)
                {
                    color = ColoredBulb.Color.Yellow;
                }
                else
                {
                    color = ColoredBulb.Color.Red;
                }

                this.bulbs[i].SetColor(color);
            }
        }
    }
}