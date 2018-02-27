using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAClassLib
{
    public class testHA
    {
        /// <summary>
        /// Die Methode vergleicht zwei String und gibt nur
        /// dann "true" zurück, wenn folgende Einschränkungen
        /// erfüllt sind:
        /// <code>
        /// one.Equals(two) &amp;&amp; one.Length &lt; 10 &amp;&amp; two.Length &lt; 10
        /// </code>
        /// </summary>
        /// <param name="one">erster String</param>
        /// <param name="two">zweiter String</param>
        /// <returns>true, wenn die beiden Strings gleich
        /// und jeweils kürzer als 10 Zeichen sind
        /// </returns>
        public bool Compare(string one, string two)
        {
            if (one.Equals(two) && one.Length < 10
            && two.Length < 10)
                return true;
            else
                return false;
        }

    }

}
