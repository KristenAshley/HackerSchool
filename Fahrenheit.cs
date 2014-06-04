using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversationAbroad
{
    class Fahrenheit
    {
        public Fahrenheit(float temp)
        {
            degrees = temp;
        }
        // Must be defined inside a class called Fahrenheit: 
        public static explicit operator Celsius(Fahrenheit fahr)
        {
            return new Celsius((5.0f / 9.0f) * (fahr.degrees - 32));
        }
        public float Degrees
        {
            get { return degrees; }
        }
        private float degrees;
    }
}
