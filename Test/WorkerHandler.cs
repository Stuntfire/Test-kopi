using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class WorkerHandler:IWorker
    {

        public WorkerHandler()
        {

        }
        public int CalculateSalary()
        {
            return this.hours * this.salary;
        }

        public void DoingWork()
        {
            Console.WriteLine("Personen arbejder...");
        }

        public void GoToWork()
        {
            Console.WriteLine("Personen tager på arbejde");
        }
    }
}
