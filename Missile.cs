using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooterGame_1
{
    class Missile
    {
        private float cxGraphicLocation;
        private float cyGraphicLocation;
        private bool cActive;
        private int cAmmount;
        private int cDistanceTraveled;
        private Bitmap cPicture;

        public Missile(float cxGraphicLocation, float cyGraphicLocation, bool cActive, int cAmmount, int cDistanceTraveled, Bitmap cPicture)
        {
            this.cxGraphicLocation = cxGraphicLocation;
            this.cyGraphicLocation = cyGraphicLocation;
            this.cActive = cActive;
            this.cAmmount = cAmmount;
            this.cDistanceTraveled = cDistanceTraveled;
            this.cPicture = cPicture;
        }

        public float xGraphicLocation
        {
            set { cxGraphicLocation = value; }
            get { return cxGraphicLocation; }
        }
        public float yGraphicLocation
        {
            set { cyGraphicLocation = value; }
            get { return cyGraphicLocation; }
        }
        public bool active
        {
            set { cActive = value; }
            get { return cActive; }
        }
        public int mumberOfCannons
        {
            set { cAmmount = value; }
            get { return cAmmount; }
        }
        public int distanceTraveled
        {
            set { cDistanceTraveled = value; }
            get { return cDistanceTraveled; }
        }
        public Bitmap picture
        {
            set { cPicture = value; }
            get { return cPicture; }
        }
    }
}
