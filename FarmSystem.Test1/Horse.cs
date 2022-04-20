
using System;

namespace FarmSystem.Test1
{
    public class Horse
    {
        private string _id;
        private int _noOfLegs;

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
            Console.WriteLine("Horse says neigh!");
        }

        public void Run()
        {
            Console.WriteLine("Horse is running");
        }
        public void Enter()
        {
            Console.WriteLine("Horse has entered the farm");
        }

        public void Exit()
        {
            Console.WriteLine("Horse has left the farm");
        }
    }
}