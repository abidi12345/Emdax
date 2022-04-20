using FarmSystem.Test2;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FarmSystem.Test1
{



    public class EmydexFarmSystem: IMilkableAnimal
    {

        public List<object> Holdanimal = new List<object>();
        //TEST 1
        public void Enter(object animal)
         {
            //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
            //Hold all the animals so it is available for future activities

            // Reflection method 
            animal.GetType().GetMethod("Enter").Invoke(animal, null);
            Holdanimal.Add(animal);

        }

        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            foreach (var GetAnimal in Holdanimal)
            {
                // Reflection method 
                GetAnimal.GetType().GetMethod("Talk").Invoke(GetAnimal, null);

            }

        }

        //interface method
        public void ProduceMilk()
        {
            foreach (var GetValueforAnimal in Holdanimal)
            {
                Type GetAnimal = GetValueforAnimal.GetType();

                if (GetAnimal.Name=="Cow" )
                {
                    GetValueforAnimal.GetType().GetMethod("ProduceMilk").Invoke(GetValueforAnimal, null);
                }
                
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            ProduceMilk();
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {

            foreach (var D in Holdanimal)
            {
                Type t = D.GetType();

                D.GetType().GetMethod("Exit").Invoke(D, null);
               
            }
            // empty container
            Holdanimal.Clear();
            Console.WriteLine("Emydex Farm is now empty");
        }
    }
}