using System;
using System.Collections.Generic;

namespace Test
{
    public class Worker : IWorker
    {
        public int hours
        {
            get;
            set;
        }

        public int salary
        {
            get;
            set;
        }

        public string gender;

        //første constructor
        public Worker(int hours, int salary)
        {
            this.hours = hours;
            this.salary = salary;
        }

        //Anden Constructor
        public Worker(int hours, int salary, string gender)
        {
            this.hours = hours;
            this.salary = salary;
            this.gender = gender;
        }

        public int CalculateSalary()
        {
            return this.hours * this.salary;
        }

        public static List<Worker> GetAllWorkers()
        {
            Worker Joe = new Worker(30, 100, "mand");
            Worker Moe = new Worker(30, 100, "mand");
            Worker Ingeborg = new Worker(30, 100, "Dame");

            List<Worker> WorkerList = new List<Worker>() { Joe, Moe, Ingeborg };

            return WorkerList;
        }


    }
}
