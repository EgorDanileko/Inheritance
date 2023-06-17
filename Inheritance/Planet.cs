using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_2
{
    public class Planet
    {
        private List<Plant> plants = new List<Plant>();
        private Radiation cur_rad = NoRad.Instance();
        private Radiation next_day_rad = null;
        
        public Radiation GetCurR()
        { return cur_rad; }

        public Radiation GetNextCurR()
        {         
            return next_day_rad; 
        }

        public void AddPlant(string name, string specie, int n_level)
        {
            if(specie == "wom")
            {
                plants.Add(new Wombleroot(name, n_level));
            }
            else if (specie == "wit")
            {
                plants.Add(new Wittentoot(name, n_level));
            }
            else if(specie == "wor")
            {
                plants.Add(new Woreroot(name, n_level));
            }
        }

        public List<Plant> ModifyAllPlants()
        {    
            
            //day
            foreach (Plant plant in plants)
            {
                if (plant.isAlivePlant())
                {
                    if (plant is Wombleroot)
                    {
                        plant.radiate(cur_rad);
                    }
                    else if (plant is Wittentoot)
                    {
                        plant.radiate(cur_rad);
                    }
                    else if (plant is Woreroot)
                    {
                        plant.radiate(cur_rad);
                    }
                }
            }
            
            return plants;
        }

        public Radiation nextRad()
        {

            Radiation s = null;
            int radA = 0;
            int radD = 0;
            foreach (Plant plant in plants)
            {
                if (plant is  Wombleroot)
                {
                    radA += 10;

                }
                if(plant is Wittentoot)
                {
                    if(plant.getLvl() < 5) 
                    {
                        radD += 4;
                    }
                    else if(plant.getLvl() < 10)
                    {
                        radD += 1;
                    }
                }                
            }

            if(radA >= radD*3)
            {
                next_day_rad = Alpha.Instance();
            }
            else if(radD >= radA*3)
            {
                next_day_rad = Delta.Instance();
            }
            else
            {
                next_day_rad = NoRad.Instance();
            }

            cur_rad = next_day_rad;

            return cur_rad;
        }

        public bool isAllNotAlive()
        {
            foreach(Plant plant in plants)
            {
                if(plant.isAlivePlant())
                {
                    return false;
                }
            }
            return true;
        }

        public string printPlants() 
        {
            string result = "";

            foreach(Plant plant in plants)
            {
                Console.WriteLine(plant.ToString() + " ");
                result += plant.ToString() + " ";
            }

            return result;
        }

    }
}
