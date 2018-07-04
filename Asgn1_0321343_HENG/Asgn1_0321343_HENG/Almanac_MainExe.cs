using System;

namespace Asgn1_0321343_HENG {
	public class Almanac_MainExe {
		public static void Main(string[] args) {
			Console.WriteLine("\n---------------------------------------MINI FACTS ALMANAC (STRIPPED)---------------------------------------");
			menu();
		}

		public static void menu() {
			Fact[] facts = init();

			Console.WriteLine("\nInitial Facts contents: ");
			displayFacts(facts);
			printDivider(100, '*');
			facts = updateFacts(facts);
			Console.WriteLine("\nCurrent Facts contents: ");
			displayFacts(facts);
			Console.WriteLine("\n---------------------------------------THANK YOU---------------------------------------");
		}
		/*
		public static void menu_old() {
			Theory[] theories = init();		// initialize the theorems for viewing or editing
			while (choice != -1) {
				if (choice == 0) {		// display all options when choice == 0
					Console.WriteLine();
					Console.WriteLine("\t1. Print All Theorems");
					Console.WriteLine("\t2. Edit Theorem Details");
					Console.WriteLine("\t3. Add Theorem");
					Console.WriteLine("\t4. Delete Theorem");
				}
				Console.Write("\nEnter option (0 for options, -1 to exit) >> ");
				choice = Convert.ToInt32(Console.ReadLine());

				switch(choice) {
					case 1:
						printDivider(50, '=');
						for (int i = 0; i < theories.Length; i++) {
							Console.WriteLine("\nTHEORY #" + (i + 1));
							theories[i].explanation();
						}
						Console.WriteLine();
						printDivider(50, '=');
						break;

					case 2:
						printDivider(50, '*');
						theories = edit(theories);
						Console.WriteLine();
						printDivider(50, '*');
						break;

					case 3:

						break;

					case 4:
						break;

					case 0:		// display menu case here
					case -1:	// exit case here
						break;

					default:
						Console.WriteLine("Invalid input detected. Try again.\n");
						break;
				}
			}
		}*/

		/* initialization of saved theorems */
		public static Fact[] init() {
			Fact mt1 = new MathTheory("Pythagoras Theorem", "Pythagoras"
				, "In a triangle, the length of hypotenuse squared is the sum of the squares of the other two sides of the triangle."
				, 1, "a^2 + b^2 = c^2");
			Fact mt2 = new MathTheory("Binomial Theorem", "Euclid"
				, "Also known as binomial expansion, it describes the algebraic expansion of powers of a binomial."
				, 2, "(x + y)^n = nC0(x^n)(y^0) + nC1(x^(n-1))(y^1) + ... + nCn(x^0)(y^n)");
			Fact at1 = new ArtFact("Mona Lisa", "Leonardo Da Vinci"
				, "An aura of mystery surrounds this painting, which is veiled in a soft light, creating an atmosphere of enchantment." 
				+ "\nThere are no hard lines or contours here (a technique of painting known as sfumato—fumo in Italian means “smoke”), " 
				+ "\nonly seamless transitions between light and dark. Perhaps the most striking feature of the painting is the sitter’s " 
				+ "\nambiguous half smile. She looks directly at the viewer, but her arms, torso, and head each twist subtly in a " 
				+ "\ndifferent direction, conveying an arrested sense of movement. Leonardo explores the possibilities of oil paint in " 
				+ "\nthe soft folds of the drapery, texture of skin, and contrasting light and dark (chiaroscuro). The deeply receding " 
				+ "\nbackground, with its winding rivers and rock formations, is an example of Leonardo’s personal view of the natural " 
				+ "\nworld: one in which everything is liquid, in flux, and filled with movement and energy."
				, 1452, 1519); // source: https://www.metmuseum.org/toah/hd/leon/hd_leon.htm
			Fact at2 = new ArtFact("Major General's Song", "Gilbert and Sullivan"
				, "NOTE: Year of Birth and Death are inaccurate." 
				+ "\n\"I Am the Very Model of a Modern Major-General\" (often referred to as the \"Major-General's Song\" or \"Modern " 
				+ "\nMajor-General's Song\") is a patter song from Gilbert and Sullivan's 1879 comic opera The Pirates of Penzance. It is " 
				+ "\nperhaps the most famous song in Gilbert and Sullivan's operas. It is sung by Major General Stanley at his first " 
				+ "\nentrance, towards the end of Act I. The song satirises the idea of the \"modern\" educated British Army officer " 
				+ "\nof the latter 19th century. It is one of the most difficult patter songs to perform, due to the fast pace and " 
				+ "\ntongue-twisting nature of the lyrics."
				, 1800, 1900); // source: https://en.wikipedia.org/wiki/Major-General%27s_Song
			Fact mt3 = new NonDiscreteMathTheory("Fermat's Little Theorem", "Pierre de Fermat"
				, "If p is a prime and a is any integer not divisible by p, then a^(p − 1) − 1 is divisible by p."
				, 3, "a^(p - 1) = 1 (mod p)", "Statistics", "accounting");

			Fact[] theories = { mt1, mt2, at1, at2, mt3 };
			return theories;
		}

		public static Fact[] updateFacts(Fact[] facts) {
			Fact new_at1 = new MusicArts((ArtFact)facts[3], "Despicable Me 3", 2017);   // specifying ArtFact as its subclass MusicArts
			Fact new_at2 = new DiscreteMathTheory((NonDiscreteMathTheory)facts[4], "Number Theory", true);	// sub-polymorphism from NonDiscreteMathTheory to DiscreteMathTheory

			Fact[] updatedFacts = { facts[0], facts[1], facts[2], new_at1, new_at2 };
			return updatedFacts;
		}

		/* prints details of theories */
		public static void displayFacts(Fact[] facts) {
			for (int i = 0; i < facts.Length; i++) {
				if (i != 0) {
					Console.WriteLine();
					printDivider(110, '#');
				}
				Console.Write("\nFACT #" + (i + 1) + " ");
				facts[i].explanation();
			}
			Console.WriteLine();
		}

		/* prints divider for aesthetic reasons */
		public static void printDivider(int length, char filler) {
			for (int i = 0; i < length; i++)
				Console.Write(filler);
			Console.WriteLine();
		}
	}
}
