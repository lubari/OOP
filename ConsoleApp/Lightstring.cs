using System;

namespace ConsoleApp
{
    internal class Lightstring 
    {
        protected ColoredBulb[] bulbs;

        public Lightstring(int quantity) {
            this.bulbs = new ColoredBulb[quantity];
            this.IniciInitializeBulbs();
        }

        public void GetState()
        {
            int currentMinute = DateTime.Now.Minute;

            if (currentMinute % 2 == 0)
            {
                this.SetBulbsStateEven();
            }
            else
            {
                this.SetOnOddBulbs();
            }
        }

        private void IniciInitializeBulbs()
        {
            for( int i = 0; i < bulbs.Length; i++ )
            {
                this.bulbs[i] = new ColoredBulb();
            }
        }

        public void SetBulbsStateEven()
        {
            for (int i = 0; i < bulbs.Length; i++)
            {
                if (i % 2 == 0)
                {
                    this.bulbs[i].SetState(true);
                }
                else
                {
                    this.bulbs[i].SetState(false);
                }
            }
        }

        public void SetOnOddBulbs()
        {
            for (int i = 0; i < bulbs.Length; i++)
            {
                if (!(i % 2 == 0))
                {
                    this.bulbs[i].SetState(true);
                }
                else
                {
                    this.bulbs[i].SetState(false);
                }
            }
        }
    }
}