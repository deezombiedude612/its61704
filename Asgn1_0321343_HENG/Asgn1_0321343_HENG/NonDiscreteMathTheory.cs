using System;
using System.Collections.Generic;
using System.Text;

namespace Asgn1_0321343_HENG {
    public class NonDiscreteMathTheory: MathTheory {
		private string field;
		private string application;

		public NonDiscreteMathTheory(string name, string founder, string desc, string enterFormula, string thisField, string thisApplication) : base(name, founder, desc, enterFormula) {
			field = thisField;
			application = thisApplication;
		}

		public NonDiscreteMathTheory(string name, string founder, string desc, int dLevel, string enterFormula, string thisField, string thisApplication) : base(name, founder, desc, dLevel, enterFormula) {
			field = thisField;
			application = thisApplication;
		}

		public NonDiscreteMathTheory(DiscreteMathTheory dmt, string thisField, string thisApplication): base(dmt.getFactName(), dmt.getFactFounder(), dmt.getFactDesc(), dmt.getDifficultyLevel(), dmt.getFormula()) {
			field = thisField;
			application = thisApplication;
		}

		public override void explanation() {
			Console.WriteLine("(NON-DISCRETE MATH THEORY)");
			Console.WriteLine("Name of Theory: " + base.getFactName());
			Console.WriteLine("Founded by: " + base.getFactFounder());
			Console.WriteLine("Difficulty Level: " + getProperDifficultyLevel());
			Console.WriteLine("\nDescription: \n" + base.getFactDesc() + "\nFormula: " + base.getFormula());
			Console.WriteLine("\nThis theory is used in " + application + " in the field of " + field + ".");
		}
	}
}
