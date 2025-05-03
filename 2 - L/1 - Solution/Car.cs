using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._2___L._1___Solution
{
    internal class Car : ISpeedUp, IPark, IBrake
    {
        public void Brake()
        {
            throw new NotImplementedException();
        }

        public void Park()
        {
            throw new NotImplementedException();
        }

        public void SpeedUp()
        {
            throw new NotImplementedException();
        }
    }
}
