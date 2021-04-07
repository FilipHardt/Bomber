using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stresstest
{
    public abstract class BomberBaseGuid
    {
        public Guid Id { get; private set; }

        protected BomberBaseGuid()
        {
            Id = Guid.NewGuid();
        }
    }
}
