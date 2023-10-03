using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Exercise
{
	internal class Mentor : Person
	{
		private string level;

		public string Level { get => level; set => level = value; }

		public Mentor(string level, string name, int age, string gender):base(name, age, gender)
		{
			this.level = level;
		}

		public Mentor():base("Jane Doe", 30, "Female")
		{
			this.level = "intermediate";
		}

		public override string GetGoal()
		{
			return "My goal is: Educate brilliant junior software developers.";
		}

		public override string ToString()
		{
			return $"{base.ToString()} level: {this.level}";
		}
	}
}
