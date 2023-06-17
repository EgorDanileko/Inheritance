using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public interface Radiation
    {
        void radWom(Wombleroot wom);
        void radWit(Wittentoot wit);
        void radWor(Woreroot wom);
        
    }

    public class Alpha : Radiation
    {
        
        public void radWom(Wombleroot wom) {
            wom.ChangeNutrientLevel(2);
        }

        public void radWit(Wittentoot wit)
        {
            wit.ChangeNutrientLevel(-3);
        }

        public void radWor(Woreroot wor)
        {
            wor.ChangeNutrientLevel(1);
        }

        private Alpha() { }

        private static Alpha instance = null;
        public static Alpha Instance()
        {
            if (instance == null)
            {
                instance = new Alpha();
            }

            return instance;
        }
    }

    public class Delta : Radiation
    {

        public void radWom(Wombleroot wom)
        {
            wom.ChangeNutrientLevel(-2);
        }

        public void radWit(Wittentoot wit)
        {
            wit.ChangeNutrientLevel(4);
        }

        public void radWor(Woreroot wor)
        {
            wor.ChangeNutrientLevel(1);
        }

        private Delta() { }

        private static Delta instance = null;
        public static Delta Instance()
        {
            if (instance == null)
            {
                instance = new Delta();
            }
            return instance;
        }
    }

    public class NoRad : Radiation
    {

        public void radWom(Wombleroot wom)
        {
            wom.ChangeNutrientLevel(-1);
        }

        public void radWit(Wittentoot wit)
        {
            wit.ChangeNutrientLevel(-1);
        }

        public void radWor(Woreroot wor)
        {
            wor.ChangeNutrientLevel(-1);
        }

        private NoRad() { }

        private static NoRad instance = null;
        public static NoRad Instance()
        {
            if (instance == null)
            {
                instance = new NoRad();
            }
            return instance;
        }
    }
}
