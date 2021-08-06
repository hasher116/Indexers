using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class OverloadingPeople
    {
        OverloadingPerson[] data;
        public OverloadingPeople()
        {
            data = new OverloadingPerson[5];
        }
        public OverloadingPerson this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
        public OverloadingPerson this[string name]
        {
            get
            {
                OverloadingPerson overloadingPerson = null;
                foreach(var p in data)
                {
                    if(p?.Name == name)
                    {
                        overloadingPerson = p;
                        break;
                    }
                }
                return overloadingPerson;
            }
        }
    }
}
