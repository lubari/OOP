using System.Collections.Generic;

namespace ConsoleApp
{
    internal class ColoredLightstring : Lightstring
    {
        private ColoredBulb[] coloredBulbs;
        private int serialNumber;

        public ColoredLightstring(int serialNumber, int quantity) { 
            
            coloredBulbs = new ColoredBulb[quantity];
        }

        private void SetBublsColors()
        {
            ColoredBulb.Color color;

            if (this.serialNumber % 4 == 0)
            {
                color = ColoredBulb.Color.Blue;
            }
            else if (this.serialNumber% 2 == 0)
            {
                color = ColoredBulb.Color.Green;
            }
            else if (this.serialNumber % 2 == 0)
            {
                color = ColoredBulb.Color.Yellow;
            }
            else
            {
                color = ColoredBulb.Color.Red;
            }

            foreach(ColoredBulb b in coloredBulbs)
            {
                b.SetColor(color);
            }
        }
    }
}