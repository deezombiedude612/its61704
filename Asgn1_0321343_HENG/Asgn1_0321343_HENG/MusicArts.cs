using System;
using System.Collections.Generic;
using System.Text;

namespace Asgn1_0321343_HENG {
    public class MusicArts: ArtFact {
		public string knownUse;
		public int knownUseYear;	// if set before year of birth, this piece is used at an unknown time

		public MusicArts(string name, string founder, string desc, int yBirth, int yDeath, string usedAt, int usedWhen): base(name, founder, desc, yBirth, yDeath) {
			knownUse = usedAt;
			knownUseYear = usedWhen;
		}

		public MusicArts(string name, string founder, string desc, int yBirth, string usedAt, int usedWhen) : base(name, founder, desc, yBirth) {
			knownUse = usedAt;
			knownUseYear = usedWhen;
		}

		public MusicArts(string name, string founder, string desc, int yBirth, int yDeath, string usedAt) : base(name, founder, desc, yBirth, yDeath) {
			knownUse = usedAt;
		}

		public MusicArts(string name, string founder, string desc, int yBirth, string usedAt) : base(name, founder, desc, yBirth) {
			knownUse = usedAt;
		}

		public MusicArts(ArtFact at, string usedAt, int usedWhen) : base(at.getFactName(), at.getFactFounder(), at.getFactDesc(), at.getYearOfBirth(), at.getYearOfDeath()) {
			knownUse = usedAt;
			knownUseYear = usedWhen;
		}

		public MusicArts(ArtFact at, string usedAt): base(at.getFactName(), at.getFactFounder(), at.getFactDesc(), at.getYearOfBirth(), at.getYearOfDeath()) {
			knownUse = usedAt;
		}

		public string getKnownUse() {
			return knownUse;
		}
		public void setKnownUse(string usedAt) {
			knownUse = usedAt;
		}

		public int getKnownUseYear() {
			return knownUseYear;
		}
		public void setKnownUseYear(int usedWhen) {
			knownUseYear = usedWhen;
		}

		public override void explanation() {
			Console.WriteLine("(MUSIC FACT)");
			Console.WriteLine("Name of Fact: " + base.getFactName());
			Console.WriteLine("Founded by: " + base.getFactFounder());
			Console.WriteLine("Founder's Year of Birth: " + getProperYearOfBirth());
			if (!base.getAlive())
				Console.WriteLine("Founder's Year of Death: " + getProperYearOfDeath());
			Console.WriteLine("\nDescription: \n" + base.getFactDesc());
			Console.Write("\nRemark: This piece was used by/in " + knownUse + " at ");
			if (knownUseYear < base.getYearOfBirth())
				Console.WriteLine(" at unknown time.");
			else
				Console.WriteLine(knownUseYear + ".");
		}
	}
}
