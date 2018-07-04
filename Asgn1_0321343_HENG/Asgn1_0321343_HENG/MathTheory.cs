using System;
using System.Collections.Generic;
using System.Text;

namespace Asgn1_0321343_HENG
{
    public class MathTheory: Fact, I_MathFormula {
		private int difficultyLevel;    // 1 - easy, 2 - mediocre, 3 - hard
		private string formula;

		public MathTheory(string name, string founder, string desc, string enterFormula) : base(name, founder, desc) {
			base.setRefCode("MT");
			formula = enterFormula;
			difficultyLevel = 0;
		}

		public MathTheory(string name, string founder, string desc, int dLevel, string enterFormula) : base(name, founder, desc) {
			base.setRefCode("MT");
			formula = enterFormula;
			if (dLevel >= 1 && dLevel <= 3)
				difficultyLevel = dLevel;
			else {
				difficultyLevel = 0;
				Console.WriteLine("Unable to update difficulty level. Valid range: [1, 3]");
			}
		}

		public int getDifficultyLevel() {
			return difficultyLevel;
		}
		public string getProperDifficultyLevel() {
			switch(difficultyLevel) {
				case 1:
					return "Easy";

				case 2:
					return "Mediocre";

				case 3:
					return "Difficult";

				default:
					return "Unknown";
			}
		}
		public void setDifficultyLevel(int dLevel) {
			if (dLevel >= 1 && dLevel <= 3)
				difficultyLevel = dLevel;
			else
				Console.WriteLine("Unable to update difficulty level. Valid range: [1, 3]");
		}

		public string getFormula() {
			return formula;
		}
		public void setFormula(string newFormula) {
			formula = newFormula;
		}

		public override void explanation() {
			Console.WriteLine("(MATH THEORY)");
			Console.WriteLine("Name of Theory: " + base.getFactName());
			Console.WriteLine("Founded by: " + base.getFactFounder());
			Console.WriteLine("Difficulty Level: " + getProperDifficultyLevel());
			Console.WriteLine("\nDescription: \n" + base.getFactDesc() + "\nFormula: " + formula);
		}
	}
}
