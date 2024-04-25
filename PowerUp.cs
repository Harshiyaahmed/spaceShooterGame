using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooterGame_1
{
    class PowerUp
    {
        private float cx;
        private float cy;
        private float cShields;
        private int cCannonCount;
        private Bitmap cpicture;

        public PowerUp(float cx, float cy, float cShields, int cCannonCount, Bitmap cpicture)
        {
            this.cx = cx;
            this.cy = cy;
            this.cShields = cShields;
            this.cCannonCount = cCannonCount;
            this.cpicture = cpicture;
        }

        public float x
        {
            set { cx = value; }
            get { return cx; }
        }
        public float y
        {
            set { cy = value; }
            get { return cy; }
        }
        public float shields
        {
            set { cShields = value; }
            get { return cShields; }
        }
        public int cannonCount
        {
            set { cCannonCount = value; }
            get { return cCannonCount; }
        }
        public Bitmap picture
        {
            set { cpicture = value; }
            get { return cpicture; }
        }

    }
}
