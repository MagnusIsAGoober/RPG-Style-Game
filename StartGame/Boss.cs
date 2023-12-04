using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRPG
{
    public class Boss : Enemy
    {  

        public Boss() : base ("Big Boss")
            {
                Health = 150;
            }

    }
}
