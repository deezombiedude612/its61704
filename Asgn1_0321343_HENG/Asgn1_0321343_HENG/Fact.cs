using System;
using System.Collections.Generic;
using System.Text;

namespace Asgn1_0321343_HENG
{
    public class Fact {
		private string factName;
		private string factFounder;
		private string factDesc;
		private string refCode;

		/*
		 * refCode is always T here.
		 * MT	: Math Theory
		 * MA	: Algebra Theory
		 * MS	: Statistics Theory
		 * A	: Art Theory
		 */

		public Fact(string name, string founder, string desc) {
			factName = name;
			factFounder = founder;
			factDesc = desc;
			refCode = "T";
		}

		public string getFactName() {
			return factName;
		}
		public void setFactName(string name) {
			factName = name;
		}

		public string getFactFounder() {
			return factFounder;
		}
		public void setFactFounder(string founder) {
			factFounder = founder;
		}

		public string getFactDesc() {
			return factDesc;
		}
		public void setFactDesc(string desc) {
			factDesc = desc;
		}

		public string getRefCode() {
			return refCode;
		}
		public void setRefCode(string newRef) {
			refCode = newRef;
		}

		public virtual void explanation() {
			Console.WriteLine("Name of Fact: " + factName);
			Console.WriteLine("Founded by: " + factFounder);
			Console.WriteLine("\nDescription: \n" + factDesc);
		}
    }
}
