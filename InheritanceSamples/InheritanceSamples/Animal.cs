using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSamples
{
	internal class Animal
	{
		// define common value for all animal cookie
		public string? Color { get; set; } // color properties
		public string? Smell { get; set; } // smell properties
		public string? Flavor { get; set; } // flavor properties

		// animal sounds
		public static string Sing()
		{
			return "・・・";
		}
	}
}
