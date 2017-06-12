using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Boss : IWorker, IBoard
    {
        public Boss(int hours, int salary)
        {

        }

        public int CalculateSalary()
        {
            throw new NotImplementedException();
        }

        public void DoingWork()
        {
            throw new NotImplementedException();
        }

        public void GoToMeeting()
        {
            throw new NotImplementedException();
        }

        public void GoToWork()
        {
            throw new NotImplementedException();
        }
    }
}
