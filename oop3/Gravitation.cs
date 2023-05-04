//acceleratia gravitationala pe luna = 1,6  m / s^2 (Reprezintă schimbarea vitezei unui obiect în timp);
// accceleratia gravitationala pe pamant = 9,807;




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    class Gravitation
    {
        private readonly double weight;

        private readonly double gravityOfMoon;

        private readonly double gravityOfEarth;


        // constructor 

        public Gravitation(double weight, double gravityOfMoon, double gravityOfEarth)
        {
            this.weight = weight;

            this.gravityOfMoon = gravityOfMoon;

            this.gravityOfEarth = gravityOfEarth;


        }
        public double GravitationOnTheMoon()
        {
            double calculeazaGravitate = weight * (gravityOfMoon / gravityOfEarth);

            return calculeazaGravitate;
        }


    }

}