using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooterGame_1
{
    class Ship
    {
        private float cxGridLocation;
        private float cyGridLocation;
        private float cxGraphicLocation;
        private float cyGraphicLocation;
        private float cShields;
        private float cDamage;

        public Ship(float cxGridLocation, float cyGridLocation, float cxGraphicLocation, float cyGraphicLocation, float cShields, float cDamage)
        {
            this.cxGridLocation = cxGridLocation;
            this.cyGridLocation = cyGridLocation;
            this.cxGraphicLocation = cxGraphicLocation;
            this.cyGraphicLocation = cyGraphicLocation;
            this.cShields = cShields;
            this.cDamage = cDamage;
        }

        public float xGridLocation
        {
            set { cxGridLocation = value; }
            get { return cxGridLocation; }
        }
        public float yGridLocation
        {
            set { cyGridLocation = value; }
            get { return cyGridLocation; }
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
        public float shields
        {
            set { cShields = value; }
            get { return cShields; }
        }
        public float damage
        {
            set { cDamage = value; }
            get { return cDamage; }
        }
    }
}
