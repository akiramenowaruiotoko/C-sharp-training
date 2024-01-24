using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSamples
{
	internal class Cat : Animal
	{
		// describe only the parts that are not defined in the Animal class
		public string? Ear { get; set; } // ear chape properties

		// can also add own cat class methods
		public static string CatSing()
		{
			return "Meow!";
		}
	}
}
