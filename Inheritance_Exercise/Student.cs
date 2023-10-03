using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise
{
	internal class Student: Person
	{
		private string previousOrganization;
		private int skippedDays;

		public Student(string previousOrganization, string name, int age, string gender): base(name, age, gender)
		{
			this.previousOrganization = previousOrganization;
			this.skippedDays = 0;
		}
		public Student():base("Jane Doe", 30, "Croissant")
		{
			this.previousOrganization = "School of Life";
			this.skippedDays = 0;
		}

		public override string GetGoal()
		{
			return $"My goal is: Be a Junior software developer";
		}
	}
}
