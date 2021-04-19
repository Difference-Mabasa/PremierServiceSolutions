using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions
{
    class StandardContract : Contract
    {
        public override double Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
