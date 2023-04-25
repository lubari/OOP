using System;

namespace ConsoleApp
{
    internal class ColoredBulb : Bulb
    {
        private Color color;

        public void SetColor(ColoredBulb.Color color)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return this.color.ToString();
        }

        public enum Color
        {
            Red,
            Green,
            Blue,
            Yellow
        }
    }
}