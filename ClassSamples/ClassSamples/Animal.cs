using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSamples
{
    internal class Animal
    {
        public string name = "";
        public string color = "";
        public string Sing()
        {
            string resultString = "";
            if (name == "ネコ")
            {
                resultString = "にゃー！";
            }
            else if (name == "イヌ")
            {
                resultString = "わんわん！";
            }
            else
            {
                resultString = "?";
            }
            return resultString;
        }
    }
}
