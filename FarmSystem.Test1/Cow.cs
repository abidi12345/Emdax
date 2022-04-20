﻿using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1
{
    public class Cow: IMilkableAnimal
    {
        private string _id;
        private int _noOfLegs = 4;


        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = 4;
            }
        }

        public void Talk()
        {
            Console.WriteLine("Cow says Moo!");
        }

        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Cow produced milk");
        }

        public void Run()
        {
            Console.WriteLine("Cow is running");
        }
        public void Enter()
        {
            Console.WriteLine("Cow has entered the farm");
        }

        public void Exit()
        {
            Console.WriteLine("Cow has left the farm");
        }
    }
}