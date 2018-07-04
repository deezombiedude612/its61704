using System;
using System.Collections.Generic;
using System.Text;

namespace Asgn1_0321343_HENG {
    public class DiscreteMathTheory: MathTheory {
		private string part;
		private bool current;

		public DiscreteMathTheory(string name, string founder, string desc, string enterFormula, string thisPart, bool currentNow) : base(name, founder, desc, enterFormula) {
			part = thisPart;
			current = currentNow;
		}

		public DiscreteMathTheory(string name, string founder, string desc, int dLevel, string enterFormula, string thisPart, bool currentNow) : base(name, founder, desc, dLevel, enterFormula) {
			part = thisPart;
			current = currentNow;
		}

		public DiscreteMathTheory(NonDiscreteMathTheory dmt, string thisPart, bool currentNow) : base(dmt.getFactName(), dmt.getFactFounder(), dmt.getFactDesc(), dmt.getDifficultyLevel(), dmt.getFormula()) {
			part = thisPart;
			current = currentNow;
		}

		public override void explanation() {
			Console.WriteLine("(DISCRETE MATH THEORY)");
			Console.WriteLine("Name of Theory: " + base.getFactName());
			Console.WriteLine("Founded by: " + base.getFactFounder());
			Console.WriteLine("Difficulty Level: " + getProperDifficultyLevel());
			Console.WriteLine("\nDescription: \n" + base.getFactDesc() + "\nFormula: " + base.getFormula());
			Console.Write("\nThis theory is used as a part of " + part + " in the field of discrete mathematics");
			if (current)
				Console.Write(",\nand it is still being used in that application today.");
			Console.WriteLine(".");
		}
	}
}
