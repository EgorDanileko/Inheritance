using System;
using TextFile;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args) {

            TextFileReader reader = new TextFileReader("inp4.txt");
            reader.ReadInt(out int length);
            Console.WriteLine(length);

            Planet mars = new Planet();

            int day = 1;
            
            for(int i = 0; i < length; i++)
            {
                reader.ReadString(out string name);
                reader.ReadString(out string species);
                reader.ReadInt(out int nutrient_level);

                mars.AddPlant(name,species, nutrient_level);
            }
            Console.WriteLine("Curr radiation:  " + mars.GetCurR().GetType().Name + "at the day: " + day);
            day++;

            mars.printPlants();

            bool isEnd = false;

            Radiation radCur = mars.GetCurR();

            Radiation radCurhelp = null;
            while (!isEnd)
            {

                if (mars.isAllNotAlive())
                {
                    Console.WriteLine("All plants is wasted");
                    break;
                }

                if ((radCurhelp == radCur) == (radCur == NoRad.Instance()))
                {
                    Console.WriteLine("There is no radiation 2 days in a row");
                    isEnd = true;
                }

                radCurhelp = mars.nextRad();

                mars.ModifyAllPlants();

                Console.WriteLine("Curr radiation:  " + mars.GetCurR().GetType().Name + "at the day: " + day);

                mars.printPlants();

                day++;

                
            } ;

            /*Console.WriteLine("");
            do
            {
                Console.WriteLine("demands alpha rad: " + mars.GetRadAlpha());
                Console.WriteLine("demands delta rad: " + mars.GetRadDelta());

                mars.getNextDayRes();
                Console.WriteLine("Curr radiation   :  " + mars.GetCurR());
                mars.printPlants();
                
                Console.WriteLine("");
                
                Console.WriteLine("");
                
                Console.WriteLine("");
                if (mars.isAllNotAlive())
                {
                    Console.WriteLine("All plants wasted");
                    break;
                }
                if(mars.GetCurR() == cur && mars.GetNextCurR() == cur)
                {
                    Console.WriteLine("demands alpha rad: " + mars.GetRadAlpha());
                    Console.WriteLine("demands delta rad: " + mars.GetRadDelta());
                    mars.getNextDayRes();
                    Console.WriteLine("Curr radiation   :  " + mars.GetCurR());
                    mars.printPlants();
                    break;
                }
                
            } while (q==0);*/


        }
    }

}