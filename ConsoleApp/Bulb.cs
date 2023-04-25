using System;

namespace ConsoleApp
{
    internal class Bulb
    {
        protected bool state;

        public void SetState(bool state)
        {
            this.state = state;
        }

        public bool GetState()
        {
            return state;
        }
    }
}