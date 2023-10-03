using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise
{
	internal class Sponsor : Person
	{
		private string company;
		private int hiredStudents;

		public string Company { get => company; set => company = value; }
		public int HiredStudents { get => hiredStudents; set => hiredStudents = value; }

		public Sponsor(string company, int hiredStudents, string name, int age, string gender):base(name, age, gender)
		{
			this.company = company;
			this.hiredStudents = hiredStudents;
		}

		public Sponsor():base("Jane Doe", 30, "croissant")
		{
			this.company = "Google";
			this.hiredStudents = 0;
		}

		public int Hire()
		{
			hiredStudents++;
			return hiredStudents;
		}

		public override string GetGoal()
		{
			return "My goal is: Hire brilliant junior software developers.";
		}

		public override string ToString() 
		{
			return $"{base.ToString()} who represents {this.company} and hired {this.hiredStudents} students so far";
		}
	}
}
