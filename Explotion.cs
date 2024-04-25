using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooterGame_1
{
    class Explotion
    {
        private float cxLocation;
        private float cyLocation;
        private float cxLength;
        private float cyHeight;
        private int cCount;

        public Explotion(float cxLocation, float cyLocation,float cxLength, float cyHeight, int cCount)
        {
            this.cxLocation = cxLocation;
            this.cyLocation = cyLocation;
            this.cxLength = cxLength;
            this.cyHeight = cyHeight;
            this.cCount = cCount;
        }

        public float xLocation
        {
            set { cxLocation = value; }
            get { return cxLocation; }
        }
        public float yLocation
        {
            set { cyLocation = value; }
            get { return cyLocation; }
        }
        public float xLength
        {
            set { cxLength = value; }
            get { return cxLength; }
        }
        public float yHeight
        {
            set { cyHeight = value; }
            get { return cyHeight; }
        }
        public int count
        {
            set { cCount = value; }
            get { return cCount; }
        }
    }
}
