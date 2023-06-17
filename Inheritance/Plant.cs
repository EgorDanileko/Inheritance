using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_2
{
    public abstract class Plant
    {
        protected string name;
        protected int nutrient_level;
        protected bool isAlive = true;

        public string getName()
        {
            return name;
        }

        public int ChangeNutrientLevel(int cahnge)
        {
            nutrient_level = nutrient_level + cahnge;
            return nutrient_level;
        }

        public int getLvl()
        {
            return nutrient_level;
        }

        public abstract bool isAlivePlant();

       
        public Plant(string name, int nutrient_level)
        {
            this.name = name;
            this.nutrient_level = nutrient_level;
            
        }

        public override string ToString()
        {
            if (isAlive)
            {
                return $"{name} {nutrient_level} alive";
            }
            else
            {
                return $"{name} {nutrient_level} not alive";
            }
        }

        public abstract void radiate(Radiation r);
    }

    public class Wombleroot : Plant{
        public Wombleroot(string name, int nutrient_level): base(name, nutrient_level) { }       
        public override void  radiate(Radiation r) { r.radWom(this); }

        public override bool isAlivePlant()
        {
            isAlive = (0 < nutrient_level) && (nutrient_level < 11);
            return isAlive;
        }

    }

    public class Wittentoot : Plant
    {
        
        public Wittentoot(string name, int nutrient_level) : base(name, nutrient_level) { }       
        public override void radiate(Radiation r) { r.radWit(this); }

        public override bool isAlivePlant()
        {
            isAlive =  0 < nutrient_level;
            return isAlive;
        }
    }

    public class Woreroot : Plant
    {
        public Woreroot(string name, int nutrient_level) : base(name, nutrient_level) { }
        public override void radiate(Radiation r) { r.radWor(this); }

        public override bool isAlivePlant()
        {
            isAlive =  0 < nutrient_level;
            return isAlive;
        }

    }
}
