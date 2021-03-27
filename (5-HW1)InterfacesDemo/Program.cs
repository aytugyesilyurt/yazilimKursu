﻿using System;

namespace _5_HW1_InterfacesDemo
{
    class Program
    {

        // SOLID " I " -- Interface Segregation
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3] {new Worker(), new Manager(), new Robot()};

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2] {new Manager(), new Worker()};

            foreach (var eat in eats)
            {
                eat.Eat();
            }
        }

    }

    interface IWorker
    {
        void Work();
        
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Work()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }
    }

    class Worker: IWorker,IEat, ISalary
    {
        public void Work()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
