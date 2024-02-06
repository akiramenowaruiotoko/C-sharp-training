using System.Drawing;
using PolymorphismSamples.Properties;

namespace PolymorphismSamples
{
    internal class Dog : Animal // inherit from animal class
    {
        public string Nose { get; set; } = "round"; // nose shape
        public override Image Sing()
        {
            return Resources.DogCookieSing;
        }

        public override Image Reset()
        {
            return Resources.DogCookie;
        }
    }
}
