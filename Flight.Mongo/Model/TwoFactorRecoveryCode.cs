using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Mongo.Model
{
    internal class TwoFactorRecoveryCode
    {
        public string Code { get; set; }

        public bool Redeemed { get; set; }
    }
}
