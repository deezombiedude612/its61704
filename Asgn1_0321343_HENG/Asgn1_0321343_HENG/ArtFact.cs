using System;
using System.Collections.Generic;
using System.Text;

namespace Asgn1_0321343_HENG
{
    public class ArtFact: Fact, IYear {
		private int yearOfBirth;
		private int yearOfDeath;
		private bool stilLAlive;

		public ArtFact(string name, string founder, string desc, int yBirth, int yDeath) : base(name, founder, desc) {
			if (yearOfDeath < yearOfBirth)
				new ArtFact(name, founder, desc, yBirth);
			else {
				yearOfBirth = yBirth;
				yearOfDeath = yDeath;
				stilLAlive = false;
			}
		}

		public ArtFact(string name, string founder, string desc, int yBirth) : base(name, founder, desc) {
			yearOfBirth = yBirth;
			yearOfDeath = 0;
			stilLAlive = true;
		}
	
		public int getYearOfBirth() {
			return yearOfBirth;
		}
		public string getProperYearOfBirth() {
			string properYearOfBirth = "";
			if (yearOfBirth < 0)
				properYearOfBirth = (-1 * yearOfBirth).ToString() + "B.C.";
			else
				properYearOfBirth = yearOfBirth.ToString();

			return properYearOfBirth;
		}
		public void setYearOfBirth(int yBirth) {
			yearOfBirth = yBirth;
		}

		public int getYearOfDeath() {
			return yearOfDeath;
		}
		public string getProperYearOfDeath() {
			string properYearOfDeath = "";
			if (yearOfDeath < 0)
				properYearOfDeath = (-1 * yearOfDeath).ToString() + "B.C.";
			else
				properYearOfDeath = yearOfDeath.ToString();

			return properYearOfDeath;
		}
		public void setYearOfDeath(int yDeath) {
			yearOfDeath = yDeath;
			stilLAlive = false;
		}
		public void eraseYearOfDeath() {
			stilLAlive = true;
		}

		public bool getAlive() {
			return stilLAlive;
		}

		public override void explanation() {
			Console.WriteLine("(ART FACT)");
			Console.WriteLine("Name of Fact: " + base.getFactName());
			Console.WriteLine("Founded by: " + base.getFactFounder());
			Console.WriteLine("Founder's Year of Birth: " + getProperYearOfBirth());
			if (!stilLAlive)
				Console.WriteLine("Founder's Year of Death: " + getProperYearOfDeath());
			Console.WriteLine("\nDescription: \n" + base.getFactDesc());
		}
	}
}
