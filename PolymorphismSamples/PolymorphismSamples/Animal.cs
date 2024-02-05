using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolymorphismSamples.Properties;

namespace PolymorphismSamples
{
    internal class Animal
    {
        // define common values for all animal cookies
        public string Color { get; set; } = "brown";
        public string Smell { get; set; } = "coffee";
        public string Flavor { get; set; } = "chocolate";

        // aminal sing
        public virtual Image Sing()
        {
            return Resources.AnimalCookieSing;
        }

        public virtual Image Reset()
        {
            return Resources.AnimalCookie;
        }
    }
}
