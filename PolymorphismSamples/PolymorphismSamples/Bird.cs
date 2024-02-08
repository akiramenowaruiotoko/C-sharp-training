using System.Drawing;
using PolymorphismSamples.Properties;

namespace PolymorphismSamples
{
    internal class Bird : Animal // inherit from animal class
    {
        public string Beak { get; set; } = "round"; // Beak shape
        public override Image Sing()
        {
            return Resources.BirdCookieSing;
        }

        public override Image Reset()
        {
            return Resources.BirdCookie;
        }
    }
}
