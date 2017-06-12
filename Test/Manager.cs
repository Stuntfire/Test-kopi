using System;
namespace Test
{
	public class Manager : IWorker, IBoard 
	{
        public int hours;

        public int salary;

		public Manager(int hours, int salary)
		{
			this.hours = hours;
			this.salary = salary;
		}

		public int CalculateSalary()
		{
			return (this.hours * salary) + 5000;
		}

		public void GoToMeeting()
		{
			Console.WriteLine("Manageren går til møde...");
		}

		
	}
}
